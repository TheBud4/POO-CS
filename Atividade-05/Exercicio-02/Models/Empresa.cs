namespace Exercicio_02.Models;

public class Empresa {
    public List<Funcionario> Funcionarios { get; } = new();

    public void ContratarFuncionario(Funcionario funcionario) {
        Funcionarios.Add(funcionario);
    }

    public void DemitirFuncionario(Funcionario funcionario) {
        Funcionarios.Remove(funcionario);
    }
}