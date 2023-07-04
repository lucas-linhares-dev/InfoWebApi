using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class ContaPagar
    {
        [Key]
        public int pag_codigo { get; set; }

        [MaxLength(30)]
        public string? pag_id_refs { get; set; }

        [MaxLength(50)]
        public string? pag_documento { get; set; }

        [MaxLength(15)]
        public required decimal pag_vlrdoc { get; set; }

        [MaxLength(15)]
        public required decimal pag_vlrdesc { get; set; }

        [MaxLength(15)]
        public required decimal pag_vlracresc { get; set; }

        [MaxLength(15)]
        public decimal pag_vlrmulta { get; set; }

        [MaxLength(15)]
        public decimal pag_vlrpagar { get; set; }

        [MaxLength(15)]
        public decimal pag_vlrpago { get; set; }

        [MaxLength(60)]
        public string? pag_historico { get; set; }

        [MaxLength(60)]
        public string? pag_numNfe { get; set; }

        [MaxLength(1)]
        public required string pag_situacao { get; set; }

        public DateTime? pag_dtvenc { get; set; }

        public DateTime? pag_dtlanc { get; set; }

        public DateTime? pag_dtpag { get; set; }

        public DateTime? pag_dtcomp { get; set; }

        public required TimeSpan pag_hora { get; set; }

        [ForeignKey("Loja")]
        public int? loj_codigo { get; set; } = 1;

        [ForeignKey("FormaPag")]
        public int fpg_codigo { get; set; } = 1;

        [ForeignKey("Pessoa")]
        public int? pes_codigo { get; set; }

        [ForeignKey("CentroCusto")]
        public int? cen_codigo { get; set; }

        public required bool debtesouraria { get; set; }

        [ForeignKey("Tesouraria")]
        public int? tes_codigo { get; set; }


        public required DateTime pag_dtcadastro { get; set; }

        public required DateTime pag_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        public required int pag_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        public required int pag_usu_alteracao { get; set; }
    }
}