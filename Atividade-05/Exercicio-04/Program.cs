using Exercito_04.Models;

namespace Exercito_04;

class Program {
    static void Main() {
        Loja loja = new();
        Produto p1 = new("Camiseta", 50.0);
        Produto p2 = new("Calça", 100.0);
        Produto p3 = new("Tênis", 200.0);

        loja.AdicionarProduto(p1);
        loja.AdicionarProduto(p2);
        loja.AdicionarProduto(p3);

        foreach (var produto in loja.produtos) {
            Console.WriteLine($"Nome: {produto.Nome}\n" +
                              $"Matrícula: {produto.Preco}");
        }

        loja.RemoverProduto("Calça");

        foreach (var produto in loja.produtos) {
            Console.WriteLine($"Nome: {produto.Nome}\n" +
                              $"Matrícula: {produto.Preco}");
        }
    }
}