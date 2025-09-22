using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.EntitiesConfiguration
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(l => l.LivroId);
            builder.Property(l => l.Titulo).IsRequired().HasMaxLength(150);
            builder.Property(l => l.Autor).IsRequired().HasMaxLength(200);
            builder.Property(l => l.DataPublicacao).IsRequired();
            builder.Property(l => l.Capa).HasMaxLength(200);
        }
    }
}
