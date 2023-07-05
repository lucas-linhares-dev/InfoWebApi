using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class avancando6atualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GruposPro",
                columns: table => new
                {
                    gru_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gru_descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    gru_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    gru_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    gru_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    gru_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposPro", x => x.gru_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    mar_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mar_descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    mar_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    mar_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    mar_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    mar_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.mar_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    pro_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gru_codigo = table.Column<int>(type: "int", nullable: false),
                    mar_codigo = table.Column<int>(type: "int", nullable: false),
                    pes_codigo = table.Column<int>(type: "int", nullable: false),
                    ica_codigo = table.Column<int>(type: "int", nullable: true),
                    pro_descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    pro_descfiscal = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    pro_referencia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    pro_ncm = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    pro_genero = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    pro_observacao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    pro_codigoean = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    pro_situacao = table.Column<bool>(type: "bit", nullable: false),
                    pro_prccompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pro_prccusto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pro_prctransf = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pro_prccomprant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pro_img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unidade = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    cen_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    cen_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    cen_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    cen_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.pro_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Tesourarias",
                columns: table => new
                {
                    tes_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tes_documento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    tes_doctitulo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    tes_tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    tes_valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tes_historico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    tes_datavenc = table.Column<DateTime>(type: "date", nullable: false),
                    tes_data = table.Column<DateTime>(type: "date", nullable: false),
                    tes_hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    loj_codigo = table.Column<int>(type: "int", nullable: true),
                    fpg_codigo = table.Column<int>(type: "int", nullable: false),
                    cen_codigo = table.Column<int>(type: "int", nullable: true),
                    pag_codigo = table.Column<int>(type: "int", nullable: false),
                    tes_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    tes_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    tes_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    tes_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tesourarias", x => x.tes_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    usu_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usu_email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    usu_apelido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    usu_cargo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    usu_cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    loj_codigo = table.Column<int>(type: "int", nullable: false),
                    usu_situacao = table.Column<bool>(type: "bit", nullable: false),
                    usu_is_staff = table.Column<bool>(type: "bit", nullable: false),
                    usu_img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usu_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    usu_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    usu_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    usu_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.usu_codigo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GruposPro");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Tesourarias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
