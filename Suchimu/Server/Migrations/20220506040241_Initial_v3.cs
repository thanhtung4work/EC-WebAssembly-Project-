using Microsoft.EntityFrameworkCore.Migrations;

namespace Suchimu.Server.Migrations
{
    public partial class Initial_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Studio_StudioId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studio",
                table: "Studio");

            migrationBuilder.RenameTable(
                name: "Studio",
                newName: "Studios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studios",
                table: "Studios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Studios_StudioId",
                table: "Games",
                column: "StudioId",
                principalTable: "Studios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Studios_StudioId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studios",
                table: "Studios");

            migrationBuilder.RenameTable(
                name: "Studios",
                newName: "Studio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studio",
                table: "Studio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Studio_StudioId",
                table: "Games",
                column: "StudioId",
                principalTable: "Studio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
