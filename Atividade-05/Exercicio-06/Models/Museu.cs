namespace Exercicio_06.Models;

public class Museu {
    public List<Obra> obras { get; } = new();

    public void AdicionarObra(Obra obra) {
        obras.Add(obra);
        Console.WriteLine($"Obra {obra.Titulo} adicionada com sucesso.");
    }

    public void RemoverObra(string titulo) {
        obras.RemoveAll(o => o.Titulo == titulo);
    }
}