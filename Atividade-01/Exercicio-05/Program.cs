namespace Exercicio_05;

public class Program {
    static void Main() {
        int resposta = 1;
        Console.WriteLine("Insira um numero para o fatorial");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero) || numero < 0) {
            Console.WriteLine("Por favor, digite um número inteiro não negativo válido.");
        }

        for (int i = 1; i <= numero; i++) {
            resposta *= i;
        }

        Console.WriteLine($"O fatorial de {numero} é {resposta}.");

    }
}
