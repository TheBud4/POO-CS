using Exercicio_07.Models;

namespace Exercicio_07;

class Program {
    static void Main(string[] args) {
        Restaurante restaurante = new();

        Prato p1 = new("Feijoada",
            "Feijão, carne seca, linguiça, bacon, costela, paio, lombo, pé de porco, orelha de porco, rabo de porco, cebola, alho, louro, sal, pimenta, cominho, azeite, farinha de mandioca, couve, laranja, arroz, torresmo, vinagrete");
        Prato p2 = new("Macarronada",
            "Macarrão, molho de tomate, carne moída, cebola, alho, sal, pimenta, azeite, queijo ralado");
        Prato p3 = new("Lasanha",
            "Massa de lasanha, molho de tomate, carne moída, cebola, alho, sal, pimenta, azeite, queijo ralado, presunto, queijo mussarela");

        restaurante.AdicionarPrato(p1);
        restaurante.AdicionarPrato(p2);
        restaurante.AdicionarPrato(p3);

        foreach (var prato in restaurante.Pratos) {
            Console.WriteLine($"Nome: {prato.Nome}\n" +
                              $"Ingredientes: {prato.Ingredientes}");
        }

        restaurante.RemoverPrato("Macarronada");

        foreach (var prato in restaurante.Pratos) {
            Console.WriteLine($"Nome: {prato.Nome}\n" +
                              $"Ingredientes: {prato.Ingredientes}");
        }
    }
}