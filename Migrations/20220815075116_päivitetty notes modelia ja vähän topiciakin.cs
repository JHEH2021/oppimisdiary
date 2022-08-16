using Microsoft.EntityFrameworkCore.Migrations;

namespace Oppimispäiväkirja_versio1.Migrations
{
    public partial class päivitettynotesmodeliajavähäntopiciakin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Note",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Note");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Topic",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "NoteID",
                table: "Note",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Note",
                table: "Note",
                column: "NoteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Note",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "NoteID",
                table: "Note");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Topic",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Note",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Note",
                table: "Note",
                column: "Id");
        }
    }
}
