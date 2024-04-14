using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSR_KAZAR_N1.Migrations
{
    /// <inheritdoc />
    public partial class UporabnikZGesli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Uporabnik",
                table: "Uporabnik");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Uporabnik");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Uporabnik");

            migrationBuilder.DropColumn(
                name: "password2",
                table: "Uporabnik");

            migrationBuilder.RenameTable(
                name: "Uporabnik",
                newName: "UporabnikModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UporabnikModel",
                table: "UporabnikModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UporabnikZGesli",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    password = table.Column<string>(type: "TEXT", nullable: false),
                    password2 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UporabnikZGesli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UporabnikZGesli_UporabnikModel_Id",
                        column: x => x.Id,
                        principalTable: "UporabnikModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UporabnikZGesli");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UporabnikModel",
                table: "UporabnikModel");

            migrationBuilder.RenameTable(
                name: "UporabnikModel",
                newName: "Uporabnik");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Uporabnik",
                type: "TEXT",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Uporabnik",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password2",
                table: "Uporabnik",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uporabnik",
                table: "Uporabnik",
                column: "Id");
        }
    }
}
