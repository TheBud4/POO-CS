namespace ApiBiblioteca.Models;

public class Livro {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public List<AutorLivro> AutoresLivro { get; set; }
}