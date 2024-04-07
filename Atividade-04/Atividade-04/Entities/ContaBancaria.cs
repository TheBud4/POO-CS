
namespace Exercicio_01.Entities;

public class ContaBancaria {

    private int _numeroConta;
    private float _saldo;
    private Cliente _titular;

    public int NumeroConta {
        get {
            return _numeroConta;
        }
        set {
            _numeroConta = value;
        }
    }
    public float Saldo { get; set; }
    public Cliente Titular { get; set; }

    public void Depositar(float valor) {
        if (valor <= 0) {
            throw new ArgumentException("O valor a ser depositado deve ser maior que zero.");
        }

        Saldo += valor;
    }

    public void Sacar(float valor) {
        if (valor <= 0) {
            throw new ArgumentException("O valor a ser sacado deve ser maior que zero.");
        }

        if (valor > Saldo) {
            throw new ArgumentException("Saldo insuficiente.");
        }

        Saldo -= valor;
    }

    public void Transferir(float valor, ContaBancaria contaDestino) {
        if (valor <= 0) {
            throw new ArgumentException("O valor a ser transferido deve ser maior que zero.");
        }

        if (valor > Saldo) {
            throw new ArgumentException("Saldo insuficiente.");
        }

        Saldo -= valor;
        contaDestino.Depositar(valor);
    }

}
