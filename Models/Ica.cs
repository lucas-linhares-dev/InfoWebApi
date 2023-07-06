using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class Ica
    {
        [Key]
        public int ica_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string ica_descricao { get; set; }
    }
}
