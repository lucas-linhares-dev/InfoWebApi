using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class Pessoa
    {
        [Key]
        public int pes_codigo { get; set; }

        [MaxLength(60)]
        [Required]
        public required string pes_nome { get; set; }


        [MaxLength(60)]
        public string pes_fantasia { get; set; } = null!;

        [MaxLength(120)]
        [Required]
        public required string pes_endereco { get; set; }

        [MaxLength(6)]
        [Required]
        public required string pes_numero { get; set; }

        [MaxLength(40)]
        public string pes_complemento { get; set; } = null!;

        [MaxLength(40)]
        [Required]
        public required string pes_bairro { get; set; }

        [MaxLength(9)]
        [Required]
        public required string pes_cep { get; set; }

        [MaxLength(14)]
        public string pes_fone { get; set; } = null!;

        [MaxLength(14)]
        public string pes_celular { get; set; } = null!;

        [MaxLength(1)]
        public string pes_tipo { get; set; } = "F";

        [MaxLength(1)]
        public string pes_tabela { get; set; } = "F";


        [MaxLength(18)]
        [Required]
        public required string pes_cpf_cnpj { get; set; }

        public bool pes_situacao { get; set; } = true;

        [MaxLength(40)]
        public string pes_identidade { get; set; } = null!;

        [MaxLength(60)]
        public string pes_email { get; set; } = null!;

        [MaxLength(300)]
        public string pes_observacoes { get; set; } = null!;

        [ForeignKey("Municipios")]
        public int mun_codigo { get; set; } = 2304400;


        [Column(TypeName = "date")]
        public DateTime pag_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime pag_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int pag_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int pag_usu_alteracao { get; set; }
    }
}
