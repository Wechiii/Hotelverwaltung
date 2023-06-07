using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Guests_GuestId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_GuestId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Addresses");

            migrationBuilder.CreateTable(
                name: "AddressGuest",
                columns: table => new
                {
                    AddressesAddressId = table.Column<int>(type: "int", nullable: false),
                    GuestsGuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressGuest", x => new { x.AddressesAddressId, x.GuestsGuestId });
                    table.ForeignKey(
                        name: "FK_AddressGuest_Addresses_AddressesAddressId",
                        column: x => x.AddressesAddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressGuest_Guests_GuestsGuestId",
                        column: x => x.GuestsGuestId,
                        principalTable: "Guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AddressGuest_GuestsGuestId",
                table: "AddressGuest",
                column: "GuestsGuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressGuest");

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_GuestId",
                table: "Addresses",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Guests_GuestId",
                table: "Addresses",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "GuestId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
