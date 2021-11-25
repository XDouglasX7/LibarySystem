using LibrarySystem.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Plano> Planos { get; set; }

    }
}
