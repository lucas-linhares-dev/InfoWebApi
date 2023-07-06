using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class avancandoModels01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigsPerfilLoja",
                columns: table => new
                {
                    cpl_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usu_codigo = table.Column<int>(type: "int", nullable: false),
                    pfl_codigo = table.Column<int>(type: "int", nullable: false),
                    cpl_valor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigsPerfilLoja", x => x.cpl_codigo);
                });

            migrationBuilder.CreateTable(
                name: "ConfigsPermissaoUsuario",
                columns: table => new
                {
                    cpu_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usu_codigo = table.Column<int>(type: "int", nullable: false),
                    pmu_codigo = table.Column<int>(type: "int", nullable: false),
                    cpu_valor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigsPermissaoUsuario", x => x.cpu_codigo);
                });

            migrationBuilder.CreateTable(
                name: "CstsCofins",
                columns: table => new
                {
                    cof_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cof_descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    cof_tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    cof_cst_inversa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CstsCofins", x => x.cof_codigo);
                });

            migrationBuilder.CreateTable(
                name: "CstsIcms",
                columns: table => new
                {
                    icm_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icm_descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CstsIcms", x => x.icm_codigo);
                });

            migrationBuilder.CreateTable(
                name: "CstsIpi",
                columns: table => new
                {
                    ipi_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ipi_descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ipi_tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ipi_cst_inversa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CstsIpi", x => x.ipi_codigo);
                });

            migrationBuilder.CreateTable(
                name: "CstsPis",
                columns: table => new
                {
                    pis_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pis_descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    pis_tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    pis_cst_inversa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CstsPis", x => x.pis_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    est_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pro_codigo = table.Column<int>(type: "int", nullable: false),
                    loj_codigo = table.Column<int>(type: "int", nullable: false),
                    est_estoque = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_estoque_usado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_estoque_avariado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_estoque_reservado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco6 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco7 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_preco8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido6 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido7 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precoliquido8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional6 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional7 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_precopromocional8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto6 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto7 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_vlrdesconto8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_imposto = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    est_pis_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_cof_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    est_ipi_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pis_ent_cod = table.Column<int>(type: "int", nullable: false),
                    pis_sai_cod = table.Column<int>(type: "int", nullable: false),
                    cof_ent_codigo = table.Column<int>(type: "int", nullable: false),
                    cof_sai_codigo = table.Column<int>(type: "int", nullable: false),
                    icms_codigo = table.Column<int>(type: "int", nullable: false),
                    ipi_ent_codigo = table.Column<int>(type: "int", nullable: false),
                    ipi_sai_codigo = table.Column<int>(type: "int", nullable: false),
                    cfop_ent_codigo = table.Column<int>(type: "int", nullable: false),
                    cfop_sai_codigo = table.Column<int>(type: "int", nullable: false),
                    est_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    est_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    est_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    est_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.est_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Icas",
                columns: table => new
                {
                    ica_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ica_descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icas", x => x.ica_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    mun_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mun_nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    mun_uf = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.mun_codigo);
                });

            migrationBuilder.CreateTable(
                name: "NafsCfop",
                columns: table => new
                {
                    cfo_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cfo_descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    cfo_tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    cfo_cst_inversa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NafsCfop", x => x.cfo_codigo);
                });

            migrationBuilder.CreateTable(
                name: "OpcoesPerfilLoja",
                columns: table => new
                {
                    pfl_codigo = table.Column<int>(type: "int", nullable: false),
                    opl_descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    opl_valor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OpcoesPermissaoUsuario",
                columns: table => new
                {
                    pmu_codigo = table.Column<int>(type: "int", nullable: false),
                    opu_descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    opu_valor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PerfisLoja",
                columns: table => new
                {
                    pfl_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mds_codigo = table.Column<int>(type: "int", nullable: false),
                    pfl_descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    pfl_definicao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    pfl_tipovalor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    pfl_vlrdefault = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfisLoja", x => x.pfl_codigo);
                });

            migrationBuilder.CreateTable(
                name: "PermissoesUsuario",
                columns: table => new
                {
                    pmu_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mds_codigo = table.Column<int>(type: "int", nullable: false),
                    pmu_descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    pmu_definicao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    pmu_tipovalor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    pmu_vlrdefault = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissoesUsuario", x => x.pmu_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    pes_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pes_nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    pes_fantasia = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    pes_endereco = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    pes_numero = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    pes_complemento = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    pes_bairro = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    pes_cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    pes_fone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    pes_celular = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    pes_tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    pes_tabela = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    pes_cpf_cnpj = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    pes_situacao = table.Column<bool>(type: "bit", nullable: false),
                    pes_identidade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    pes_email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    pes_observacoes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    mun_codigo = table.Column<int>(type: "int", nullable: false),
                    pag_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    pag_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    pag_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    pag_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.pes_codigo);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosLotacao",
                columns: table => new
                {
                    lot_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pro_codigo = table.Column<int>(type: "int", nullable: false),
                    pes_codigo = table.Column<int>(type: "int", nullable: false),
                    lot_qtd_und_compra = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosLotacao", x => x.lot_codigo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigsPerfilLoja");

            migrationBuilder.DropTable(
                name: "ConfigsPermissaoUsuario");

            migrationBuilder.DropTable(
                name: "CstsCofins");

            migrationBuilder.DropTable(
                name: "CstsIcms");

            migrationBuilder.DropTable(
                name: "CstsIpi");

            migrationBuilder.DropTable(
                name: "CstsPis");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Icas");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "NafsCfop");

            migrationBuilder.DropTable(
                name: "OpcoesPerfilLoja");

            migrationBuilder.DropTable(
                name: "OpcoesPermissaoUsuario");

            migrationBuilder.DropTable(
                name: "PerfisLoja");

            migrationBuilder.DropTable(
                name: "PermissoesUsuario");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "ProdutosLotacao");
        }
    }
}
