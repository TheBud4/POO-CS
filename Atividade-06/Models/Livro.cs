namespace Atividade_06.Models;

public class Livro: Item{
    public int Isbn { get; set; }
    public int Paginas { get; set; }

    public Livro(string autor,string titulo, int isbn, int paginas,DateTime publicacao) : base(autor, titulo, publicacao) {
        Isbn = isbn;
        Paginas = paginas;
    }

    public override void Descricao() {
        Console.WriteLine( $"Nome: {Nome}, Titulo: {Titulo}, Publicacao: {Publicacao}, Isbn: {Isbn}, Paginas: {Paginas}");
    }
}