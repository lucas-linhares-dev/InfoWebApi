using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class atualizando5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormaPag",
                table: "FormaPag");

            migrationBuilder.DropColumn(
                name: "proptest",
                table: "FormaPag");

            migrationBuilder.RenameTable(
                name: "FormaPag",
                newName: "FormasPag");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormasPag",
                table: "FormasPag",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormasPag",
                table: "FormasPag");

            migrationBuilder.RenameTable(
                name: "FormasPag",
                newName: "FormaPag");

            migrationBuilder.AddColumn<int>(
                name: "proptest",
                table: "FormaPag",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormaPag",
                table: "FormaPag",
                column: "Id");
        }
    }
}
