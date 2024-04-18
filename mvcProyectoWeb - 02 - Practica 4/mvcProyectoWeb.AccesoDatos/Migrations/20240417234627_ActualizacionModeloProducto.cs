using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvcProyectoWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionModeloProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrecioVenta",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioVenta",
                table: "Producto");
        }
    }
}
