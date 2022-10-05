using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTea.DAL.Migrations
{
    public partial class Anwar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "associatedProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_associatedProviders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociatedProviderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facilities_associatedProviders_AssociatedProviderId",
                        column: x => x.AssociatedProviderId,
                        principalTable: "associatedProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    facilityId = table.Column<int>(type: "int", nullable: true),
                    Dname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociatedProviderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_associatedProviders_AssociatedProviderId",
                        column: x => x.AssociatedProviderId,
                        principalTable: "associatedProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Facilities_facilityId",
                        column: x => x.facilityId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctorId = table.Column<int>(type: "int", nullable: true),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociatedProviderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_locations_associatedProviders_AssociatedProviderId",
                        column: x => x.AssociatedProviderId,
                        principalTable: "associatedProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_locations_Doctors_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AssociatedProviderId",
                table: "Doctors",
                column: "AssociatedProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_facilityId",
                table: "Doctors",
                column: "facilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_AssociatedProviderId",
                table: "Facilities",
                column: "AssociatedProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_locations_AssociatedProviderId",
                table: "locations",
                column: "AssociatedProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_locations_doctorId",
                table: "locations",
                column: "doctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "associatedProviders");
        }
    }
}
