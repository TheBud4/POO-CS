namespace Exercicio_09.Models;

public class Teatro {
    public List<Peca> pecas = new();

    public void AdicionarPeca(Peca peca) {
        pecas.Add(peca);
        Console.WriteLine($"Peça {peca.Titulo} adicionada com sucesso.");
    }

    public void RemoverPeca(string titulo) {
        pecas.RemoveAll(p => p.Titulo == titulo);
    }
}