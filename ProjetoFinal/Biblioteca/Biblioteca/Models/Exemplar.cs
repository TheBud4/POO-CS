namespace Biblioteca.Models;

public class Exemplar {
    public int Id { get; set; }
    public string IdLivro { get; set; }
    public string Status { get; set; }

    public int LivCodigo { get; set; }
    public Livro Livro { get; set; }

    public List<ExemplarEmprestimo> ExemplarEmprestimos { get; set; }

}