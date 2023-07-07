
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class FormaPag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fpg_codigo { get; set; }

        [MaxLength(30)]
        [Required]
        public required string fpg_descricao { get; set; }


        [Column(TypeName = "date")]
        public DateTime pag_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime pag_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int pag_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int pag_usu_alteracao { get; set; }

    }
}