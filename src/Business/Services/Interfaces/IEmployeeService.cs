using Core.Entities;
using System.Linq.Expressions;

namespace Business.Services.Interfaces;

public interface IEmployeeService
{

    Task<ResultDto> CreateAsync(EmployeePostDto dto);

    Task<ResultDto> UpdateAsync(EmployeePutDto dto);
    Task<ResultDto> DeleteAsync(int id);
    Task<EmployeeGetDto> GetByIdAsync(int id);
    Task<bool> IsExistAsync(Expression<Func<Employee,bool>> expression); 
    
    Task<List<EmployeeGetDto>> GetAllAsync();
}
