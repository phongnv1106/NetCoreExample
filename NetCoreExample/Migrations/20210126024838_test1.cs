using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreExample.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_company",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_employeeCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_company",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "_employeeCode",
                table: "Products");
        }
    }
}
