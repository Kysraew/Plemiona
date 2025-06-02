using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.api.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedTownModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingInstance_Building_BuildingId",
                table: "BuildingInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingInstance_Towns_TownId",
                table: "BuildingInstance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingInstance",
                table: "BuildingInstance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BuildingInstance");

            migrationBuilder.RenameTable(
                name: "BuildingInstance",
                newName: "BuildingInstances");

            migrationBuilder.RenameTable(
                name: "Building",
                newName: "Buildings");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingInstance_TownId",
                table: "BuildingInstances",
                newName: "IX_BuildingInstances_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingInstance_BuildingId",
                table: "BuildingInstances",
                newName: "IX_BuildingInstances_BuildingId");

            migrationBuilder.AlterColumn<long>(
                name: "TownId",
                table: "BuildingInstances",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingInstances",
                table: "BuildingInstances",
                column: "BuildingInstanceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings",
                column: "BuildingId");

            migrationBuilder.CreateTable(
                name: "BuildingUpgrades",
                columns: table => new
                {
                    BuildingUpgradeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BuildingId = table.Column<long>(type: "bigint", nullable: false),
                    DurationSeconds = table.Column<long>(type: "bigint", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    Gold = table.Column<int>(type: "integer", nullable: false),
                    Wood = table.Column<int>(type: "integer", nullable: false),
                    Stone = table.Column<int>(type: "integer", nullable: false),
                    Iron = table.Column<int>(type: "integer", nullable: false),
                    PopulationNeeded = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingUpgrades", x => x.BuildingUpgradeId);
                    table.ForeignKey(
                        name: "FK_BuildingUpgrades_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingUpgrades_BuildingId",
                table: "BuildingUpgrades",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingInstances_Buildings_BuildingId",
                table: "BuildingInstances",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingInstances_Towns_TownId",
                table: "BuildingInstances",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "TownId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingInstances_Buildings_BuildingId",
                table: "BuildingInstances");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingInstances_Towns_TownId",
                table: "BuildingInstances");

            migrationBuilder.DropTable(
                name: "BuildingUpgrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingInstances",
                table: "BuildingInstances");

            migrationBuilder.RenameTable(
                name: "Buildings",
                newName: "Building");

            migrationBuilder.RenameTable(
                name: "BuildingInstances",
                newName: "BuildingInstance");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingInstances_TownId",
                table: "BuildingInstance",
                newName: "IX_BuildingInstance_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_BuildingInstances_BuildingId",
                table: "BuildingInstance",
                newName: "IX_BuildingInstance_BuildingId");

            migrationBuilder.AlterColumn<long>(
                name: "TownId",
                table: "BuildingInstance",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BuildingInstance",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building",
                table: "Building",
                column: "BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingInstance",
                table: "BuildingInstance",
                column: "BuildingInstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingInstance_Building_BuildingId",
                table: "BuildingInstance",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingInstance_Towns_TownId",
                table: "BuildingInstance",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "TownId");
        }
    }
}
