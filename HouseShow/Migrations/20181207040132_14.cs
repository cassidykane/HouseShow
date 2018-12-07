using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseShow.Migrations
{
    public partial class _14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistNames",
                table: "Shows",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistNames",
                table: "Shows");
        }
    }
}
