using LibrarySystem.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cpf).HasMaxLength(14).IsRequired();
            builder.HasIndex(p => p.cpf).IsUnique();
            builder.Property(p => p.Plano).HasMaxLength(14).IsRequired();
            builder.Property(p => p.movimentacao).HasMaxLength(35).IsRequired();

            builder.HasMany(p => p.movimentacao).WithOne(p => p.cliente).HasForeignKey(p => p.cliente).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Clientes");
        }



    }
}
