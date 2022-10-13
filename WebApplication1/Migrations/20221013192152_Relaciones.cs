using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerVehiculos.Migrations
{
    public partial class Relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaVehiculoId",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoVehiculoId",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "ImagenVehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Historiales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistorialId",
                table: "Detalles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcedimientoId",
                table: "Detalles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MarcaVehiculoId",
                table: "Vehiculos",
                column: "MarcaVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoVehiculoId",
                table: "Vehiculos",
                column: "TipoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenVehiculos_VehiculoId",
                table: "ImagenVehiculos",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_VehiculoId",
                table: "Historiales",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_HistorialId",
                table: "Detalles",
                column: "HistorialId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_ProcedimientoId",
                table: "Detalles",
                column: "ProcedimientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Historiales_HistorialId",
                table: "Detalles",
                column: "HistorialId",
                principalTable: "Historiales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Procedimientos_ProcedimientoId",
                table: "Detalles",
                column: "ProcedimientoId",
                principalTable: "Procedimientos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId",
                table: "Historiales",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagenVehiculos_Vehiculos_VehiculoId",
                table: "ImagenVehiculos",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_MarcaVehiculos_MarcaVehiculoId",
                table: "Vehiculos",
                column: "MarcaVehiculoId",
                principalTable: "MarcaVehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TipoVehiculos_TipoVehiculoId",
                table: "Vehiculos",
                column: "TipoVehiculoId",
                principalTable: "TipoVehiculos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Historiales_HistorialId",
                table: "Detalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Procedimientos_ProcedimientoId",
                table: "Detalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Historiales_Vehiculos_VehiculoId",
                table: "Historiales");

            migrationBuilder.DropForeignKey(
                name: "FK_ImagenVehiculos_Vehiculos_VehiculoId",
                table: "ImagenVehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_MarcaVehiculos_MarcaVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TipoVehiculos_TipoVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_MarcaVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_TipoVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_ImagenVehiculos_VehiculoId",
                table: "ImagenVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Historiales_VehiculoId",
                table: "Historiales");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_HistorialId",
                table: "Detalles");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_ProcedimientoId",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "MarcaVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TipoVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "ImagenVehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Historiales");

            migrationBuilder.DropColumn(
                name: "HistorialId",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "ProcedimientoId",
                table: "Detalles");
        }
    }
}
