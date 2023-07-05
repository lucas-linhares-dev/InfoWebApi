using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class Marca
    {
        [Key]
        public int mar_codigo { get; set; }

        [MaxLength(30)]
        [Required]
        public required string mar_descricao { get; set; }

        [Column(TypeName = "date")]
        public DateTime mar_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime mar_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int mar_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int mar_usu_alteracao { get; set; }
    }
}
