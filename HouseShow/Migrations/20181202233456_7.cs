using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseShow.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShowID",
                table: "Artists",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artists_ShowID",
                table: "Artists",
                column: "ShowID");

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Shows_ShowID",
                table: "Artists",
                column: "ShowID",
                principalTable: "Shows",
                principalColumn: "ShowID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Shows_ShowID",
                table: "Artists");

            migrationBuilder.DropIndex(
                name: "IX_Artists_ShowID",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "ShowID",
                table: "Artists");
        }
    }
}
