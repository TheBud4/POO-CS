namespace Exercicio_10.Models;

public class Paciente(string nome, string doenca) {
    public string Nome { get; set; } = nome;
    public string Doenca { get; set; } = doenca;
}