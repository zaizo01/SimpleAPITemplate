using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiPractices.Migrations
{
    public partial class Departaments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartamentManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityOfEmployees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departaments");
        }
    }
}
