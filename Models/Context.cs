using Microsoft.EntityFrameworkCore;
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}






