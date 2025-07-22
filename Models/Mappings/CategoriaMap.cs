using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PraticarFluentMapping.Models.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //Tabela
            builder.ToTable("Categoria");

            //Chave Primaria
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd() // Para gerar sempre um novo Id qaundo for adicionado 
                .UseIdentityColumn(); // Adicionar de 1 em 1

            //Propriedades
            builder.Property(x => x.Name)
                .IsRequired() //Gera o NOT NULL
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            //Índices(usados para procura/busca)
            builder.HasIndex(x => x.Name, "IX_Categoria_Name")
                .IsUnique();
        }
    }
}