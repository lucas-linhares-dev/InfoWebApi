using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class ajeitandonomescolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "FormasPag",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FormasPag",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuCadastro",
                table: "FormasPag",
                newName: "usu_cadastro");

            migrationBuilder.RenameColumn(
                name: "UsuAlteracao",
                table: "FormasPag",
                newName: "usu_alteracao");

            migrationBuilder.RenameColumn(
                name: "DtCadastro",
                table: "FormasPag",
                newName: "dt_cadastro");

            migrationBuilder.RenameColumn(
                name: "DtAlteracao",
                table: "FormasPag",
                newName: "dt_alteracao");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "CentrosCusto",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CentrosCusto",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuCadastro",
                table: "CentrosCusto",
                newName: "usu_cadastro");

            migrationBuilder.RenameColumn(
                name: "UsuAlteracao",
                table: "CentrosCusto",
                newName: "usu_alteracao");

            migrationBuilder.RenameColumn(
                name: "DtCadastro",
                table: "CentrosCusto",
                newName: "dt_cadastro");

            migrationBuilder.RenameColumn(
                name: "DtAlteracao",
                table: "CentrosCusto",
                newName: "dt_alteracao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "FormasPag",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "FormasPag",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usu_cadastro",
                table: "FormasPag",
                newName: "UsuCadastro");

            migrationBuilder.RenameColumn(
                name: "usu_alteracao",
                table: "FormasPag",
                newName: "UsuAlteracao");

            migrationBuilder.RenameColumn(
                name: "dt_cadastro",
                table: "FormasPag",
                newName: "DtCadastro");

            migrationBuilder.RenameColumn(
                name: "dt_alteracao",
                table: "FormasPag",
                newName: "DtAlteracao");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "CentrosCusto",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CentrosCusto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usu_cadastro",
                table: "CentrosCusto",
                newName: "UsuCadastro");

            migrationBuilder.RenameColumn(
                name: "usu_alteracao",
                table: "CentrosCusto",
                newName: "UsuAlteracao");

            migrationBuilder.RenameColumn(
                name: "dt_cadastro",
                table: "CentrosCusto",
                newName: "DtCadastro");

            migrationBuilder.RenameColumn(
                name: "dt_alteracao",
                table: "CentrosCusto",
                newName: "DtAlteracao");
        }
    }
}
