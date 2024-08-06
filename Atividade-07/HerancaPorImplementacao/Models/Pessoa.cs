namespace HerancaPorImplementacao.Models;

public abstract class Pessoa {
    public string Nome { get; protected set; }
    public int Idade { get; protected set; }
    public string CPF { get; protected set; }

    public Pessoa(string nome, int idade, string cpf) {
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }

    public override string ToString() {
        return $"Nome: {Nome}\n" +
               $" Idade: {Idade}\n " +
               $"CPF: {CPF}\n";
    }
}