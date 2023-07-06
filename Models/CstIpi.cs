using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class CstIpi
    {

        [Key]
        public int ipi_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string ipi_descricao { get; set; }

        [MaxLength(1)]
        [Required]
        public required string ipi_tipo { get; set; }

        [Required]  
        public int ipi_cst_inversa { get; set; }
    }
}
