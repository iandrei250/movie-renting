using Microsoft.EntityFrameworkCore.Migrations;

namespace Renter.Migrations
{
    public partial class UpdateAllMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Quarterly' WHERE Id = 3");
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Yearly' WHERE Id = 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
