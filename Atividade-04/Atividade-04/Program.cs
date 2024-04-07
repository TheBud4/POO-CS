/*
Como parte do desenvolvimento de um sistema bancário em C#, você é encarregado(a) de projetar uma arquitetura de classes que garanta segurança e privacidade dos dados dos clientes. Para isso, você deve criar as seguintes classes associativas:

Cliente: Representa um cliente do banco e contém informações como nome, endereço e e-mail. Além disso, inclui métodos para atualizar detalhes do cliente, como endereço ou número de telefone.

Métodos associados:

AtualizarEndereco(string novoEndereco): Atualiza o endereço do cliente para o novo endereço fornecido. (Pense no Endereço com uma classe também)
Conta Bancária: Representa uma conta bancária, contendo informações como número da conta, saldo e titular da conta (um objeto Cliente). Métodos associados incluem operações como depósito, saque e transferência.

Métodos associados:

Depositar(decimal valor): Adiciona o valor especificado ao saldo da conta.
Sacar(decimal valor): Retira o valor especificado do saldo da conta, se houver saldo suficiente.
Transferir(decimal valor, ContaBancaria contaDestino): Transfere o valor especificado da conta atual para a conta destino fornecida.
Pense nesses métodos com transações que precisem ficar registradas.
*/

using Exercicio_01.Entities;

namespace Exercicio_01;

public class Program {
    static void Main() {
        List<ContaBancaria> contas = new List<ContaBancaria>();
        while (true) {
            int opcao;
            ContaBancaria conta = new ContaBancaria();
            DateTime nascimento;

            Console.WriteLine("Bem vindo ao sistema!");
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Cadastrar uma conta bancária");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Transferir");
            Console.WriteLine("5 - Pesquisar Conta ");
            Console.WriteLine("6 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:

                    int numeroTitular;
                    string nomeTitular, emailTitular, cepTitular, bairroTitular, logradouroTitular;
                    DateTime nascimentoTitular;
                    conta.Titular = new Cliente();

                    while (true) {
                        try {
                            Random random = new Random();
                            conta.NumeroConta = random.Next(1000, 9999);
                            conta.Saldo = 0.0f;

                            Console.WriteLine("Digite o nome do titular da conta:");
                            nomeTitular = Console.ReadLine();
                            conta.Titular.Nome = nomeTitular;

                            Console.WriteLine("Digite o email do titular da conta:");
                            emailTitular = Console.ReadLine();
                            conta.Titular.Email = emailTitular;

                            Console.WriteLine("Digite a data de nascimento do titular da conta(dd/MM/aa):");
                            nascimentoTitular = DateTime.Parse(Console.ReadLine());
                            conta.Titular.Nascimento = nascimentoTitular;

                            Console.WriteLine("Digite o CEP do titular da conta:");
                            cepTitular = Console.ReadLine();

                            Console.WriteLine("Digite o bairro do titular da conta:");
                            bairroTitular = Console.ReadLine();

                            Console.WriteLine("Digite o logradouro do titular da conta:");
                            logradouroTitular = Console.ReadLine();

                            Console.WriteLine("Digite o número do titular da conta:");
                            numeroTitular = int.Parse(Console.ReadLine());

                            conta.Titular.AtualizarEndereco(cepTitular, bairroTitular, logradouroTitular, numeroTitular);
                            contas.Add(conta);
                            break;
                        } catch (ArgumentException e) {
                            Console.WriteLine(e.Message);
                        } catch (FormatException) {
                            Console.WriteLine("Formato inválido. Por favor, insira um valor válido.");
                        }
                    }
                    Console.WriteLine("Conta cadastrada com sucesso!");
                    Console.WriteLine("Número da conta: " + conta.NumeroConta);
                    Console.WriteLine("Titular: " + conta.Titular.Nome);
                    Console.WriteLine("Saldo atual: " + conta.Saldo);
                    break;
                case 2:
                    while (true) {
                        try {
                            Console.WriteLine("Digite o número da conta:");
                            int numeroConta = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor a ser depositado:");
                            float valorDeposito = float.Parse(Console.ReadLine());
                            contas[numeroConta].Depositar(valorDeposito);
                            break;
                        } catch (ArgumentException e) {
                            Console.WriteLine(e.Message);
                        } catch (FormatException) {
                            Console.WriteLine("Formato inválido. Por favor, insira um valor válido.");
                        }
                    }
                    Console.WriteLine("Depósito realizado com sucesso!");
                    Console.WriteLine("Saldo atual: " + conta.Saldo);
                    break;
                case 3:
                    while (true) {
                        try {

                            Console.WriteLine("Digite o número da conta:");
                            int numeroContaSaque = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor a ser sacado:");
                            float valorSaque = float.Parse(Console.ReadLine());
                            contas[numeroContaSaque].Sacar(valorSaque);

                            break;
                        } catch (FormatException) {
                            Console.WriteLine("Formato inválido. Por favor, insira um valor válido.");
                        }
                    }
                    Console.WriteLine("Saque realizado com sucesso!");
                    Console.WriteLine("Saldo atual: " + conta.Saldo);
                    break;
                case 4:
                    Console.WriteLine("Digite o número da conta de origem:");
                    int numeroContaOrigem = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o número da conta de destino:");
                    int numeroContaDestino = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor a ser transferido:");
                    float valorTransferencia = float.Parse(Console.ReadLine());

                    break;
                case 5:

                    foreach (ContaBancaria c in contas) {
                        Console.WriteLine(c);
                    }
                    /*Console.WriteLine("Digite o nome do titular da conta:");
                    string nomePesquisa = Console.ReadLine();

                    ContaBancaria contaEncontrada = contas.Find(c => c.Titular.Nome == nomePesquisa);

                    if (contaEncontrada != null) {
                        Console.WriteLine(contaEncontrada);
                    } else {
                        Console.WriteLine("Conta não encontrada.");
                    }
                    */
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
            Console.WriteLine("Obrigado por utilizar o sistema!");
            if (opcao == 6) {
                break;
            }
        }
    }
}

