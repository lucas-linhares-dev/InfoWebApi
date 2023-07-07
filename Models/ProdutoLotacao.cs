using InfoWeb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class ProdutoLotacao
    {
        [Key]
        [Column(Order = 1)]
        public long lot_codigo { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Pessoa")]
        public long pes_codigo { get; set; }

        [ForeignKey("Produto")]
        [Required]
        public int pro_codigo { get; set; }

        [DecimalPrecision]
        public decimal lot_qtd_und_compra { get; set; } = 1;
    }
}
