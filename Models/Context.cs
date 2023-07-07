using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace InfoWeb.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<FormaPag> FormasPag { get; set; }
        public DbSet<CentroCusto> CentrosCusto { get; set; }
        public DbSet<ContaPagar> ContasPagar { get; set; }
        public DbSet<GrupoPro> GruposPro { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Tesouraria> Tesourarias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ConfigPerfilLoja> ConfigsPerfilLoja { get; set; }
        public DbSet<ConfigPermissaoUsuario> ConfigsPermissaoUsuario { get; set; }
        public DbSet<CstCofins> CstsCofins { get; set; }
        public DbSet<CstIcms> CstsIcms { get; set; }
        public DbSet<CstIpi> CstsIpi { get; set; }
        public DbSet<CstPis> CstsPis { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Ica> Icas { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<NafCfop> NafsCfop { get; set; }
        public DbSet<OpcaoPerfilLoja> OpcoesPerfilLoja { get; set; }
        public DbSet<OpcaoPermissaoUsuario> OpcoesPermissaoUsuario { get; set; }
        public DbSet<PerfilLoja> PerfisLoja { get; set; }
        public DbSet<PermissaoUsuario> PermissoesUsuario { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<ConfigModuloSistemaLoja> ConfigsModuloSistemaLoja { get; set; }
        public DbSet<ConfigModuloSistemaUsuario> ConfigsModuloSistemaUsuario { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<ItemEntrada> ItensEntrada { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<ModuloSistema> ModulosSistema { get; set; }
        public DbSet<ProdutoLotacao> ProdutosLotacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OpcaoPerfilLoja>().HasNoKey();
            modelBuilder.Entity<OpcaoPermissaoUsuario>().HasNoKey();

            modelBuilder.Entity<ContaPagar>()
                .HasOne<FormaPag>()
                .WithMany()
                .HasForeignKey(c => c.fpg_codigo)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ContaPagar>()
                .HasOne<CentroCusto>()
                .WithMany()
                .HasForeignKey(c => c.cen_codigo)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProdutoLotacao>()
                .HasKey(lot => new { lot.lot_codigo, lot.pes_codigo });


            modelBuilder.Entity<ConfigModuloSistemaLoja>()
                .HasKey(cml => new { cml.cml_codigo, cml.mds_codigo });


            modelBuilder.Entity<ConfigModuloSistemaUsuario>()
                .HasKey(cmu => new { cmu.cmu_codigo, cmu.mds_codigo });
        }

    }
}






