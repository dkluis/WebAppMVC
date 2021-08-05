using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    showid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    showname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    appstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    releasedate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.showid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Show");
        }
    }
}
