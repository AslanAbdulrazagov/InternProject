using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Helpers
{
    public static class DbContextSeedData
    {
        public static void AddSeedData(this ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(
                new Department { Id = -1, Name = "Operations" },
                new Department { Id = -2, Name = "Sales" },
                new Department { Id = -3, Name = "Development" }


                );
            builder.Entity<Address>().HasData(
                new Address { Id = -1, Street = "Xatai 123", City = "Baku", State = "Azerbaijan", EmployeId = -1 },
                new Address { Id = -2, Street = "Nizami 15", City = "Baku", State = "Azerbaijan", EmployeId = -2 },
                new Address { Id = -3, Street = "Babek 8", City = "Baku", State = "Azerbaijan", EmployeId = -3 },
                new Address { Id = -4, Street = "Heyder Aliyev 555", City = "Baku", State = "Azerbaijan", EmployeId = -4 },
                new Address { Id = -5, Street = "Nariman Narimanov 34A", City = "Baku", State = "Azerbaijan", EmployeId = -5 },
                new Address { Id = -6, Street = "Samad Vurgun 56", City = "Baku", State = "Azerbaijan", EmployeId = -6 }

                );

            builder.Entity<Employee>().HasData(
                new Employee { Id = -1, Fullname = "Aslan Abdulrazagov", Email = "aslanabdulrazaqov496@gmail.com", PhoneNumber = "+994504341151", DepartmentId = -3, AddressId = -1 },
                new Employee { Id = -2, Fullname = "Farid Bandiyev", Email = "bendiyevf@gmail.com", PhoneNumber = "+994515770420", DepartmentId = -3, AddressId = -2 },
                new Employee { Id = -3, Fullname = "Rizvan Veliyev", Email = "rizvan111@gmail.com", PhoneNumber = "+994501111111", DepartmentId = -1, AddressId = -3 },
                new Employee { Id = -4, Fullname = "Ibrahim Madatzade", Email = "ibrahim85@gmail.com", PhoneNumber = "+994501111111", DepartmentId = -1, AddressId = -4 },
                new Employee { Id = -5, Fullname = "Asiman Gasimzade", Email = "asiman001@gmail.com", PhoneNumber = "+994501111111", DepartmentId = -2, AddressId = -5 },
                 new Employee { Id = -6, Fullname = "Musa Muradli", Email = "musamuradlii0@gmail.com", PhoneNumber = "+994515559988", DepartmentId = -2, AddressId = -6 }
                );
        }

    }

}
