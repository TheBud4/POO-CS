namespace Atividade_05.Models;

public class Biblioteca {
    public List<Livro> Livros { get; }

    public Biblioteca() {
        Livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro) {
        Livros.Add(livro);
    }

    public void RemoverLivro(int codigo) {
        Livros.RemoveAll(livro => livro.Codigo == codigo);
    }
}