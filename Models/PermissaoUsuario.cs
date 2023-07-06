using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class PermissaoUsuario
    {
        [Key]
        public int pmu_codigo { get; set; }

        [ForeignKey("ModulosSistema")]
        [Required]
        public int mds_codigo { get; set; }

        [MaxLength(200)]
        [Required]
        public required string pmu_descricao { get; set; }

        [MaxLength(200)]
        [Required]
        public required string pmu_definicao { get; set; }

        [MaxLength(10)]
        public string pmu_tipovalor { get; set; } = "text";

        [MaxLength(10)]
        public string pmu_vlrdefault { get; set; } = null!;



    }
}
