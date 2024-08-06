namespace Exercicio_02.Models;

public class Funcionario(string nome, string cargo) {
    public string Nome { get; set; } = nome;
    public string Cargo { get; set; } = cargo;
}