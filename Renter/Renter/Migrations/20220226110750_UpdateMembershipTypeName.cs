using Microsoft.EntityFrameworkCore.Migrations;

namespace Renter.Migrations
{
    public partial class UpdateMembershipTypeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Pay as You Go' WHERE Id = 1");
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Monthly' WHERE Id = 2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
