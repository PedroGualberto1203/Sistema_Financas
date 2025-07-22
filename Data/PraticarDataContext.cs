using BlogFluentMapping.Models;
using Microsoft.EntityFrameworkCore;
using PraticarFluentMapping.Models;
using PraticarFluentMapping.Models.Mappings;

namespace PraticarFluentMapping.Data
{
    public class PraticarDataContext : DbContext // PraticarDataContext representa o banco em meória
    {
        public DbSet<Categoria> Categorias { get; set; } //representação das tabelas em memória
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cofre> Cofres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) //Faz esse metodo passando a chave de conexão para realizar a conexão com o banco de dados
           => options.UseSqlServer("Server=localhost,1433;Database=Financeiro;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new TransacaoMap());
            modelBuilder.ApplyConfiguration(new CofreMap());
        }
    }

}