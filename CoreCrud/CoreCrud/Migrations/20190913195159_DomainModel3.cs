using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCrud.Migrations
{
    public partial class DomainModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Destination",
                newName: "TripName");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Destination",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Country",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destination_LocationID",
                table: "Destination",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CountryID",
                table: "Country",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Country_CountryID",
                table: "Country",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Country_LocationID",
                table: "Destination",
                column: "LocationID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_Country_CountryID",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Country_LocationID",
                table: "Destination");

            migrationBuilder.DropIndex(
                name: "IX_Destination_LocationID",
                table: "Destination");

            migrationBuilder.DropIndex(
                name: "IX_Country_CountryID",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Country");

            migrationBuilder.RenameColumn(
                name: "TripName",
                table: "Destination",
                newName: "Location");

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
    }
}
