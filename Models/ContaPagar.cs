using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class ContaPagar
    {
        [Key]
        public int pag_codigo { get; set; }

        [MaxLength(30)]
        public string pag_id_refs { get; set; } = null!;

        [MaxLength(50)]
        public string pag_documento { get; set; } = null!;

        [RegularExpression(@"^\d{1,12}(\.\d{1,2})?$")] // MAXIMO 12 DIGITOS INTEIROS E 2 DECIMAIS
        [Required]
        public decimal pag_vlrdoc { get; set; }

        [RegularExpression(@"^\d{1,12}(\.\d{1,2})?$")] // MAXIMO 12 DIGITOS INTEIROS E 2 DECIMAIS
        [Required]
        public decimal pag_vlrdesc { get; set; }

        [RegularExpression(@"^\d{1,12}(\.\d{1,2})?$")] // MAXIMO 12 DIGITOS INTEIROS E 2 DECIMAIS
        [Required]
        public decimal pag_vlracresc { get; set; }

        [RegularExpression(@"^\d{1,12}(\.\d{1,2})?$")] // MAXIMO 12 DIGITOS INTEIROS E 2 DECIMAIS
        public decimal pag_vlrmulta { get; set; }

        [RegularExpression(@"^\d{1,12}(\.\d{1,2})?$")] // MAXIMO 12 DIGITOS INTEIROS E 2 DECIMAIS
        public decimal pag_vlrpagar { get; set; }

        [RegularExpression(@"^\d{1,12}(\.\d{1,2})?$")] // MAXIMO 12 DIGITOS INTEIROS E 2 DECIMAIS
        public decimal pag_vlrpago { get; set; }

        [MaxLength(60)]
        public string pag_historico { get; set; } = null!;

        [MaxLength(60)]
        public string pag_numNfe { get; set; } = null!;

        [MaxLength(1)]
        [Required]
        public string pag_situacao { get; set; } = "P";

        [Column(TypeName = "date")]
        public DateTime pag_dtvenc { get; set; }

        [Column(TypeName = "date")]
        public DateTime pag_dtlanc { get; set; }

        [Column(TypeName = "date")]
        public DateTime pag_dtpag { get; set; }

        [Column(TypeName = "date")]
        public DateTime pag_dtcomp { get; set; }

        [Required]
        public TimeSpan pag_hora { get; set; }

        [ForeignKey("Loja")]
        public int loj_codigo { get; set; } = 1;

        [ForeignKey("FormaPag")]
        public int fpg_codigo { get; set; } = 1;

        [ForeignKey("Pessoa")]
        public int? pes_codigo { get; set; }

        [ForeignKey("CentroCusto")]
        public int? cen_codigo { get; set; }

        public required bool pag_debtesouraria { get; set; }

        [ForeignKey("Tesouraria")]
        public int? tes_codigo { get; set; }

        [Column(TypeName = "date")]
        public DateTime pag_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime pag_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int pag_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int pag_usu_alteracao { get; set; }
    }
}