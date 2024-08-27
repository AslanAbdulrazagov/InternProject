using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Upd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e2733e9-c447-4b6e-b886-649c0521427d",
                column: "NormalizedEmail",
                value: "user@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e2733e9-c447-4b6e-b886-649c0521427d",
                column: "NormalizedEmail",
                value: "TEST@UP.COM");
        }
    }
}
