using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_EmailVerifications_vID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_vID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "vID",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "vID",
                table: "Users",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Users_vID",
                table: "Users",
                column: "vID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_EmailVerifications_vID",
                table: "Users",
                column: "vID",
                principalTable: "EmailVerifications",
                principalColumn: "vID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
