using InfoWeb.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoWeb.Models
{
    public class Loja
    {
        [Key]
        public int loj_codigo { get; set; }

        [MaxLength(50)]
        [Required]
        public required string loj_razaosocial { get; set; }

        [MaxLength(40)]
        [Required]
        public required string loj_fantasia { get; set; }

        [MaxLength(10)]
        public string loj_nomeabrev { get; set; } = null!;

        [MaxLength(18)]
        [Required]  
        public required string loj_cnpj{ get; set; }

        [MaxLength(50)]
        public string loj_email { get; set; } = null!;

        public bool loj_situacao { get; set; } = true;

        [MaxLength(9)]
        public string loj_cep { get; set; } = null!;

        [MaxLength(40)]
        public string loj_bairro { get; set; } = null!;

        [MaxLength(50)]
        public string loj_endereco { get; set; } = null!;

        [MaxLength(6)]
        public string loj_numero{ get; set; } = null!;

        [MaxLength(30)]
        public string loj_complemento { get; set; } = null!;

        [MaxLength(50)]
        public string loj_referencia { get; set; } = null!;

        [ForeignKey("Municipio")]
        public int mun_codigo { get; set; } = 2304400;

        [MaxLength(15)]
        public string loj_fone { get; set; } = null!;

        [MaxLength(15)]
        public string loj_celular { get; set; } = null!;

        [MaxLength(15)]
        public string loj_whatsapp { get; set; } = null!;

        [MaxLength(12)]
        public string loj_ie { get; set; } = null!;

        [MaxLength(12)]
        public string loj_im { get; set; } = null!;

        [MaxLength(12)]
        public string loj_sefaz_codigo { get; set; } = null!;

        [MaxLength(50)]
        public string loj_chaveMfe { get; set; } = null!;

        [MaxLength(50)]
        public string loj_nfeObs { get; set; } = null!;


        // CNAE -> CRIAR TABELAS

        [MaxLength(50)]
        public string loj_csite { get; set; } = null!;

        public int crt_codigo { get; set; } = 1;

        public int icmscrt_codigo { get; set; } = 1;


        // DADOS TRIBUTARIOS E RELACIONADOS

        [ForeignKey("CstPis")]
        public int pis_ent_codigo { get; set; } = 98;

        [ForeignKey("CstPis")]
        public int pis_sai_codigo { get; set; } = 99;


        [ForeignKey("CstCofins")]
        public int cof_ent_codigo { get; set; } = 98;

        [ForeignKey("CstCofins")]
        public int cof_sai_codigo { get; set; } = 99;


        [ForeignKey("CstIcms")]
        public int icm_codigo { get; set; } = 0;


        [ForeignKey("CstIpi")]
        public int ipi_ent_codigo { get; set; } = 49;

        [ForeignKey("CstIpi")]
        public int ipi_sai_codigo { get; set; } = 99;


        [ForeignKey("NafCfop")]
        public int cfo_ent_codigo { get; set; } = 1102;

        [ForeignKey("NafCfop")]
        public int cfo_sai_codigo { get; set; } = 5102;


        [DecimalPrecision]
        public decimal loj_cof_perc { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal loj_pis_perc { get; set; } = decimal.Zero;

        [DecimalPrecision]
        public decimal loj_ipi_perc { get; set; } = decimal.Zero;


        [Column(TypeName = "date")]
        public DateTime loj_dtcadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime loj_dtalteracao { get; set; } = DateTime.Now;

        [ForeignKey("Usuario")]
        [Required]
        public int loj_usu_cadastro { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int loj_usu_alteracao { get; set; }

    }
}
