using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoDois {
    public class ContaPoupanca(string numeroDaConta, string titular, decimal saldoInicial, decimal taxaJuros)
        : ContaBancaria(numeroDaConta, titular, saldoInicial) {
        public decimal TaxaJuros { get; set; } = taxaJuros;

        public void AplicarRendimento() {
            decimal rendimento = Saldo * TaxaJuros;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de {rendimento} aplicado na conta {NumeroDaConta}.");
        }

        public override void Sacar(decimal valor) {
            if (Saldo >= valor) {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso na conta {NumeroDaConta}.");
            }
            else {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }

        public override void Depositar(decimal valor) {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso na conta {NumeroDaConta}.");
        }
    }
}