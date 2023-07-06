using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class ConfigPerfilLoja
    {

        [Key]
        public int cpl_codigo { get; set; }

        [ForeignKey("Usuario")]
        public int usu_codigo { get; set; }

        [ForeignKey("PerfilLoja")]
        public int pfl_codigo { get; set; }

        [MaxLength(10)]
        [Required]
        public required string cpl_valor { get; set; }
    }
}
