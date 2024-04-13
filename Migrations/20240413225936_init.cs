using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSR_KAZAR_N1.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    datumIzdaje = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cenaSkupaj = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uporabnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    surname = table.Column<string>(type: "TEXT", nullable: false),
                    birthdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    birthplace = table.Column<string>(type: "TEXT", nullable: false),
                    emso = table.Column<string>(type: "TEXT", nullable: false),
                    address = table.Column<string>(type: "TEXT", nullable: false),
                    post = table.Column<string>(type: "TEXT", nullable: false),
                    postnum = table.Column<int>(type: "INTEGER", nullable: false),
                    country = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: true),
                    password2 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uporabnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slika",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ime = table.Column<string>(type: "TEXT", nullable: false),
                    cena = table.Column<double>(type: "REAL", nullable: false),
                    letoIzdaje = table.Column<int>(type: "INTEGER", nullable: false),
                    jeUnikat = table.Column<bool>(type: "INTEGER", nullable: false),
                    racunId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slika", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slika_Racun_racunId",
                        column: x => x.racunId,
                        principalTable: "Racun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slika_racunId",
                table: "Slika",
                column: "racunId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slika");

            migrationBuilder.DropTable(
                name: "Uporabnik");

            migrationBuilder.DropTable(
                name: "Racun");
        }
    }
}
