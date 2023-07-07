using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class ConfigModuloSistemaLoja
    {
        [Key]
        [Column(Order = 1)]
        public long cml_codigo { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("ModulosSistema")]
        public long mds_codigo { get; set; }

        [ForeignKey("Loja")]
        public int loj_codigo { get; set; }

        public bool cml_situacao { get; set; } = false;
    }
}
