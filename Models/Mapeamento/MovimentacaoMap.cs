using LibrarySystem.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Mapeamento
{
    public class MovimentacaoMap : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Movimentacao> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.cliente).HasMaxLength(50).IsRequired();
            builder.Property(p => p.livro).HasMaxLength(50).IsRequired();
            builder.Property(p => p.quantidade).HasMaxLength(15).IsRequired();
            //builder.Property(p => p.movimento).HasMaxLength(35).IsRequired();

            builder.ToTable("Movimentacoes");
        }
    }
}
