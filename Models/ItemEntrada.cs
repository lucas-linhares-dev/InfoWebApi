using InfoWeb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class ItemEntrada
    {
        [Key]
        public int ita_codigo { get; set; }

        public int ita_nritem { get; set; } // REQUIRED?

        [ForeignKey("Entrada")]
        public int eta_codigo { get; set; }

        [ForeignKey("Produto")]
        public int pro_codigo { get; set; }

        [ForeignKey("NafCfop")]
        public int cfo_codigo { get; set; }

        [ForeignKey("CstIcms")]
        public int icm_codigo { get; set; }

        [ForeignKey("CstPis")]
        public int pis_codigo { get; set; }

        [ForeignKey("CstCofins")]
        public int cof_codigo { get; set; }


        [DecimalPrecision]
        public decimal ita_quantidade { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_icms_perc { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_ipi_perc { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_icms_perc_rec { get; set; } = decimal.Zero;


        [DecimalPrecision]
        public decimal ita_seguro_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_frete_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_desconto_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_outras_desp_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_unitario_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_total_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_liquidovlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_vlrpercfrete { get; set; } = decimal.Zero;


        [DecimalPrecision]
        public decimal ita_icms_bc_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_icms_vl { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_icms_perc_subst { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_bc_subst { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_vlr_subst { get; set; } = decimal.Zero;
        
        [DecimalPrecision]
        public decimal ita_vlr_deson { get; set; } = decimal.Zero;


        [DecimalPrecision]
        public decimal ita_fcp_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_fcpst_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_fcpret_vlr { get; set; } = decimal.Zero;


        [ForeignKey("CstIpi")]
        public int ipi_codigo { get; set; }

        [DecimalPrecision]
        public decimal ita_ipi_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_ipi_vlr_bc { get; set; } = decimal.Zero;


        [DecimalPrecision]
        public decimal ita_pis_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal ita_cofins_vlr { get; set; } = decimal.Zero;


    }
}
