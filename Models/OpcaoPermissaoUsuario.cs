using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class OpcaoPermissaoUsuario
    {
        [ForeignKey("PermissaoUsuario")]
        public int pmu_codigo { get; set; }

        [MaxLength(100)]
        [Required]
        public required string opu_descricao { get; set; }

        [MaxLength(10)]
        [Required]
        public required string opu_valor { get; set; }

    }
}
