﻿using Core.Entities;
using Microsoft.AspNetCore.Identity;
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

            //
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }
                );
            AppUser admin = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "+994503333333",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEDdLO1SLo+fL4dtyowe2YICHHWdqr3qZSPnnGzVGyXAm9ApcNEXwiErejIkt92ntGA==",
                SecurityStamp = "3ZCJFKS42EGSBCLTVX4M6E37KLRKYGBM",
                ConcurrencyStamp = "632d70d1-cf0f-48ed-8735-7a471433acec",
                Fullname = "Admin"
            };

       
            builder.Entity<AppUser>().HasData(admin);

            AppUser user = new AppUser()
            {
                Id = "8e2733e9-c447-4b6e-b886-649c0521427d",
                UserName = "User",
                Email = "user@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "+994505555555",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEDdLO1SLo+fL4dtyowe2YICHHWdqr3qZSPnnGzVGyXAm9ApcNEXwiErejIkt92ntGA==",
                SecurityStamp = "TPDGZHBNWJDLPNAI5U746VHYPV4KJKRQ",
                ConcurrencyStamp = "33e31b8f-14a0-4b0e-86d4-7c877c1ae93e",
                Fullname = "User"
                

            };

         
            builder.Entity<AppUser>().HasData(user);


            IdentityUserRole<string> adminRole = new IdentityUserRole<string>()
            {
                UserId= "b74ddd14-6340-4840-95c2-db12554843e5",
                RoleId= "fab4fac1-c546-41de-aebc-a14da6895711"
            };
            builder.Entity<IdentityUserRole<string>>().HasData(adminRole);

            IdentityUserRole<string> userRole = new IdentityUserRole<string>()
            {
                UserId = "8e2733e9-c447-4b6e-b886-649c0521427d",
                RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRole);
           
        }

    }

}
