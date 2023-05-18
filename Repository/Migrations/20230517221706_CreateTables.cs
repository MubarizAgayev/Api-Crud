using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 18, 2, 17, 5, 763, DateTimeKind.Local).AddTicks(3286), "Azerbaycan", false },
                    { 2, new DateTime(2023, 5, 18, 2, 17, 5, 763, DateTimeKind.Local).AddTicks(3289), "Turkiye", false },
                    { 3, new DateTime(2023, 5, 18, 2, 17, 5, 763, DateTimeKind.Local).AddTicks(3290), "Ingiltere", false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "CreatedAt", "FullName", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "Sumqayit", 27, new DateTime(2023, 5, 18, 2, 17, 5, 763, DateTimeKind.Local).AddTicks(3122), "Roya Meherremova", false },
                    { 2, "Xetai", 28, new DateTime(2023, 5, 18, 2, 17, 5, 763, DateTimeKind.Local).AddTicks(3135), "Anar Aliyev", false },
                    { 3, "Nesimi", 18, new DateTime(2023, 5, 18, 2, 17, 5, 763, DateTimeKind.Local).AddTicks(3136), "Mubariz Agayev", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
