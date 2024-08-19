namespace ApiBiblioteca.Models;

public class AutorLivro {
    public int AutorId { get; set; }
    public Autor Autor { get; set; }

    public int LivroId { get; set; }
    public Livro Livro { get; set; }
}