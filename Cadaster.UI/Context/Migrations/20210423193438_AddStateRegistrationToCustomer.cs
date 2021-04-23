using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadaster.UI.Context.Migrations
{
    public partial class AddStateRegistrationToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StateRegistration",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateRegistration",
                table: "Customers");
        }
    }
}
