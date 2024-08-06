using Atividade_05.Models;

namespace Atividade_05;

class Program {
    static void Main(string[] args) {
        ContaCorrente contaCorrente = new ContaCorrente("1234", "Pedro", 1000, 500);
        contaCorrente.Depositar(200);
        contaCorrente.Sacar(1500);
        Console.WriteLine(contaCorrente);

        ContaPoupanca contaPoupanca = new ContaPoupanca("5678", "Marcos", 2000, 0.03m);
        contaPoupanca.AplicarJuros();
        contaPoupanca.Sacar(300);
        Console.WriteLine(contaPoupanca);

        ContaInvestimento contaInvestimento = new ContaInvestimento("9012", "Mateus", 5000, 0.05m);
        contaInvestimento.AplicarRetorno();
        contaInvestimento.Sacar(2000);
        Console.WriteLine(contaInvestimento);
    }
}