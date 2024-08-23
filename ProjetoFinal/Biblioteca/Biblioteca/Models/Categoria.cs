namespace Biblioteca.Models;

public class Categoria {
    public int Id { get; set; }
    public string Descricao { get; set; }

    public List<Livro> Livros { get; set; }
}