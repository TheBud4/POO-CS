using Atividade_05.Models;

namespace Atividade_05;
public static class Program { 
    public static void Main() {
        ContaCorrente conta = new("Murilo", "1234", 1234, 1000);
        conta.Depositar(1000);
        conta.Sacar(500);
        Console.WriteLine(conta.Extrato(conta));
    }
}

