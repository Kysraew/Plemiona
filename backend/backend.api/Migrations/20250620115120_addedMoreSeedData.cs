using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.api.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingUpgrades",
                columns: new[] { "BuildingUpgradeId", "BuildingId", "DurationSeconds", "Gold", "GrainPerEmployee", "Iron", "PopulationNeeded", "Stone", "Wood", "level" },
                values: new object[] { 2L, 1L, 200L, 50, 4, 50, 70, 150, 160, 2 });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "Description", "Name" },
                values: new object[] { 2L, "Produce wood.", "Sawmill" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1L,
                column: "Grain",
                value: 1000);

            migrationBuilder.InsertData(
                table: "BuildingUpgrades",
                columns: new[] { "BuildingUpgradeId", "BuildingId", "DurationSeconds", "Gold", "GrainPerEmployee", "Iron", "PopulationNeeded", "Stone", "Wood", "level" },
                values: new object[,]
                {
                    { 3L, 2L, 30L, 5, 3, 5, 50, 10, 16, 1 },
                    { 4L, 2L, 50L, 10, 4, 15, 70, 10, 10, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingUpgrades",
                keyColumn: "BuildingUpgradeId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "BuildingUpgrades",
                keyColumn: "BuildingUpgradeId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "BuildingUpgrades",
                keyColumn: "BuildingUpgradeId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1L,
                column: "Grain",
                value: 100);
        }
    }
}
