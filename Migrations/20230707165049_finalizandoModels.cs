using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoWeb.Migrations
{
    /// <inheritdoc />
    public partial class finalizandoModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentrosCusto",
                columns: table => new
                {
                    cen_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cen_descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    cen_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    cen_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    cen_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    cen_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentrosCusto", x => x.cen_codigo);
                });

            migrationBuilder.CreateTable(
                name: "ConfigsModuloSistemaLoja",
                columns: table => new
                {
                    cml_codigo = table.Column<long>(type: "bigint", nullable: false),
                    mds_codigo = table.Column<long>(type: "bigint", nullable: false),
                    loj_codigo = table.Column<int>(type: "int", nullable: false),
                    cml_situacao = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigsModuloSistemaLoja", x => new { x.cml_codigo, x.mds_codigo });
                });

            migrationBuilder.CreateTable(
                name: "ConfigsModuloSistemaUsuario",
                columns: table => new
                {
                    cmu_codigo = table.Column<long>(type: "bigint", nullable: false),
                    mds_codigo = table.Column<long>(type: "bigint", nullable: false),
                    usu_codigo = table.Column<int>(type: "int", nullable: false),
                    cmu_situacao = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigsModuloSistemaUsuario", x => new { x.cmu_codigo, x.mds_codigo });
                });

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
                name: "Entradas",
                columns: table => new
                {
                    eta_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eta_numeronf = table.Column<long>(type: "bigint", nullable: false),
                    pes_codigo = table.Column<int>(type: "int", nullable: false),
                    loj_codigo = table.Column<int>(type: "int", nullable: false),
                    eta_dtemissao = table.Column<DateTime>(type: "date", nullable: false),
                    eta_dtlanc = table.Column<DateTime>(type: "date", nullable: false),
                    eta_dtbaixa = table.Column<DateTime>(type: "date", nullable: false),
                    eta_hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    eta_protocoloxml = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    eta_icms_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_icms_bc_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_icms_subst_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_icms_bcsubst_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_icms_antecipado_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_deson_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_frete_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_frete_perc_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_ipi_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_pis_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_cofins_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_bc_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_total_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_totalnf_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_desconto_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_outras_desp_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_seguro_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    eta_observacao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    eta_chave = table.Column<string>(type: "nvarchar(44)", maxLength: 44, nullable: false),
                    eta_situacao = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    cfo_codigo = table.Column<int>(type: "int", nullable: false),
                    eta_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    eta_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    eta_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    eta_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.eta_codigo);
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
                name: "FormasPag",
                columns: table => new
                {
                    fpg_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fpg_descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    fpg_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    fpg_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    fpg_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    fpg_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPag", x => x.fpg_codigo);
                });

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
                name: "ItensEntrada",
                columns: table => new
                {
                    ita_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ita_nritem = table.Column<int>(type: "int", nullable: false),
                    eta_codigo = table.Column<int>(type: "int", nullable: false),
                    pro_codigo = table.Column<int>(type: "int", nullable: false),
                    cfo_codigo = table.Column<int>(type: "int", nullable: false),
                    icm_codigo = table.Column<int>(type: "int", nullable: false),
                    pis_codigo = table.Column<int>(type: "int", nullable: false),
                    cof_codigo = table.Column<int>(type: "int", nullable: false),
                    ita_quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_icms_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_ipi_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_icms_perc_rec = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_seguro_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_frete_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_desconto_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_outras_desp_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_unitario_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_total_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_liquidovlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_vlrpercfrete = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_icms_bc_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_icms_vl = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_icms_perc_subst = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_bc_subst = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_vlr_subst = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_vlr_deson = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_fcp_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_fcpst_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_fcpret_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ipi_codigo = table.Column<int>(type: "int", nullable: false),
                    ita_ipi_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_ipi_vlr_bc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_pis_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ita_cofins_vlr = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensEntrada", x => x.ita_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    loj_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loj_razaosocial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    loj_fantasia = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    loj_nomeabrev = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    loj_cnpj = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    loj_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    loj_situacao = table.Column<bool>(type: "bit", nullable: false),
                    loj_cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    loj_bairro = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    loj_endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    loj_numero = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    loj_complemento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    loj_referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mun_codigo = table.Column<int>(type: "int", nullable: false),
                    loj_fone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    loj_celular = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    loj_whatsapp = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    loj_ie = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    loj_im = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    loj_sefaz_codigo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    loj_chaveMfe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    loj_nfeObs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    loj_csite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    crt_codigo = table.Column<int>(type: "int", nullable: false),
                    icmscrt_codigo = table.Column<int>(type: "int", nullable: false),
                    pis_ent_codigo = table.Column<int>(type: "int", nullable: false),
                    pis_sai_codigo = table.Column<int>(type: "int", nullable: false),
                    cof_ent_codigo = table.Column<int>(type: "int", nullable: false),
                    cof_sai_codigo = table.Column<int>(type: "int", nullable: false),
                    icm_codigo = table.Column<int>(type: "int", nullable: false),
                    ipi_ent_codigo = table.Column<int>(type: "int", nullable: false),
                    ipi_sai_codigo = table.Column<int>(type: "int", nullable: false),
                    cfo_ent_codigo = table.Column<int>(type: "int", nullable: false),
                    cfo_sai_codigo = table.Column<int>(type: "int", nullable: false),
                    loj_cof_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    loj_pis_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    loj_ipi_perc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    loj_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    loj_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
                    loj_usu_cadastro = table.Column<int>(type: "int", nullable: false),
                    loj_usu_alteracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.loj_codigo);
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
                name: "ModulosSistema",
                columns: table => new
                {
                    mds_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mds_descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulosSistema", x => x.mds_codigo);
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
                name: "ProdutosLotacao",
                columns: table => new
                {
                    lot_codigo = table.Column<long>(type: "bigint", nullable: false),
                    pes_codigo = table.Column<long>(type: "bigint", nullable: false),
                    pro_codigo = table.Column<int>(type: "int", nullable: false),
                    lot_qtd_und_compra = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosLotacao", x => new { x.lot_codigo, x.pes_codigo });
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

            migrationBuilder.CreateTable(
                name: "ContasPagar",
                columns: table => new
                {
                    pag_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pag_id_refs = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    pag_documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pag_vlrdoc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pag_vlrdesc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pag_vlracresc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pag_vlrmulta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pag_vlrpagar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pag_vlrpago = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pag_historico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    pag_numNfe = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    pag_situacao = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    pag_dtvenc = table.Column<DateTime>(type: "date", nullable: false),
                    pag_dtlanc = table.Column<DateTime>(type: "date", nullable: false),
                    pag_dtpag = table.Column<DateTime>(type: "date", nullable: false),
                    pag_dtcomp = table.Column<DateTime>(type: "date", nullable: false),
                    pag_hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    loj_codigo = table.Column<int>(type: "int", nullable: false),
                    fpg_codigo = table.Column<int>(type: "int", nullable: false),
                    pes_codigo = table.Column<int>(type: "int", nullable: true),
                    cen_codigo = table.Column<int>(type: "int", nullable: true),
                    pag_debtesouraria = table.Column<bool>(type: "bit", nullable: false),
                    tes_codigo = table.Column<int>(type: "int", nullable: true),
                    pag_dtcadastro = table.Column<DateTime>(type: "date", nullable: false),
                    pag_dtalteracao = table.Column<DateTime>(type: "date", nullable: false),
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
                name: "ConfigsModuloSistemaLoja");

            migrationBuilder.DropTable(
                name: "ConfigsModuloSistemaUsuario");

            migrationBuilder.DropTable(
                name: "ConfigsPerfilLoja");

            migrationBuilder.DropTable(
                name: "ConfigsPermissaoUsuario");

            migrationBuilder.DropTable(
                name: "ContasPagar");

            migrationBuilder.DropTable(
                name: "CstsCofins");

            migrationBuilder.DropTable(
                name: "CstsIcms");

            migrationBuilder.DropTable(
                name: "CstsIpi");

            migrationBuilder.DropTable(
                name: "CstsPis");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "GruposPro");

            migrationBuilder.DropTable(
                name: "Icas");

            migrationBuilder.DropTable(
                name: "ItensEntrada");

            migrationBuilder.DropTable(
                name: "Lojas");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "ModulosSistema");

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
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "ProdutosLotacao");

            migrationBuilder.DropTable(
                name: "Tesourarias");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CentrosCusto");

            migrationBuilder.DropTable(
                name: "FormasPag");
        }
    }
}
