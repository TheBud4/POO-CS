﻿// <auto-generated />

using Biblioteca.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteca.Migrations
{
    [DbContext(typeof(BibliotecaDbContext))]
    [Migration("20240823174606_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ApiBiblioteca.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("ApiBiblioteca.Models.AutorLivro", b =>
                {
                    b.Property<int>("AutorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LivroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AutorId", "LivroId");

                    b.HasIndex("LivroId");

                    b.ToTable("AutorLivros");
                });

            modelBuilder.Entity("ApiBiblioteca.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("ApiBiblioteca.Models.AutorLivro", b =>
                {
                    b.HasOne("ApiBiblioteca.Models.Autor", "Autor")
                        .WithMany("AutorLivros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiBiblioteca.Models.Livro", "Livro")
                        .WithMany("AutoresLivro")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("ApiBiblioteca.Models.Autor", b =>
                {
                    b.Navigation("AutorLivros");
                });

            modelBuilder.Entity("ApiBiblioteca.Models.Livro", b =>
                {
                    b.Navigation("AutoresLivro");
                });
#pragma warning restore 612, 618
        }
    }
}
