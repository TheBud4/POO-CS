namespace Exercito_04.Models;

public class Loja {
    public List<Produto> produtos = new();

    public void AdicionarProduto(Produto produto) {
        produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado com sucesso.");
    }

    public void RemoverProduto(string nome) {
        produtos.RemoveAll(p => p.Nome == nome);
    }
}