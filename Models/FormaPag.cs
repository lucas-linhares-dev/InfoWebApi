
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class FormaPag
    {
        [Key]
        public int fpg_codigo { get; set; }

        [MaxLength(30)]
        public required string fpg_descricao { get; set; }


        public required DateTime fpg_dtcadastro { get; set; }

        public required DateTime fpg_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        public required int fpg_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        public required int fpg_usu_alteracao { get; set; }

    }
}