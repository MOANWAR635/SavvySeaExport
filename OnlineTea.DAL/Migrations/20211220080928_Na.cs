using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTea.DAL.Migrations
{
    public partial class Na : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_associatedProviders_AssociatedProviderId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_associatedProviders_AssociatedProviderId",
                table: "Facilities");

            migrationBuilder.DropForeignKey(
                name: "FK_locations_associatedProviders_AssociatedProviderId",
                table: "locations");

            migrationBuilder.DropIndex(
                name: "IX_locations_AssociatedProviderId",
                table: "locations");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_AssociatedProviderId",
                table: "Facilities");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AssociatedProviderId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AssociatedProviderId",
                table: "locations");

            migrationBuilder.DropColumn(
                name: "AssociatedProviderId",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "AssociatedProviderId",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "doctorsId",
                table: "associatedProviders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "facilitiesId",
                table: "associatedProviders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "locationsId",
                table: "associatedProviders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_associatedProviders_doctorsId",
                table: "associatedProviders",
                column: "doctorsId");

            migrationBuilder.CreateIndex(
                name: "IX_associatedProviders_facilitiesId",
                table: "associatedProviders",
                column: "facilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_associatedProviders_locationsId",
                table: "associatedProviders",
                column: "locationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_associatedProviders_Doctors_doctorsId",
                table: "associatedProviders",
                column: "doctorsId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_associatedProviders_Facilities_facilitiesId",
                table: "associatedProviders",
                column: "facilitiesId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_associatedProviders_locations_locationsId",
                table: "associatedProviders",
                column: "locationsId",
                principalTable: "locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_associatedProviders_Doctors_doctorsId",
                table: "associatedProviders");

            migrationBuilder.DropForeignKey(
                name: "FK_associatedProviders_Facilities_facilitiesId",
                table: "associatedProviders");

            migrationBuilder.DropForeignKey(
                name: "FK_associatedProviders_locations_locationsId",
                table: "associatedProviders");

            migrationBuilder.DropIndex(
                name: "IX_associatedProviders_doctorsId",
                table: "associatedProviders");

            migrationBuilder.DropIndex(
                name: "IX_associatedProviders_facilitiesId",
                table: "associatedProviders");

            migrationBuilder.DropIndex(
                name: "IX_associatedProviders_locationsId",
                table: "associatedProviders");

            migrationBuilder.DropColumn(
                name: "doctorsId",
                table: "associatedProviders");

            migrationBuilder.DropColumn(
                name: "facilitiesId",
                table: "associatedProviders");

            migrationBuilder.DropColumn(
                name: "locationsId",
                table: "associatedProviders");

            migrationBuilder.AddColumn<int>(
                name: "AssociatedProviderId",
                table: "locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssociatedProviderId",
                table: "Facilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssociatedProviderId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_locations_AssociatedProviderId",
                table: "locations",
                column: "AssociatedProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_AssociatedProviderId",
                table: "Facilities",
                column: "AssociatedProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AssociatedProviderId",
                table: "Doctors",
                column: "AssociatedProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_associatedProviders_AssociatedProviderId",
                table: "Doctors",
                column: "AssociatedProviderId",
                principalTable: "associatedProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_associatedProviders_AssociatedProviderId",
                table: "Facilities",
                column: "AssociatedProviderId",
                principalTable: "associatedProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_locations_associatedProviders_AssociatedProviderId",
                table: "locations",
                column: "AssociatedProviderId",
                principalTable: "associatedProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
