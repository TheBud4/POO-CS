namespace Atividade_05.Models;

public class ContaPoupanca : Conta {
    public decimal TaxaJuros { get; private set; }

    public ContaPoupanca(string numero, string titular, decimal saldoInicial, decimal taxaJuros)
        : base(numero, titular, saldoInicial) {
        TaxaJuros = taxaJuros;
    }

    public void AplicarJuros() {
        Saldo += Saldo * TaxaJuros;
    }

    public override void Sacar(decimal valor) {
        if (Saldo >= valor) {
            Saldo -= valor;
        }
        else {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public override void Depositar(decimal valor) {
        Saldo += valor;
    }
}