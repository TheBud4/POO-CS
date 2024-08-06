using Atividade_05.Models;

namespace Atividade_05;

public class Program {
    public static void Main() {
        Biblioteca biblioteca = new();

        Livro livro1 = new(1, "Dom Casmurro", "Machado de Assis");
        Livro livro2 = new(2, "O Senhor dos Anéis", "J. R. R. Tolkien");
        Livro livro3 = new(3, "Harry Potter", "J. K. Rowling");

        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);

        biblioteca.RemoverLivro(2);

        foreach (var livro in biblioteca.Livros) {
            Console.WriteLine($"Código: {livro.Codigo}");
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine();
        }
    }
}