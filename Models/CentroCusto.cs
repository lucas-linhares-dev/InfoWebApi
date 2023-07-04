using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class CentroCusto
    {
        [Key]
        public int cen_codigo { get; set; }

        [MaxLength(30)]
        public required string cen_descricao { get; set; }


        public required DateTime cen_dtcadastro { get; set; }

        public required DateTime cen_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        public required int cen_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        public required int cen_usu_alteracao { get; set; }
    }
}
