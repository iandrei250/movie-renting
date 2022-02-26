﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Renter.Migrations
{
    public partial class PopulateGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre(Id,Name) VALUES(1,'Action')");
            migrationBuilder.Sql("INSERT INTO Genre(Id,Name) VALUES(2,'Thriller')");
            migrationBuilder.Sql("INSERT INTO Genre(Id,Name) VALUES(3,'Family')");
            migrationBuilder.Sql("INSERT INTO Genre(Id,Name) VALUES(4,'Romance')");
            migrationBuilder.Sql("INSERT INTO Genre(Id,Name) VALUES(5,'Comedy')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
