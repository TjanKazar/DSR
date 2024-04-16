using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSR_KAZAR_N1.Migrations
{
    /// <inheritdoc />
    public partial class SlikaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slika_Racun_racunId",
                table: "Slika");

            migrationBuilder.AlterColumn<int>(
                name: "racunId",
                table: "Slika",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Slika_Racun_racunId",
                table: "Slika",
                column: "racunId",
                principalTable: "Racun",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slika_Racun_racunId",
                table: "Slika");

            migrationBuilder.AlterColumn<int>(
                name: "racunId",
                table: "Slika",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Slika_Racun_racunId",
                table: "Slika",
                column: "racunId",
                principalTable: "Racun",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
