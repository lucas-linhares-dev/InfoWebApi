using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Models
{
    public class Usuario
    {
        [Key]
        public int usu_codigo { get; set; }

        [MaxLength(150)]
        [EmailAddress]
        [Required]
        public required string usu_email { get; set; }

        [MaxLength(60)]
        [Required]
        public required string usu_nome { get; set; }

        [MaxLength(30)]
        [Required]
        public required string usu_apelido { get; set; }

        [MaxLength(30)]
        public string usu_cargo { get; set; } = null!;

        [MaxLength(14)]
        public string usu_cpf { get; set;} = null!;

        [ForeignKey("Loja")]
        public int loj_codigo { get; set; } = 1;

        public bool usu_situacao { get; set; } = true;

        public bool usu_is_staff { get; set; } = false;

        public string usu_img { get; set; } = null!;


        [Column(TypeName = "date")]
        public required DateTime usu_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public required DateTime usu_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        public required int usu_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        public required int usu_usu_alteracao { get; set; }

    }
}
