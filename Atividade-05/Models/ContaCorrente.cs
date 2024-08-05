namespace Atividade_05.Models;

public class ContaCorrente(string titular, string agencia, int numero, double limite)
    : Conta(titular, agencia, numero) {
    public double Limite { get; set; } = limite;

    // ToDO: Refatorar metodos para levar em conta o limite
    public void IncrementarLimite(double valor) {
        Limite += valor;
    }
    public void DecrementarLimite(double valor) {
        Limite -= valor;
    }
    public override void Sacar(double valor) {
        if (valor > Saldo + Limite) {
            throw new Exception("Saldo insuficiente");
        }
        Saldo -= valor;
    }
    public override void Transferir(double valor, Conta contaDestino) {
        if (valor > Saldo + Limite) {
            throw new Exception("Saldo insuficiente");
        }
        Saldo -= valor;
        contaDestino.Depositar(valor);
    }
    public override string Extrato(Conta conta) {
        return base.Extrato(conta) + $"\nLimite: {Limite}";
    }
}