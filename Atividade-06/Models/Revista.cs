namespace Atividade_06.Models;

public class Revista: Item{
    
    public string Edicao { get; set; }
    public int Issn { get; set; }

    public Revista(string titulo, string edicao, int issn,DateTime publicacao) : base(null, titulo,publicacao) {
        Edicao = edicao;
        Issn = issn;
    }

    public override void Descricao() {
        Console.WriteLine( $"Nome: {Nome}, Titulo: {Titulo}, Publicacao: {Publicacao}, Edicao: {Edicao}, Issn: {Issn}");

    }
}