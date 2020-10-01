using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationsApp2.Migrations
{
    public partial class _2ndmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Users_UserID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Rooms",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_UserID",
                table: "Rooms",
                newName: "IX_Rooms_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Users_UserId",
                table: "Rooms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Users_UserId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Rooms",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_UserId",
                table: "Rooms",
                newName: "IX_Rooms_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Users_UserID",
                table: "Rooms",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
