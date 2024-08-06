namespace Atividade_05.Models;

public class ContaCorrente : Conta {
    public decimal LimiteChequeEspecial { get; private set; }

    public ContaCorrente(string numero, string titular, decimal saldoInicial, decimal limiteChequeEspecial)
        : base(numero, titular, saldoInicial) {
        LimiteChequeEspecial = limiteChequeEspecial;
    }

    public override void Sacar(decimal valor) {
        if (Saldo + LimiteChequeEspecial >= valor) {
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