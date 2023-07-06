using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class CstCofins
    {

        [Key]
        public int cof_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string cof_descricao { get; set; }

        [MaxLength(1)]
        [Required]
        public required string cof_tipo { get; set; }

        [Required]
        public int cof_cst_inversa { get; set; }
    }
}
