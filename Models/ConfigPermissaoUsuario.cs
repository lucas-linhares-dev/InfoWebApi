using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class ConfigPermissaoUsuario
    {
        [Key]
        public int cpu_codigo { get; set; }

        [ForeignKey("Usuario")]
        public int usu_codigo { get; set; }

        [ForeignKey("PermissaoUsuario")]
        public int pmu_codigo { get; set; }

        [MaxLength(10)]
        [Required]
        public required string cpu_valor { get; set; }
    }
}
