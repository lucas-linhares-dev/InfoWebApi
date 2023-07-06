using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class PerfilLoja
    {
        [Key]
        public int pfl_codigo { get; set; }

        [ForeignKey("ModulosUsuario")]
        [Required]
        public int mds_codigo { get; set; }

        [MaxLength(200)]
        [Required]
        public required string pfl_descricao { get; set; }

        [MaxLength(200)]
        [Required]
        public required string pfl_definicao { get; set; }

        [MaxLength(10)]
        public string pfl_tipovalor { get; set; } = "text";

        [MaxLength(10)]
        public string pfl_vlrdefault { get; set; } = null!;





    }
}
