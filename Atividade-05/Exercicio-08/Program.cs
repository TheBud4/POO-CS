using Exercicio_08.Models;

namespace Exercicio_08;

class Program {
    static void Main(string[] args) {
        Aeroporto aeroporto = new();

        aeroporto.AdicionarVoo(new Voo(1, "São Paulo"));
        aeroporto.AdicionarVoo(new Voo(2, "Rio de Janeiro"));
        aeroporto.AdicionarVoo(new Voo(3, "Belo Horizonte"));

        foreach (var voo in aeroporto.Voos) {
            Console.WriteLine($"Número: {voo.Numero}\n" +
                              $"Destino: {voo.Destino}");
        }

        aeroporto.RemoverVoo(2);

        foreach (var voo in aeroporto.Voos) {
            Console.WriteLine($"Número: {voo.Numero}\n" +
                              $"Destino: {voo.Destino}");
        }
    }
}