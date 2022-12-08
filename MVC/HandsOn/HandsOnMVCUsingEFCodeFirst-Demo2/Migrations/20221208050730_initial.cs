using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnMVCUsingEFCodeFirst_Demo2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectCode = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false),
                    ProjectName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectCode);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    ProjectCode = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Project_ProjectCode",
                        column: x => x.ProjectCode,
                        principalTable: "Project",
                        principalColumn: "ProjectCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ProjectCode",
                table: "Employee",
                column: "ProjectCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
