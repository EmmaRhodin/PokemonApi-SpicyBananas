using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonApi_SpicyBananas.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonModels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    height = table.Column<float>(type: "real", nullable: true),
                    weight = table.Column<float>(type: "real", nullable: true),
                    spriteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spriteImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonModels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AbilityModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbilityModels_PokemonModels_PokemonModelId",
                        column: x => x.PokemonModelId,
                        principalTable: "PokemonModels",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TypeModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeModels_PokemonModels_PokemonModelId",
                        column: x => x.PokemonModelId,
                        principalTable: "PokemonModels",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityModels_PokemonModelId",
                table: "AbilityModels",
                column: "PokemonModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeModels_PokemonModelId",
                table: "TypeModels",
                column: "PokemonModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityModels");

            migrationBuilder.DropTable(
                name: "TypeModels");

            migrationBuilder.DropTable(
                name: "PokemonModels");
        }
    }
}
