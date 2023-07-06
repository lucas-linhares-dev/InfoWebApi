using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class CstIcms
    {

        [Key]
        public int icm_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string icm_descricao { get; set; }

    }
}
