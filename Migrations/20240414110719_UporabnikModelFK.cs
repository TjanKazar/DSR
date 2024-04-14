using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSR_KAZAR_N1.Migrations
{
    /// <inheritdoc />
    public partial class UporabnikModelFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UporabnikZGesli_UporabnikModel_Id",
                table: "UporabnikZGesli");

            migrationBuilder.AddColumn<int>(
                name: "UporabnikModelId",
                table: "UporabnikZGesli",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UporabnikZGesli_UporabnikModelId",
                table: "UporabnikZGesli",
                column: "UporabnikModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_UporabnikZGesli_UporabnikModel_UporabnikModelId",
                table: "UporabnikZGesli",
                column: "UporabnikModelId",
                principalTable: "UporabnikModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UporabnikZGesli_UporabnikModel_UporabnikModelId",
                table: "UporabnikZGesli");

            migrationBuilder.DropIndex(
                name: "IX_UporabnikZGesli_UporabnikModelId",
                table: "UporabnikZGesli");

            migrationBuilder.DropColumn(
                name: "UporabnikModelId",
                table: "UporabnikZGesli");

            migrationBuilder.AddForeignKey(
                name: "FK_UporabnikZGesli_UporabnikModel_Id",
                table: "UporabnikZGesli",
                column: "Id",
                principalTable: "UporabnikModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
