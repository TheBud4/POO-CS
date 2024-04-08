
using Exercicio_01.Entities;

namespace Exercicio_01;

public class Program {
    static void Main() {
        List<ContaBancaria> contas = new List<ContaBancaria>();

        Console.WriteLine("Bem vindo ao sistema!");
        Thread.Sleep(2000);

        while (true) {
            int opcao;
            ContaBancaria conta = new ContaBancaria();

            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Cadastrar uma conta bancária");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Transferir");
            Console.WriteLine("5 - Pesquisar Conta ");
            Console.WriteLine("6 - Sair");
            try {
                opcao = int.Parse(Console.ReadLine());

            } catch (FormatException) {
                Console.WriteLine("Formato inválido. Por favor, insira um valor válido.");
                continue;
            }

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

                            Console.WriteLine("Digite o número da casa titular da conta:");
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
                    Thread.Sleep(2000);

                    break;
                case 2:
                    // Depositar

                    while (true) {
                        try {
                            Console.WriteLine("Digite o nome do titular da conta:");
                            string input = Console.ReadLine();
                            Console.WriteLine("Digite o valor a ser depositado:");
                            float valorDeposito = float.Parse(Console.ReadLine());

                            ContaBancaria contaModificar = contas.Find(c => c.Titular.Nome == input);
                            if (contaModificar != null) {
                                contaModificar.Depositar(valorDeposito);
                                Console.WriteLine("Depósito realizado com sucesso!");
                                Console.WriteLine("Saldo atual: " + contaModificar.Saldo);
                            } else {
                                Console.WriteLine("Conta não encontrada.");
                            }

                            break;
                        } catch (ArgumentException e) {
                            Console.WriteLine(e.Message);
                        } catch (FormatException) {
                            Console.WriteLine("Formato inválido. Por favor, insira um valor válido.");
                        }
                    }
                    Thread.Sleep(2000);

                    break;
                case 3:
                    // Sacar
                    while (true) {
                        try {

                            Console.WriteLine("Digite o número da conta:");
                            string input = Console.ReadLine();
                            Console.WriteLine("Digite o valor a ser sacado:");
                            float valorSaque = float.Parse(Console.ReadLine());
                            ContaBancaria contaModificar = contas.Find(c => c.Titular.Nome == input);

                            contaModificar.Sacar(valorSaque);

                            break;
                        } catch (FormatException) {
                            Console.WriteLine("Formato inválido. Por favor, insira um valor válido.");
                        }
                    }
                    Console.WriteLine("Saque realizado com sucesso!");
                    Console.WriteLine("Saldo atual: " + conta.Saldo);
                    Thread.Sleep(2000);

                    break;
                case 4:
                    // Transferir
                    Console.WriteLine("Digite o nome do titular da conta de origem:");
                    string numeroContaOrigem = Console.ReadLine();
                    ContaBancaria contaOrigem = contas.Find(c => c.Titular.Nome == numeroContaOrigem);

                    Console.WriteLine("Digite o nome do titular da conta de destino:");
                    string numeroContaDestino = Console.ReadLine();
                    ContaBancaria contaDestino = contas.Find(c => c.Titular.Nome == numeroContaDestino);

                    Console.WriteLine("Digite o valor a ser transferido:");
                    float valorTransferencia = float.Parse(Console.ReadLine());

                    contaOrigem.Transferir(valorTransferencia, contaDestino);

                    break;
                case 5:
                    // Pesquisar Conta
                    Console.WriteLine("Digite o nome do titular da conta:");

                    string nomePesquisa = Console.ReadLine();

                    ContaBancaria contaEncontrada = contas.Find(c => c.Titular.Nome == nomePesquisa);

                    if (contaEncontrada != null) {
                        Console.WriteLine("Titular: " + contaEncontrada.Titular.Nome);
                        Console.WriteLine("Email do Titular: " + contaEncontrada.Titular.Email);
                        Console.WriteLine("Data de Nascimento: " + contaEncontrada.Titular.Nascimento);
                        Console.WriteLine("Numero da conta: " + contaEncontrada.NumeroConta);
                        Console.WriteLine("Saldo: " + contaEncontrada.Saldo);
                        Console.WriteLine("Titular: " + contaEncontrada.Titular.Telefone);
                        Console.WriteLine("Endereço do titular: ");
                        Console.WriteLine("CEP: " + contaEncontrada.Titular.Endereco.Cep);
                        Console.WriteLine("Bairro: " + contaEncontrada.Titular.Endereco.Bairro);
                        Console.WriteLine("Rua: " + contaEncontrada.Titular.Endereco.Logradouro);
                        Console.WriteLine("Numero da Casa: " + contaEncontrada.Titular.Endereco.NumeroCasa);
                    } else {
                        Console.WriteLine("Conta não encontrada.");
                    }

                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
            Console.WriteLine("Obrigado por utilizar o sistema!");
            Thread.Sleep(2000);

            if (opcao == 6) {
                break;
            }
        }
    }
}

