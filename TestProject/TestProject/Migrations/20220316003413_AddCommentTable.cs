using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Migrations
{
    public partial class AddCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JournalNumber = table.Column<int>(type: "int", nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentNumber);
                    table.ForeignKey(
                        name: "FK_Comment_Journal_JournalNumber",
                        column: x => x.JournalNumber,
                        principalTable: "Journal",
                        principalColumn: "JournalNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserNumber",
                        column: x => x.UserNumber,
                        principalTable: "User",
                        principalColumn: "UserNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_JournalNumber",
                table: "Comment",
                column: "JournalNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserNumber",
                table: "Comment",
                column: "UserNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");
        }
    }
}
