using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Destop_Application.Migrations
{
    /// <inheritdoc />
    public partial class _4thDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "English",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Tamil",
                table: "Students",
                newName: "Physics");

            migrationBuilder.RenameColumn(
                name: "Science",
                table: "Students",
                newName: "Chemistry");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Physics",
                table: "Students",
                newName: "Tamil");

            migrationBuilder.RenameColumn(
                name: "Chemistry",
                table: "Students",
                newName: "Science");

            migrationBuilder.AddColumn<string>(
                name: "English",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
