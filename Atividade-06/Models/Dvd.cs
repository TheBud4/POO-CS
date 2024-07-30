namespace Atividade_06.Models;

public class Dvd : Item{
    public int Duracao { get; set; }
    
    public Dvd(string autor , string titulo, int duracao,DateTime lancamento) : base(autor, titulo,lancamento) {
        Duracao = duracao;
    }

    public override void Descricao() {
        Console.WriteLine( $"Nome: {Nome}, Titulo: {Titulo}, Publicacao: {Publicacao}, Duracao: {Duracao}");
    }
}