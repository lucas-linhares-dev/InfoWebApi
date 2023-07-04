using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class atualizandoformaspag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_formaspag",
                table: "formaspag");

            migrationBuilder.RenameTable(
                name: "formaspag",
                newName: "FormaPag");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "FormaPag",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "FormaPag",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "FormaPag",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "FormaPag",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormaPag",
                table: "FormaPag",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormaPag",
                table: "FormaPag");

            migrationBuilder.RenameTable(
                name: "FormaPag",
                newName: "formaspag");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "formaspag",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "formaspag",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "formaspag",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "formaspag",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_formaspag",
                table: "formaspag",
                column: "id");
        }
    }
}
