using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ErpBackend.Migrations
{
    public partial class firstcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    HomeAddress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Town = table.Column<string>(nullable: false),
                    PostCode = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    NiNumber = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    DateofBirth = table.Column<DateTime>(nullable: false),
                    MaritalStatus = table.Column<string>(nullable: false),
                    DateofJoin = table.Column<DateTime>(nullable: false),
                    ModeofRecruitment = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Education = table.Column<string>(nullable: false),
                    Experience = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
