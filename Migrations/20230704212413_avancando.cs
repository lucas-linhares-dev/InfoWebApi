using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class avancando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descricao",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "descricao",
                table: "CentrosCusto");

            migrationBuilder.RenameColumn(
                name: "usu_cadastro",
                table: "FormasPag",
                newName: "fpg_usu_cadastro");

            migrationBuilder.RenameColumn(
                name: "usu_alteracao",
                table: "FormasPag",
                newName: "fpg_usu_alteracao");

            migrationBuilder.RenameColumn(
                name: "dt_cadastro",
                table: "FormasPag",
                newName: "fpg_dtcadastro");

            migrationBuilder.RenameColumn(
                name: "dt_alteracao",
                table: "FormasPag",
                newName: "fpg_dtalteracao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "FormasPag",
                newName: "fpg_codigo");

            migrationBuilder.RenameColumn(
                name: "usu_cadastro",
                table: "CentrosCusto",
                newName: "cen_usu_cadastro");

            migrationBuilder.RenameColumn(
                name: "usu_alteracao",
                table: "CentrosCusto",
                newName: "cen_usu_alteracao");

            migrationBuilder.RenameColumn(
                name: "dt_cadastro",
                table: "CentrosCusto",
                newName: "cen_dtcadastro");

            migrationBuilder.RenameColumn(
                name: "dt_alteracao",
                table: "CentrosCusto",
                newName: "cen_dtalteracao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CentrosCusto",
                newName: "cen_codigo");

            migrationBuilder.AddColumn<string>(
                name: "fpg_descricao",
                table: "FormasPag",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cen_descricao",
                table: "CentrosCusto",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ContasPagar",
                columns: table => new
                {
                    pag_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pag_id_refs = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pag_documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pag_vlrdoc = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    pag_vlrdesc = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    pag_vlracresc = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    pag_vlrmulta = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    pag_vlrpagar = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    pag_vlrpago = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    pag_historico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    pag_numNfe = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    pag_situacao = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    pag_dtvenc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pag_dtlanc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pag_dtpag = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pag_dtcomp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pag_hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    loj_codigo = table.Column<int>(type: "int", nullable: true),
                    fpg_codigo = table.Column<int>(type: "int", nullable: false),
                    pes_codigo = table.Column<int>(type: "int", nullable: true),
                    cen_codigo = table.Column<int>(type: "int", nullable: true),
                    debtesouraria = table.Column<bool>(type: "bit", nullable: false),
                    tes_codigo = table.Column<int>(type: "int", nullable: true),
                    pag_dtcadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pag_dtalteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pag_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    pag_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasPagar", x => x.pag_codigo);
                    table.ForeignKey(
                        name: "FK_ContasPagar_CentrosCusto_cen_codigo",
                        column: x => x.cen_codigo,
                        principalTable: "CentrosCusto",
                        principalColumn: "cen_codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContasPagar_FormasPag_fpg_codigo",
                        column: x => x.fpg_codigo,
                        principalTable: "FormasPag",
                        principalColumn: "fpg_codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasPagar_cen_codigo",
                table: "ContasPagar",
                column: "cen_codigo");

            migrationBuilder.CreateIndex(
                name: "IX_ContasPagar_fpg_codigo",
                table: "ContasPagar",
                column: "fpg_codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasPagar");

            migrationBuilder.DropColumn(
                name: "fpg_descricao",
                table: "FormasPag");

            migrationBuilder.DropColumn(
                name: "cen_descricao",
                table: "CentrosCusto");

            migrationBuilder.RenameColumn(
                name: "fpg_usu_cadastro",
                table: "FormasPag",
                newName: "usu_cadastro");

            migrationBuilder.RenameColumn(
                name: "fpg_usu_alteracao",
                table: "FormasPag",
                newName: "usu_alteracao");

            migrationBuilder.RenameColumn(
                name: "fpg_dtcadastro",
                table: "FormasPag",
                newName: "dt_cadastro");

            migrationBuilder.RenameColumn(
                name: "fpg_dtalteracao",
                table: "FormasPag",
                newName: "dt_alteracao");

            migrationBuilder.RenameColumn(
                name: "fpg_codigo",
                table: "FormasPag",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "cen_usu_cadastro",
                table: "CentrosCusto",
                newName: "usu_cadastro");

            migrationBuilder.RenameColumn(
                name: "cen_usu_alteracao",
                table: "CentrosCusto",
                newName: "usu_alteracao");

            migrationBuilder.RenameColumn(
                name: "cen_dtcadastro",
                table: "CentrosCusto",
                newName: "dt_cadastro");

            migrationBuilder.RenameColumn(
                name: "cen_dtalteracao",
                table: "CentrosCusto",
                newName: "dt_alteracao");

            migrationBuilder.RenameColumn(
                name: "cen_codigo",
                table: "CentrosCusto",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "FormasPag",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "CentrosCusto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
