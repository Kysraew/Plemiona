using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.api.Migrations
{
    /// <inheritdoc />
    public partial class AddedTownModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Gold = table.Column<int>(type: "integer", nullable: false),
                    Stone = table.Column<int>(type: "integer", nullable: false),
                    Wood = table.Column<int>(type: "integer", nullable: false),
                    Iron = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    TownId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Population = table.Column<int>(type: "integer", nullable: false),
                    X_coordinate = table.Column<int>(type: "integer", nullable: false),
                    Y_coordinate = table.Column<int>(type: "integer", nullable: false),
                    PlayerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.TownId);
                    table.ForeignKey(
                        name: "FK_Towns_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildingInstance",
                columns: table => new
                {
                    BuildingInstanceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    BuildingId = table.Column<long>(type: "bigint", nullable: false),
                    TownId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingInstance", x => x.BuildingInstanceId);
                    table.ForeignKey(
                        name: "FK_BuildingInstance_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingInstance_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "TownId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingInstance_BuildingId",
                table: "BuildingInstance",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingInstance_TownId",
                table: "BuildingInstance",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_PlayerId",
                table: "Towns",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingInstance");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
