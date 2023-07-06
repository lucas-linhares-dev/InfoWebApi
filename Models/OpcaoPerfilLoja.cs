using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class OpcaoPerfilLoja
    {
        [ForeignKey("PerfilLoja")]
        public int pfl_codigo { get; set; }

        [MaxLength(100)]
        [Required]
        public required string opl_descricao { get; set; }

        [MaxLength(10)]
        [Required]
        public required string opl_valor { get; set; }
    }
}
