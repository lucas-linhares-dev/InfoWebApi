using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class formaspagcentrocusto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "FormasPag");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FormasPag",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtAlteracao",
                table: "FormasPag",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtCadastro",
                table: "FormasPag",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsuAlteracao",
                table: "FormasPag",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuCadastro",
                table: "FormasPag",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtAlteracao",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "DtCadastro",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "UsuAlteracao",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "UsuCadastro",
                table: "FormasPag");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FormasPag",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "FormasPag",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
