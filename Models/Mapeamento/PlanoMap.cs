using LibrarySystem.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Mapeamento
{
    public class PlanoMap : IEntityTypeConfiguration<Plano>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plano> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(35).IsRequired();

            builder.HasMany(p => p.cliente).WithOne(p => p.Plano).HasForeignKey(p => p.Plano).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Planos");
        }
    }
}
