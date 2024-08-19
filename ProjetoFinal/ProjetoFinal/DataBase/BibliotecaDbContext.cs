using ApiBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.DataBase;

public class BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : DbContext(options) {
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<AutorLivro> AutorLivros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        // Configurando a chave composta de AutorLivro
        modelBuilder.Entity<AutorLivro>()
            .HasKey(al => new { al.AutorId, al.LivroId });

        // Configurando as relações
        modelBuilder.Entity<AutorLivro>()
            .HasOne(al => al.Autor)
            .WithMany(a => a.AutorLivros)
            .HasForeignKey(al => al.AutorId);

        modelBuilder.Entity<AutorLivro>()
            .HasOne(al => al.Livro)
            .WithMany(l => l.AutoresLivro)
            .HasForeignKey(al => al.LivroId);
    }
}