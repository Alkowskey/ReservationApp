using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationsApp2.Migrations
{
    public partial class migrationthatchangesprimarykeytoautoincrement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "Rooms",
                newName: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "RoomID");
        }
    }
}
