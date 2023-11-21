using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DejaVu.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "Image", "Name", "Position", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/Martin.jpg", "Martin", "Marketing Expert", "Simpson" },
                    { 2, new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/Jacob.jpg", "Jacob", "Manager", "Hawk" },
                    { 3, new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/Elizabeth.jpg", "Elizabeth", "Software Engineer", "Geil" },
                    { 4, new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/Kate.jpg", "Kate", "Admin", "Metain" },
                    { 5, new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/Michael.jpg", "Michael", "Marketing Expert", "Cook" },
                    { 6, new DateTime(2001, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/John.jpg", "John", "Software Engineer", "Snow" },
                    { 7, new DateTime(1999, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/Nina.jpg", "Nina", "Software Engineer", "Soprano" },
                    { 8, new DateTime(2000, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/Tina.jpg", "Tina", "Team Leader", "Fins" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}