using Microsoft.EntityFrameworkCore.Migrations;

namespace Renter.Migrations
{
    public partial class SetIdentityInsertOnCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT dbo.Customers ON");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
