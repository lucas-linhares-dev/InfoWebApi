using InfoWeb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class Entrada
    {
        [Key]
        public int eta_codigo { get; set; }

        public long eta_numeronf { get; set; }

        [ForeignKey("Pessoa")]
        public int pes_codigo { get; set; } = 1;

        [ForeignKey("Loja")]
        public int loj_codigo { get; set; } = 1;

        [Column(TypeName = "date")]
        public DateTime eta_dtemissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime eta_dtlanc { get; set; }

        [Column(TypeName = "date")]
        public DateTime eta_dtbaixa { get; set; }

        public TimeSpan eta_hora { get; set; }

        [MaxLength(15)]
        public string eta_protocoloxml { get; set; } = null!;


        [DecimalPrecision]
        public decimal eta_icms_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_icms_bc_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_icms_subst_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_icms_bcsubst_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_icms_antecipado_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_deson_vlr { get; set; } = decimal.Zero;


        [DecimalPrecision]
        public decimal eta_frete_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_frete_perc_vlr { get; set; } = decimal.Zero;


        [DecimalPrecision]
        public decimal eta_ipi_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_pis_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_cofins_vlr { get; set; } = decimal.Zero;


        [DecimalPrecision]
        public decimal eta_bc_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_total_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_totalnf_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_desconto_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_outras_desp_vlr { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal eta_seguro_vlr { get; set; } = decimal.Zero;


        [MaxLength(200)]
        public string eta_observacao { get; set; } = null!;

        [MaxLength(44)]
        public string eta_chave { get; set; } = null!;

        [MaxLength(1)]
        public string eta_situacao { get; set; } = "P";

        [ForeignKey("NafCfop")]
        public int cfo_codigo { get; set; }


        [Column(TypeName = "date")]
        public DateTime eta_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime eta_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int eta_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int eta_usu_alteracao { get; set; }


    }
}
