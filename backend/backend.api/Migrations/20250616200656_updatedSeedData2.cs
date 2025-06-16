using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.api.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "Description", "Name" },
                values: new object[] { 1L, "Provied defence against enemies.", "Wall" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Gold", "Iron", "Name", "Stone", "Wood" },
                values: new object[,]
                {
                    { 1L, 100, 300, "Henry", 200, 400 },
                    { 2L, 100, 250, "John", 200, 400 }
                });

            migrationBuilder.InsertData(
                table: "BuildingUpgrades",
                columns: new[] { "BuildingUpgradeId", "BuildingId", "DurationSeconds", "Gold", "Iron", "PopulationNeeded", "Stone", "Wood", "level" },
                values: new object[] { 1L, 1L, 100L, 50, 50, 50, 100, 160, 1 });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "TownId", "Name", "PlayerId", "Population", "X_coordinate", "Y_coordinate" },
                values: new object[] { 1L, "Alexandia", 1L, 500, 10, 25 });

            migrationBuilder.InsertData(
                table: "BuildingInstances",
                columns: new[] { "BuildingInstanceId", "BuildingId", "Level", "TownId" },
                values: new object[] { 1L, 1L, 1, 1L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingInstances",
                keyColumn: "BuildingInstanceId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "BuildingUpgrades",
                keyColumn: "BuildingUpgradeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1L);
        }
    }
}
