namespace PolimorfismoDois {
    internal class Program {
        static void Main() {
            ContaCorrente conta = new("dois","Ana", 1000, 500);
            conta.Depositar(1000);
            conta.Sacar(100);
            conta.ExibirSaldo();
            ContaPoupanca contaPoupanca = new("um", "João", 1000, 0.01m);
            contaPoupanca.Depositar(1000);
            contaPoupanca.Sacar(100);
            contaPoupanca.AplicarRendimento();
            contaPoupanca.ExibirSaldo();
        }
    }
}