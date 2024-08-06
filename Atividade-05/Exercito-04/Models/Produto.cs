namespace Exercito_04.Models;

public class Produto(string nome, double preco) {
    public string Nome { get; set; } = nome;
    public double Preco { get; set; } = preco;
}