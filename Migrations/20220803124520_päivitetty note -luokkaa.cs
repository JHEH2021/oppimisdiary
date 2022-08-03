using Microsoft.EntityFrameworkCore.Migrations;

namespace Oppimispäiväkirja_versio1.Migrations
{
    public partial class päivitettynoteluokkaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Note",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Note_TopicId",
                table: "Note",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Topic_TopicId",
                table: "Note",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Topic_TopicId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_TopicId",
                table: "Note");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Note",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
