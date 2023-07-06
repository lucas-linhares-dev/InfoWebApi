using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class NafCfop
    {

        [Key]
        public int cfo_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string cfo_descricao { get; set; }

        [MaxLength(1)]
        [Required]
        public required string cfo_tipo { get; set; }

        [Required]
        public int cfo_cst_inversa { get; set; }
    }
}
