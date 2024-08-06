namespace HerancaPorImplementacao.Models;

public class Professor : Pessoa, IAtividadeEscolar {
    public string Disciplina { get; private set; }
    public decimal Salario { get; private set; }

    public Professor(string nome, int idade, string cpf, string disciplina, decimal salario)
        : base(nome, idade, cpf) {
        Disciplina = disciplina;
        Salario = salario;
    }

    public void ExecutarAtividade() {
        Console.WriteLine($"{Nome} está dando aulas de {Disciplina}.");
    }

    public override string ToString() {
        return base.ToString() + $" Disciplina: {Disciplina}\n Salário: {Salario:C}\n";
    }
}