using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Migrations
{
    public partial class AddJournalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Journal",
                columns: table => new
                {
                    JournalNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateWritten = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal", x => x.JournalNumber);
                    table.ForeignKey(
                        name: "FK_Journal_User_UserNumber",
                        column: x => x.UserNumber,
                        principalTable: "User",
                        principalColumn: "UserNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Journal_UserNumber",
                table: "Journal",
                column: "UserNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Journal");
        }
    }
}
