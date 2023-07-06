
using InfoWeb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class Estoque
    {
        [Key]
        public int est_codigo { get; set; }

        [ForeignKey("Produto")]
        [Required]
        public int pro_codigo { get; set; }

        [ForeignKey("Loja")]
        [Required]
        public int loj_codigo { get; set; }

        ///////////////////////////////////////////////////////////////////////////////

        [DecimalPrecision]
        public decimal est_estoque { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_estoque_usado { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_estoque_avariado { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_estoque_reservado { get; set; } = decimal.Zero;

        ///////////////////////////////////////////////////////////////////////////////

        [DecimalPrecision]
        public decimal est_preco1 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_preco2 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_preco3 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_preco4 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_preco5 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_preco6 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_preco7 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_preco8 { get; set; } = decimal.Zero;

        ///////////////////////////////////////////////////////////////////////////////

        [DecimalPrecision]
        public decimal est_precoliquido1 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precoliquido2 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precoliquido3 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precoliquido4 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precoliquido5 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precoliquido6 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precoliquido7 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precoliquido8 { get; set; } = decimal.Zero;

        ///////////////////////////////////////////////////////////////////////////////

        [DecimalPrecision]
        public decimal est_precopromocional1 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precopromocional2 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precopromocional3 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precopromocional4 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precopromocional5 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precopromocional6 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precopromocional7 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_precopromocional8 { get; set; } = decimal.Zero;

        ///////////////////////////////////////////////////////////////////////////////

        [DecimalPrecision]
        public decimal est_vlrdesconto1 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_vlrdesconto2 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_vlrdesconto3 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_vlrdesconto4 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_vlrdesconto5 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_vlrdesconto6 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_vlrdesconto7 { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_vlrdesconto8 { get; set; } = decimal.Zero;

        ///////////////////////////////////////////////////////////////////////////////

        [MaxLength(2)]
        public string est_imposto { get; set; } = "S";


        [DecimalPrecision]
        public decimal est_pis_perc { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_cof_perc { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal est_ipi_perc { get; set; } = decimal.Zero;


        [ForeignKey("CstPis")]
        public int pis_ent_cod { get; set; } = 98;


        [ForeignKey("CstPis")]
        public int pis_sai_cod { get; set; } = 99;


        [ForeignKey("CstCofins")]
        public int cof_ent_codigo { get; set; } = 98;


        [ForeignKey("CstCofins")]
        public int cof_sai_codigo { get; set; } = 99;


        [ForeignKey("CstIcms")]
        public int icms_codigo { get; set; } = 0;


        [ForeignKey("CstIpi")]
        public int ipi_ent_codigo { get; set; } = 49;


        [ForeignKey("CstIpi")]
        public int ipi_sai_codigo { get; set; } = 99;


        [ForeignKey("NafCfop")]
        public int cfop_ent_codigo { get; set; } = 1102;


        [ForeignKey("NafCfop")]
        public int cfop_sai_codigo { get; set; } = 5102;


        [Column(TypeName = "date")]
        public DateTime est_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime est_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int est_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int est_usu_alteracao { get; set; }








    }
}
