using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class Municipio
    {
        [Key]
        public int mun_codigo { get; set; }

        [MaxLength(40)]
        [Required]
        public required string mun_nome { get; set; }

        [MaxLength(40)]
        public string mun_uf { get; set; } = "CE";

    }
}
