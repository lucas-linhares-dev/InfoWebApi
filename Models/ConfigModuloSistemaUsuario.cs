using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class ConfigModuloSistemaUsuario
    {
        [Key]
        [Column(Order = 1)]
        public long cmu_codigo { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("ModulosSistema")]
        public long mds_codigo { get; set; }

        [ForeignKey("Usuario")]
        public int usu_codigo { get; set; }

        public bool cmu_situacao { get; set; } = false;
    }
}
