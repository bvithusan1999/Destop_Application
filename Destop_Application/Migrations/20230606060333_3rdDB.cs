using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Destop_Application.Migrations
{
    /// <inheritdoc />
    public partial class _3rdDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    NicNo = table.Column<string>(type: "TEXT", nullable: false),
                    Science = table.Column<string>(type: "TEXT", nullable: false),
                    History = table.Column<string>(type: "TEXT", nullable: false),
                    Maths = table.Column<string>(type: "TEXT", nullable: false),
                    English = table.Column<string>(type: "TEXT", nullable: false),
                    Tamil = table.Column<string>(type: "TEXT", nullable: false),
                    GPA = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
