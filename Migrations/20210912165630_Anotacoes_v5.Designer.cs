﻿// <auto-generated />
using System;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibrarySystem.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210912165630_Anotacoes_v5")]
    partial class Anotacoes_v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Planoid")
                        .HasColumnType("int");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.HasIndex("Planoid");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Colaborador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("preco_compra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preco_venda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Movimentacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("clienteid")
                        .HasColumnType("int");

                    b.Property<int?>("livroid")
                        .HasColumnType("int");

                    b.Property<int>("movimento")
                        .HasColumnType("int");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.HasIndex("livroid");

                    b.ToTable("Movimentacao");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Plano", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("porcen_desconto")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("id");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Cliente", b =>
                {
                    b.HasOne("LibrarySystem.Models.Dominio.Plano", "Plano")
                        .WithMany("cliente")
                        .HasForeignKey("Planoid");

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Movimentacao", b =>
                {
                    b.HasOne("LibrarySystem.Models.Dominio.Cliente", "cliente")
                        .WithMany("movimentacao")
                        .HasForeignKey("clienteid");

                    b.HasOne("LibrarySystem.Models.Dominio.Livro", "livro")
                        .WithMany("movimentacao")
                        .HasForeignKey("livroid");

                    b.Navigation("cliente");

                    b.Navigation("livro");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Cliente", b =>
                {
                    b.Navigation("movimentacao");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Livro", b =>
                {
                    b.Navigation("movimentacao");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Plano", b =>
                {
                    b.Navigation("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
