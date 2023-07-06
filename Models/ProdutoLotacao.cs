using InfoWeb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class ProdutoLotacao
    {
        [ForeignKey("Produto")]
        [Required]
        public int pro_codigo { get; set; }

        [ForeignKey("Pessoa")]
        [Required]
        public int pes_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string lot_prod { get; set; }


        [DecimalPrecision]
        public decimal lot_qtd_und_compra { get; set; } = 1;
    }
}
