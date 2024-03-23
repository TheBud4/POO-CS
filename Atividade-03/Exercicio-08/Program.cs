
/*
    Crie uma classe chamada "Funcionario" que contenha as propriedades "Nome", "Salario" e "HorasTrabalhadas". 
    Adicione um método chamado "CalcularSalarioTotal" que calcule e retorne o salário total do funcionário 
    (salário multiplicado pelas horas trabalhadas). 
*/

namespace Exercicio_08;

public class Program() {
    static void Main() {

        Funcionario funcionario = new Funcionario() {
            Nome = "Murilo",
            HorasTrabalhadas = 40,
            Salario = 15,
        };
        Console.WriteLine(funcionario.CalcularSalarioTotal());

    }
}