using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class ModuloSistema
    {
        [Key]
        public int mds_codigo { get; set; }

        [MaxLength(100)]
        [Required]
        public required string mds_descricao { get; set; }

    }
}
