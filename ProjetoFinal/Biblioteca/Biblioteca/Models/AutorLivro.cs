namespace Biblioteca.Models;

public class AutorLivro {
    public int CodAutor { get; set; }
    public Autor Autor { get; set; }

    public int CodLivro { get; set; }
    public Livro Livro { get; set; }
    
    public bool Principal { get; set; }
}