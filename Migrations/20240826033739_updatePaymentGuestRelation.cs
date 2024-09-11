using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManager.Migrations
{
    /// <inheritdoc />
    public partial class updatePaymentGuestRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GuestId",
                table: "Payments",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Guests_GuestId",
                table: "Payments",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Guests_GuestId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_GuestId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Payments");
        }
    }
}
