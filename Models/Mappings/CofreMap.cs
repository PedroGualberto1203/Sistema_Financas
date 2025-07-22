using BlogFluentMapping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PraticarFluentMapping.Models.Mappings
{
    public class CofreMap : IEntityTypeConfiguration<Cofre>
    {
        public void Configure(EntityTypeBuilder<Cofre> builder)
        {
            //Tabela
            builder.ToTable("Cofre");

            //Chave Primaria
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd() // Toda vez que for adicionar um novo item, esse valor vai ser gerado(um id novo)
                .UseIdentityColumn(); // Adiciona de um 1 em 1(mesma coisa do IDENTITY(1,1) que usamos no banco)

            //Propriedades
            builder.Property(x => x.Saldo)
                .IsRequired()
                .HasColumnName("Saldo")
                .HasColumnType("DECIMAL(18, 2)");
        }
    }
}