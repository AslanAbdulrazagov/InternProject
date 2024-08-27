using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e2733e9-c447-4b6e-b886-649c0521427d",
                column: "NormalizedEmail",
                value: "USER@GMAIL.COM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e2733e9-c447-4b6e-b886-649c0521427d",
                column: "NormalizedEmail",
                value: "user@gmail.com");
        }
    }
}
