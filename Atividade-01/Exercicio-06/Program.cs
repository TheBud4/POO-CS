
namespace Exercicio_06 {
    public class Program {
        static void Main() {
            List<int> numerosPositivos = new List<int>();

            Console.WriteLine("Digite os números para leitura, digite um número negativo para encerrar:");
            while (true) {
                string? entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out int numero)) {
                    Console.WriteLine("Por favor, digite um número inteiro válido.");
                    continue;
                }
                if (numero < 0) {
                    break;
                }
                numerosPositivos.Add(numero);
            }
            Console.WriteLine("Números positivos digitados:");
            foreach (var num in numerosPositivos) {
                Console.WriteLine(num);
            }
        }
    }
}
