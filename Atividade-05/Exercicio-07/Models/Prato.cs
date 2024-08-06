namespace Exercicio_07.Models;

public class Prato(string nome, string ingredientes) {
    public string Nome { get; } = nome;
    public string Ingredientes { get; } = ingredientes;
}