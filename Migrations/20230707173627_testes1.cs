using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class testes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fpg_usu_alteracao",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "fpg_usu_cadastro",
                table: "FormasPag");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fpg_usu_alteracao",
                table: "FormasPag",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fpg_usu_cadastro",
                table: "FormasPag",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
