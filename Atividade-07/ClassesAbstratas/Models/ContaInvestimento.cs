namespace Atividade_05.Models;

public class ContaInvestimento : Conta {
    public decimal TaxaRetorno { get; private set; }

    public ContaInvestimento(string numero, string titular, decimal saldoInicial, decimal taxaRetorno)
        : base(numero, titular, saldoInicial) {
        TaxaRetorno = taxaRetorno;
    }

    public void AplicarRetorno() {
        Saldo += Saldo * TaxaRetorno;
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