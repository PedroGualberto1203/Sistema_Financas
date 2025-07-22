using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PraticarFluentMapping.Models.Mappings
{
    public class TransacaoMap : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            //Tabela
            builder.ToTable("Transacao");

            //Chave Primaria
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd() // Para gerar sempre um novo Id qaundo for adicionado 
                .UseIdentityColumn(); // Adicionar de 1 em 1

            //Propriedades
            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasColumnType("NVARCHAR");

            builder.Property(x => x.Valor)
                .IsRequired()
                .HasColumnName("Valor")
                .HasColumnType("DECIMAL(18, 2)");

            builder.Property(x => x.Data)
                .IsRequired()
                .HasColumnName("Data")
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETDATE()"); // Para pegar o GETDATE do SQL

            builder.HasOne(x => x.Categoria)
                .WithMany(x => x.Transacoes)
                .HasConstraintName("FK_Transacao_Categoria")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}