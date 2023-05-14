using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpraHomework.Repository.Migrations
{
    public partial class intialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "AddressLine1", "City", "Country", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FirstName", "LastName", "Phone", "Province" },
                values: new object[] { 1, "Test", "Test", "Test", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sezin salli", new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "sezinsalli1@gmail.com", "Sezin", "Şallı", "05383187542", "Test" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "AddressLine1", "City", "Country", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FirstName", "LastName", "Phone", "Province" },
                values: new object[] { 2, "Test", "Test", "Test", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fatih salli", new DateTime(1990, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatihsalli1@gmail.com", "Fatih", "Şallı", "05384568541", "Test" });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Email",
                table: "Staffs",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
