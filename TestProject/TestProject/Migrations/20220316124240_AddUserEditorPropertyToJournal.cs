using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProject.Migrations
{
    public partial class AddUserEditorPropertyToJournal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_UserNumber",
                table: "Journal");

            migrationBuilder.RenameColumn(
                name: "UserNumber",
                table: "Journal",
                newName: "OwnerUserNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Journal_UserNumber",
                table: "Journal",
                newName: "IX_Journal_OwnerUserNumber");

            migrationBuilder.AddColumn<int>(
                name: "EditorUserNumber",
                table: "Journal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journal_EditorUserNumber",
                table: "Journal",
                column: "EditorUserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_EditorUserNumber",
                table: "Journal",
                column: "EditorUserNumber",
                principalTable: "User",
                principalColumn: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_OwnerUserNumber",
                table: "Journal",
                column: "OwnerUserNumber",
                principalTable: "User",
                principalColumn: "UserNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_EditorUserNumber",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_OwnerUserNumber",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_EditorUserNumber",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "EditorUserNumber",
                table: "Journal");

            migrationBuilder.RenameColumn(
                name: "OwnerUserNumber",
                table: "Journal",
                newName: "UserNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Journal_OwnerUserNumber",
                table: "Journal",
                newName: "IX_Journal_UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_UserNumber",
                table: "Journal",
                column: "UserNumber",
                principalTable: "User",
                principalColumn: "UserNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
