using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.DataBase;
public class BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : DbContext(options) {
    public DbSet<Autor> Autores { get; set; }
    public DbSet<AutorLivro> AutorLivros { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Exemplar> Exemplares { get; set; }
    public DbSet<ExemplarEmprestimo> ExemplarEmprestimos { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Bairro> Bairros { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Editora> Editoras { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relacionamento entre Tb_Autor e Tb_AutorLivro
        modelBuilder.Entity<AutorLivro>()
            .HasKey(al => new { al.CodAutor, al.CodLivro });

        modelBuilder.Entity<AutorLivro>()
            .HasOne(al => al.Autor)
            .WithMany(a => a.AutorLivros)
            .HasForeignKey(al => al.CodAutor);

        modelBuilder.Entity<AutorLivro>()
            .HasOne(al => al.Livro)
            .WithMany(l => l.AutorLivros)
            .HasForeignKey(al => al.CodLivro);

        // Relacionamento entre Tb_Livro e Tb_Categorias
        modelBuilder.Entity<Livro>()
            .HasOne(l => l.Categoria)
            .WithMany(c => c.Livros)
            .HasForeignKey(l => l.CatCodigo);

        // Relacionamento entre Tb_Livro e Tb_Reserva
        modelBuilder.Entity<Reserva>()
            .HasOne(r => r.Livro)
            .WithMany(l => l.Reservas)
            .HasForeignKey(r => r.CodLivro);

        // Relacionamento entre Tb_Exemplar e Tb_Livro
        modelBuilder.Entity<Exemplar>()
            .HasOne(e => e.Livro)
            .WithMany(l => l.Exemplares)
            .HasForeignKey(e => e.LivCodigo);

        // Relacionamento entre Tb_ExemplarEmprestimo e Tb_Exemplar
        modelBuilder.Entity<ExemplarEmprestimo>()
            .HasOne(ee => ee.Exemplar)
            .WithMany(e => e.ExemplarEmprestimos)
            .HasForeignKey(ee => ee.CodExemplar);

        // Relacionamento entre Tb_ExemplarEmprestimo e Tb_Emprestimo
        modelBuilder.Entity<ExemplarEmprestimo>()
            .HasOne(ee => ee.Emprestimo)
            .WithMany(e => e.ExemplarEmprestimos)
            .HasForeignKey(ee => ee.CodEmprestimo);
        
        // Definindo a chave primária composta
        modelBuilder.Entity<ExemplarEmprestimo>()
            .HasKey(ee => new { ee.CodExemplar, ee.CodEmprestimo });

        // Relacionamento entre Tb_Reserva e Tb_Cliente
        modelBuilder.Entity<Reserva>()
            .HasOne(r => r.Cliente)
            .WithMany(c => c.Reservas)
            .HasForeignKey(r => r.CodCliente);

        // Relacionamento entre Tb_Reserva e Tb_Funcionario
        modelBuilder.Entity<Reserva>()
            .HasOne(r => r.Funcionario)
            .WithMany(f => f.Reservas)
            .HasForeignKey(r => r.CodFuncionario);

        // Relacionamento entre Tb_Emprestimo e Tb_Funcionario
        modelBuilder.Entity<Emprestimo>()
            .HasOne(e => e.Funcionario)
            .WithMany(f => f.Emprestimos)
            .HasForeignKey(e => e.CodFuncionario);

        // Relacionamento entre Tb_Cliente e Tb_Endereco
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Endereco)
            .WithMany(e => e.Clientes)
            .HasForeignKey(c => c.CodEndereco);

        // Relacionamento entre Tb_Funcionario e Tb_Endereco
        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Endereco)
            .WithMany(e => e.Funcionarios)
            .HasForeignKey(f => f.CodEndereco);

        // Relacionamento entre Tb_Cliente e Tb_Bairro
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Bairro)
            .WithMany(b => b.Clientes)
            .HasForeignKey(c => c.CodBairro);

        // Relacionamento entre Tb_Funcionario e Tb_Bairro
        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Bairro)
            .WithMany(b => b.Funcionarios)
            .HasForeignKey(f => f.CodBairro);

        // Relacionamento entre Tb_Cliente e Tb_Cidade
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Cidade)
            .WithMany(cid => cid.Clientes)
            .HasForeignKey(c => c.CodCidade);

        // Relacionamento entre Tb_Funcionario e Tb_Cidade
        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Cidade)
            .WithMany(cid => cid.Funcionarios)
            .HasForeignKey(f => f.CodCidade);

        // Relacionamento entre Tb_Funcionario e Tb_Cargo
        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Cargo)
            .WithMany(c => c.Funcionarios)
            .HasForeignKey(f => f.CodCargo);

        // Relacionamento entre Tb_Editora e Tb_Endereco
        modelBuilder.Entity<Editora>()
            .HasOne(e => e.Endereco)
            .WithMany(end => end.Editoras)
            .HasForeignKey(e => e.CodEndereco);

        // Relacionamento entre Tb_Editora e Tb_Cidade
        modelBuilder.Entity<Editora>()
            .HasOne(e => e.Cidade)
            .WithMany(c => c.Editoras)
            .HasForeignKey(e => e.CodCidade);

        // Relacionamento entre Tb_Editora e Tb_Bairro
        modelBuilder.Entity<Editora>()
            .HasOne(e => e.Bairro)
            .WithMany(b => b.Editoras)
            .HasForeignKey(e => e.CodBairro);

        base.OnModelCreating(modelBuilder);
    }
}
