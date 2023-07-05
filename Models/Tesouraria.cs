
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class Tesouraria
    {
        [Key]
        public int tes_codigo { get; set; }

        [MaxLength(15)]
        public string tes_documento { get; set; } = null!;  

        [MaxLength(30)]
        public string tes_doctitulo { get; set; } = null!;

        [MaxLength(1)]
        [Required]
        public string tes_tipo { get; set; } = "D";

        [RegularExpression(@"^\d{1,12}(\.\d{1,2})?$")] // MAXIMO 12 DIGITOS INTEIROS E 2 DECIMAIS
        [Required]
        public decimal tes_valor { get; set; } = decimal.Zero; 

        [MaxLength(60)]
        public string tes_historico { get; set; } = null!;

        [Column(TypeName = "date")]
        [Required]
        public DateTime tes_datavenc { get; set; }

        [Column(TypeName = "date")]
        public DateTime tes_data { get; set; }

        [Required]
        public TimeSpan tes_hora { get; set; }


        [ForeignKey("Loja")]
        public int? loj_codigo { get; set; } = 1;

        [ForeignKey("FormaPag")]
        public int fpg_codigo { get; set; } = 1;

        [ForeignKey("CentroCusto")]
        public int? cen_codigo { get; set; }

        [ForeignKey("ContaPagar")]
        public int pag_codigo { get; set; }


        [Column(TypeName = "date")]
        public DateTime tes_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime tes_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int tes_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int tes_usu_alteracao { get; set; }

    }
}
