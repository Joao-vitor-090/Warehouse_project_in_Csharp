using Microsoft.EntityFrameworkCore.Migrations;

namespace Armazen.Migrations
{
    public partial class DepartmentForeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Deposito_DepositoId",
                table: "Vendedor");

            migrationBuilder.AlterColumn<int>(
                name: "DepositoId",
                table: "Vendedor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Deposito_DepositoId",
                table: "Vendedor",
                column: "DepositoId",
                principalTable: "Deposito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Deposito_DepositoId",
                table: "Vendedor");

            migrationBuilder.AlterColumn<int>(
                name: "DepositoId",
                table: "Vendedor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Deposito_DepositoId",
                table: "Vendedor",
                column: "DepositoId",
                principalTable: "Deposito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
