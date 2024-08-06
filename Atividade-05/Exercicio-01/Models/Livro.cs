namespace Atividade_05.Models;

public class Livro(int codigo, string titulo, string autor) {
    public int Codigo { get; } = codigo;
    public string Titulo { get; } = titulo;
    public string Autor { get; } = autor;
}