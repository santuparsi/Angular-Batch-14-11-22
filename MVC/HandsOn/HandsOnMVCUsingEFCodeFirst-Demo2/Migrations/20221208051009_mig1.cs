using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnMVCUsingEFCodeFirst_Demo2.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Project_ProjectCode",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectCode",
                table: "Employee",
                type: "char(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldMaxLength: 5);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Project_ProjectCode",
                table: "Employee",
                column: "ProjectCode",
                principalTable: "Project",
                principalColumn: "ProjectCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Project_ProjectCode",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectCode",
                table: "Employee",
                type: "char(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Project_ProjectCode",
                table: "Employee",
                column: "ProjectCode",
                principalTable: "Project",
                principalColumn: "ProjectCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
