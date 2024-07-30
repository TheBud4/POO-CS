namespace Atividade_06.Models;

public class Item(string nome, string titulo, DateTime publicacao) {
    public string Nome { get; set; }
    public string Titulo { get; set; }
    public DateTime Publicacao { get; set; }
    
    public virtual void Descricao() {
        Console.WriteLine( $"Nome: {Nome}, Titulo: {Titulo}, Publicacao: {Publicacao}");
    }
}