using AutoMapper;
using Business.Services.Interfaces;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Services.Implementations
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public AddressService(IAddressRepository repository, IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<ResultDto> CreateAsync(AddressPostDto dto)
        {
            //var isExist = await _repository.IsExistAsync(x => x.Street.ToLower() == dto.Street.ToLower());

            //if (isExist)
            //    throw new AlreadyExistException($"{dto.Street} this street already exists");

            var employee = await _employeeRepository.GetSingleAsync(x => x.Id == dto.EmployeId);

            if (employee is null)
                throw new NotFoundException();

            if (employee.AddressId is { })
                throw new AlreadyExistException("This employee's address is already exist");

            var address = _mapper.Map<Address>(dto);

            employee.Address = address;

            await _repository.CreateAsync(address);
            await _repository.SaveChangesAsync();

             _employeeRepository.Update(employee);
            await _employeeRepository.SaveChangesAsync(); 

            return new("Address successfully added");
        }

        public async Task<ResultDto> DeleteAsync(int id)
        {
            var address = await _repository.GetSingleAsync(x => x.Id == id);

            if (address is null)
                throw new NotFoundException();


            var employee= await _employeeRepository.GetSingleAsync(x=>x.Id == address.EmployeId);


            if(employee is null)
                throw new NotFoundException();


            employee.AddressId = null;


            _employeeRepository.Update(employee);
            await _employeeRepository.SaveChangesAsync();

            _repository.Delete(address);
            await _repository.SaveChangesAsync();
            return new("Address was deleted");
        }

        public async Task<List<AddressGetDto>> GetAllAsync()
        {
            var addresses = await _repository.GetAll().ToListAsync();
            var result = _mapper.Map<List<AddressGetDto>>(addresses);
            return result;
        }

        public async Task<AddressGetDto> GetByIdAsync(int id)
        {
            var existAddress = await _repository.GetSingleAsync(x => x.Id == id);

            if (existAddress is null)
                throw new NotFoundException();

            var result = _mapper.Map<AddressGetDto>(existAddress);
            return result;
        }

        public async Task<ResultDto> UpdateAsync(AddressPutDto dto)
        {
            var existAddress = await _repository.GetSingleAsync(x => x.Id == dto.Id);

            if (existAddress is null)
                throw new NotFoundException($"{dto.Id}-this address is not found");
            //var isExist = await _repository.IsExistAsync(x => x.Street.ToLower() == dto.Street.ToLower() && x.Id != dto.Id);
            //if (isExist)
            //    throw new AlreadyExistException($"{dto.Street}-Street already exists");
            _mapper.Map(dto, existAddress);

            _repository.Update(existAddress);
            await _repository.SaveChangesAsync();

            return new($"{existAddress.Street}-address is successfully updated");
        }
    }
}
