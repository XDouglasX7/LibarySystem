using LibrarySystem.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Mapeamento
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.preco_compra).HasMaxLength(35).IsRequired();
            builder.Property(p => p.preco_venda).HasMaxLength(35).IsRequired();
            builder.Property(p => p.quantidade).HasMaxLength(15).IsRequired();
            //builder.Property(p => p.movimentacao).HasMaxLength(35).IsRequired();

            builder.HasMany(p => p.movimentacao).WithOne(p => p.livro).HasForeignKey(p => p.livro).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Livros");
        }
    }
}
