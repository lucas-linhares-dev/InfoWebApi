using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoFinal07do07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "pag_dtalteracao",
                table: "FormasPag",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "pag_dtcadastro",
                table: "FormasPag",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "pag_usu_alteracao",
                table: "FormasPag",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pag_usu_cadastro",
                table: "FormasPag",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pag_dtalteracao",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "pag_dtcadastro",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "pag_usu_alteracao",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "pag_usu_cadastro",
                table: "FormasPag");
        }
    }
}
