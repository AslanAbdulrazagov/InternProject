using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "EmployeId", "State", "Street" },
                values: new object[,]
                {
                    { -6, "Baku", -6, "Azerbaijan", "Samad Vurgun 56" },
                    { -5, "Baku", -5, "Azerbaijan", "Nariman Narimanov 34A" },
                    { -4, "Baku", -4, "Azerbaijan", "Heyder Aliyev 555" },
                    { -3, "Baku", -3, "Azerbaijan", "Babek 8" },
                    { -2, "Baku", -2, "Azerbaijan", "Nizami 15" },
                    { -1, "Baku", -1, "Azerbaijan", "Xatai 123" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -3, "Development" },
                    { -2, "Sales" },
                    { -1, "Operations" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddressId", "DepartmentId", "Email", "Fullname", "PhoneNumber" },
                values: new object[,]
                {
                    { -6, -6, -2, "musamuradlii0@gmail.com", "Musa Muradli", "+994515559988" },
                    { -5, -5, -2, "asiman001@gmail.com", "Asiman Gasimzade", "+994501111111" },
                    { -4, -4, -1, "ibrahim85@gmail.com", "Ibrahim Madatzade", "+994501111111" },
                    { -3, -3, -1, "rizvan111@gmail.com", "Rizvan Veliyev", "+994501111111" },
                    { -2, -2, -3, "bendiyevf@gmail.com", "Farid Bandiyev", "+994515770420" },
                    { -1, -1, -3, "aslanabdulrazaqov496@gmail.com", "Aslan Abdulrazagov", "+994504341151" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
