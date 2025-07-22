using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PraticarFluentMapping.Models.Mappings
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            //Tabela
            builder.ToTable("Tag");

            //Chave Primaria
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd() // Toda vez que for adicionar um novo item, esse valor vai ser gerado(um id novo)
                .UseIdentityColumn(); // Adiciona de um 1 em 1(mesma coisa do IDENTITY(1,1) que usamos no banco)

            //Propriedades
            builder.Property(x => x.Name)
                .IsRequired() //Gera o NOT NULL
                .HasColumnName("Name") // Nome da coluna a ser gerada
                .HasColumnType("NVARCHAR") // Tipo
                .HasMaxLength(80); // Tamanho

            //Relacionamento MUITO para MUITOS(Tag e transações)
            builder
                .HasMany(x => x.Transacoes)
                .WithMany(x => x.Tags)
                .UsingEntity<Dictionary<string, object>>(
                    "TagTransacao",
                    tag => tag
                    .HasOne<Transacao>() // Tag tem transacao
                    .WithMany() // Tem muitas transacoes
                    .HasForeignKey("TagId")
                    .HasConstraintName("FK_TagTransacao_TagId")
                    .OnDelete(DeleteBehavior.Cascade),
                    Transacao => Transacao
                    .HasOne<Tag>() // Tag tem transacao
                    .WithMany() // Tem muitas transacoes
                    .HasForeignKey("TransacaoId")
                    .HasConstraintName("FK_TagTransacao_TransacaoId")
                    .OnDelete(DeleteBehavior.Cascade)
                );
        }
    }
}