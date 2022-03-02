using Microsoft.EntityFrameworkCore.Migrations;

namespace Renter.Migrations
{
    public partial class IdentityInsertOffOnCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT dbo.Customers OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
