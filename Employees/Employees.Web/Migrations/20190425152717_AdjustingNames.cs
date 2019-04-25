using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Web.Migrations
{
    public partial class AdjustingNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300);
        }
    }
}
