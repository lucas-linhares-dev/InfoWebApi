using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using InfoWeb.Attributes;

namespace InfoWeb.Models
{
    public class Produto
    {
        [Key]
        public int pro_codigo { get; set; }

        [ForeignKey("GrupoPro")]
        public int gru_codigo { get; set; } = 1;

        [ForeignKey("Marca")]
        public int mar_codigo { get; set; } = 1;

        [ForeignKey("Pessoa")]
        public int pes_codigo { get; set; } = 1;

        [ForeignKey("Ica")]
        public int? ica_codigo { get; set; }

        [MaxLength(300)]
        [Required]
        public required string pro_descricao { get; set; } // UNIQUE

        [MaxLength(300)]
        [Required]
        public required string pro_descfiscal { get; set; } // UNIQUE

        [MaxLength(30)]
        public string pro_referencia { get; set; } = null!;

        [MaxLength(8)]
        [Required]
        public required string pro_ncm { get; set; }

        [MaxLength(2)]
        [Required]
        public required string pro_genero { get; set; }

        [MaxLength(300)]
        public string? pro_observacao { get; set; }

        [MaxLength(14)]
        public string? pro_codigoean { get; set; }

        public bool pro_situacao { get; set; } = true;


        [DecimalPrecision]
        public decimal pro_prccompra { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal pro_prccusto { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal pro_prctransf { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal pro_prccomprant { get; set; } = decimal.Zero;

        public string pro_img { get; set; } = null!;

        [MaxLength(6)]
        public string unidade { get; set; } = "UNID";


        [Column(TypeName = "date")]
        public DateTime cen_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime cen_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int cen_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int cen_usu_alteracao { get; set; }

    }
}
