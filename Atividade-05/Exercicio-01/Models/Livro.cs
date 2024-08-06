namespace Atividade_05.Models;

public class Livro {
    public int Codigo { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Livro(int codigo, string titulo, string autor) {
        Codigo = codigo;
        Titulo = titulo;
        Autor = autor;
    }
}