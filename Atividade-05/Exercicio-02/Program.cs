using Exercicio_02.Models;

namespace Exercicio_02;

class Program {
    static void Main() {
        Empresa empresa = new();
        Funcionario funcionario1 = new("João", "Desenvolvedor");
        Funcionario funcionario2 = new("Maria", "Analista de Sistemas");
        Funcionario funcionario3 = new("José", "Gerente de Projetos");

        empresa.ContratarFuncionario(funcionario1);
        empresa.ContratarFuncionario(funcionario2);
        empresa.ContratarFuncionario(funcionario3);

        empresa.DemitirFuncionario(funcionario2);

        foreach (Funcionario funcionario in empresa.Funcionarios) {
            Console.WriteLine($"Nome: {funcionario.Nome}\n" +
                              $" Cargo: {funcionario.Cargo}");
        }
    }
}