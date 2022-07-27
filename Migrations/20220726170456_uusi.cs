using Microsoft.EntityFrameworkCore.Migrations;

namespace Oppimispäiväkirja_versio1.Migrations
{
    public partial class uusi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "InProgress",
                table: "Topic",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicId = table.Column<int>(nullable: false),
                    NoteText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.AlterColumn<bool>(
                name: "InProgress",
                table: "Topic",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
