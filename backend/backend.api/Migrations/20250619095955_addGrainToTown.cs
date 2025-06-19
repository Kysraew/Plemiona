using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.api.Migrations
{
    /// <inheritdoc />
    public partial class addGrainToTown : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grain",
                table: "Players",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GrainPerEmployee",
                table: "BuildingUpgrades",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BuildingUpgrades",
                keyColumn: "BuildingUpgradeId",
                keyValue: 1L,
                column: "GrainPerEmployee",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1L,
                column: "Grain",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2L,
                column: "Grain",
                value: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grain",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "GrainPerEmployee",
                table: "BuildingUpgrades");
        }
    }
}
