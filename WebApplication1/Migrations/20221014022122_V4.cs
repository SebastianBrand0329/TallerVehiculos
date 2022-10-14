using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerVehiculos.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityModelsId",
                table: "Vehiculos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdentityModelsId",
                table: "Vehiculos",
                column: "IdentityModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_AspNetUsers_IdentityModelsId",
                table: "Vehiculos",
                column: "IdentityModelsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_AspNetUsers_IdentityModelsId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_IdentityModelsId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdentityModelsId",
                table: "Vehiculos");
        }
    }
}
