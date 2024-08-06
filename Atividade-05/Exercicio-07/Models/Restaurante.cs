namespace Exercicio_07.Models;

public class Restaurante {
    public List<Prato> Pratos { get; } = new();

    public void AdicionarPrato(Prato prato) {
        Pratos.Add(prato);
        Console.WriteLine($"Prato {prato.Nome} adicionado com sucesso.");
    }

    public void RemoverPrato(string nome) {
        Pratos.RemoveAll(p => p.Nome == nome);
    }
}