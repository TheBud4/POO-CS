namespace Exercicio_08.Models;

public class Aeroporto {
    public List<Voo> Voos { get; } = new();

    public void AdicionarVoo(Voo voo) {
        Voos.Add(voo);
        Console.WriteLine($"Voo {voo.Numero} adicionado com sucesso.");
    }

    public void RemoverVoo(int numero) {
        Voos.RemoveAll(v => v.Numero == numero);
    }
}