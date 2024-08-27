using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class UsersSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", "User", "USER" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fullname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e2733e9-c447-4b6e-b886-649c0521427d", 0, "33e31b8f-14a0-4b0e-86d4-7c877c1ae93e", "user@gmail.com", true, "User", false, null, "TEST@UP.COM", null, "AQAAAAEAACcQAAAAEDdLO1SLo+fL4dtyowe2YICHHWdqr3qZSPnnGzVGyXAm9ApcNEXwiErejIkt92ntGA==", "+994505555555", false, "TPDGZHBNWJDLPNAI5U746VHYPV4KJKRQ", false, "User" },
                    { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "632d70d1-cf0f-48ed-8735-7a471433acec", "admin@gmail.com", true, "Admin", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEDdLO1SLo+fL4dtyowe2YICHHWdqr3qZSPnnGzVGyXAm9ApcNEXwiErejIkt92ntGA==", "+994503333333", false, "3ZCJFKS42EGSBCLTVX4M6E37KLRKYGBM", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "8e2733e9-c447-4b6e-b886-649c0521427d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db12554843e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "8e2733e9-c447-4b6e-b886-649c0521427d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db12554843e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e2733e9-c447-4b6e-b886-649c0521427d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");
        }
    }
}
