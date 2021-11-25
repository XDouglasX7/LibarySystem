using LibrarySystem.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Mapeamento
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Colaborador> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cpf).HasMaxLength(14).IsRequired();
            builder.HasIndex(p => p.cpf).IsUnique();
            builder.Property(p => p.email).HasMaxLength(40).IsRequired();
            builder.Property(p => p.usuario).HasMaxLength(35).IsRequired();

            builder.ToTable("Colaboradores");
        }
    }
}
