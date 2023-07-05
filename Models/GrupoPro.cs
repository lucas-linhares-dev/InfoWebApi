using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class GrupoPro
    {

        [Key]
        public int gru_codigo { get; set; }

        [MaxLength(30)]
        [Required]
        public required string gru_descricao { get; set; }


        [Column(TypeName = "date")]
        public DateTime gru_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime gru_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int gru_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int gru_usu_alteracao { get; set; }
    }
}
