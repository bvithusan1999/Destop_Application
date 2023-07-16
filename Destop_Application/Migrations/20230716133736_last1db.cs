using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Destop_Application.Migrations
{
    /// <inheritdoc />
    public partial class last1db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GPA",
                table: "Students",
                newName: "Average");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Average",
                table: "Students",
                newName: "GPA");
        }
    }
}
