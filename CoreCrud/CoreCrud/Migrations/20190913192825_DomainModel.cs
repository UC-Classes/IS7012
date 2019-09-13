using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCrud.Migrations
{
    public partial class DomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_Destination_DestinationID",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_DestinationID",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Country");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Country",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Country_LocationID",
                table: "Country",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Destination_LocationID",
                table: "Country",
                column: "LocationID",
                principalTable: "Destination",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_Destination_LocationID",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_LocationID",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Country");

            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Country",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_DestinationID",
                table: "Country",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Destination_DestinationID",
                table: "Country",
                column: "DestinationID",
                principalTable: "Destination",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
