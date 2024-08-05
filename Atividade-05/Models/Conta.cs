namespace Atividade_05.Models;

public interface IConta {
    public double Saldo { get; set; }
    public string Titular { get; set; }
    public string Agencia { get; set; }
    public int Numero { get; set; }
    public void Depositar(double valor);
    public void Sacar(double valor);
    public void Transferir(double valor, Conta contaDestino);
}
public class Conta(string titular, string agencia, int numero) : IConta {
    public double Saldo { get; set; }
    public string Titular { get; set; } = titular;
    public string Agencia { get; set; } = agencia;
    public int Numero { get; set; } = numero;
    
    public virtual void Depositar(double valor) {
        Saldo += valor;
    }
    public virtual void Sacar(double valor) {
        Saldo -= valor;
    }
    public virtual void Transferir(double valor, Conta contaDestino) {
        Sacar(valor);
        contaDestino.Depositar(valor);
    }
    public virtual string Extrato(Conta conta) {
        return $"" +
               $"Titular: {Titular}\n" +
               $"Agência: {Agencia}\n" +
               $"Número: {Numero}\n" +
               $"Saldo: {Saldo}";
    }
}