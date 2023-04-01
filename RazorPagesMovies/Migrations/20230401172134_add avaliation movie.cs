using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesMovies.Migrations
{
    public partial class addavaliationmovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Avaliation",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaliation",
                table: "Movie");
        }
    }
}
