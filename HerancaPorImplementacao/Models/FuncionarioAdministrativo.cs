namespace HerancaPorImplementacao.Models;

public class FuncionarioAdministrativo : Pessoa {
    public string Departamento { get; private set; }
    public string Cargo { get; private set; }
    public decimal Salario { get; private set; }

    public FuncionarioAdministrativo(string nome, int idade, string cpf, string departamento, string cargo,
        decimal salario)
        : base(nome, idade, cpf) {
        Departamento = departamento;
        Cargo = cargo;
        Salario = salario;
    }

    public void RealizarTarefasAdministrativas() {
        Console.WriteLine($"{Nome} está realizando tarefas administrativas no departamento de {Departamento}.");
    }

    public override string ToString() {
        return base.ToString() + $", Departamento: {Departamento}, Cargo: {Cargo}, Salário: {Salario:C}";
    }
}