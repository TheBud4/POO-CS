namespace Atividade_05.Models;

public abstract class Conta {
    public string Numero { get; protected set; }
    public string Titular { get; protected set; }
    public decimal Saldo { get; protected set; }

    public Conta(string numero, string titular, decimal saldoInicial) {
        Numero = numero;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public abstract void Sacar(decimal valor);
    public abstract void Depositar(decimal valor);

    public override string ToString() {
        return $"{Titular} - {Numero}: Saldo: {Saldo:C}";
    }
}