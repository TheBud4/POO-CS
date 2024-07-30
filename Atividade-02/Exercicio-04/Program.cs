
/*
    Ordenação Alfabética Reversa de Países:
    Crie uma matriz para armazenar nomes de países.
    Permita que o usuário insira os nomes dos países na matriz.
    Após a inserção, exiba a matriz completa em ordem alfabética reversa.
*/

namespace Exercicio_04 {

    public class Program {
        static void Main() {
            string[] nomePaises = new string[5];

            for (int i = 0; i < nomePaises.Length; i++) {
                Console.WriteLine("Insira nome dos paises");
                string entrada = Console.ReadLine();

                if (entrada.All(char.IsAsciiDigit)) {
                    Console.WriteLine("Erro: A entrada não pode ser numero. Tente Novamente");
                    i--;
                    continue;
                }
                nomePaises[i] = entrada;
            }

            Array.Sort(nomePaises);
            Array.Reverse(nomePaises);
            Console.WriteLine("Listagem dos países diditados em ordem alfabética invertida");
            foreach (string pais in nomePaises) {
                if (!string.IsNullOrEmpty(pais)) {
                    Console.WriteLine(pais);
                }
            }
        }
    }
}