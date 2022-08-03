using Microsoft.EntityFrameworkCore.Migrations;

namespace Oppimispäiväkirja_versio1.Migrations
{
    public partial class uusiluokka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "Topic",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Topic",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topic_NoteId",
                table: "Topic",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_TopicId",
                table: "Topic",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Note_NoteId",
                table: "Topic",
                column: "NoteId",
                principalTable: "Note",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Topic_TopicId",
                table: "Topic",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Note_NoteId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Topic_TopicId",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_NoteId",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_TopicId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Topic");
        }
    }
}
