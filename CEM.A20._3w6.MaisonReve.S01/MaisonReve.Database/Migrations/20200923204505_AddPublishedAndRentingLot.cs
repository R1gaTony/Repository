using Microsoft.EntityFrameworkCore.Migrations;

namespace MaisonReve.Database.Migrations
{
    public partial class AddPublishedAndRentingLot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Buildings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "RentingLots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotNumber = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Terms = table.Column<int>(nullable: false),
                    LeaseLength = table.Column<int>(nullable: false),
                    NumberOfRooms = table.Column<int>(nullable: false),
                    RentingLotType = table.Column<int>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentingLots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentingLots_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentingLots_BuildingId",
                table: "RentingLots",
                column: "BuildingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentingLots");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Buildings");
        }
    }
}
