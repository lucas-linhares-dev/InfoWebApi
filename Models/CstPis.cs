using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class CstPis
    {

        [Key]
        public int pis_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string pis_descricao { get; set; }

        [MaxLength(1)]
        [Required]
        public required string pis_tipo { get; set; }

        [Required]
        public int pis_cst_inversa { get; set; }
    }
}
