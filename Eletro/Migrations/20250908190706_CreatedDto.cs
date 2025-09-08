using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eletro.Migrations
{
    /// <inheritdoc />
    public partial class CreatedDto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eletrodomesticos_Clientes_ClienteId",
                table: "Eletrodomesticos");

            migrationBuilder.DropIndex(
                name: "IX_Eletrodomesticos_ClienteId",
                table: "Eletrodomesticos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Eletrodomesticos_ClienteId",
                table: "Eletrodomesticos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eletrodomesticos_Clientes_ClienteId",
                table: "Eletrodomesticos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
