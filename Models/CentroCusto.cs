using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class CentroCusto
    {
        [Key]
        [Required]
        public int cen_codigo { get; set; }

        [MaxLength(30)]
        [Required]
        public required string cen_descricao { get; set; }

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
