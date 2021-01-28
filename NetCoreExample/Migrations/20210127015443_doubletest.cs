using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreExample.Migrations
{
    public partial class doubletest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "doubleTest",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "doubleTest",
                table: "Products");
        }
    }
}
