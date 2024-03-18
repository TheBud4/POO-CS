
/*
    Primeira e Última Fruta na Matriz:
    Crie uma matriz para armazenar nomes de frutas.
    Permita que o usuário insira os nomes das frutas na matriz. Após a inserção,
    informe qual é a primeira e a última fruta na matriz.
*/

namespace Exercicio_10 {

    public class Program {
        static void Main() {

            string[] nomeFrutas = new string[5];
            Console.WriteLine("Digite as Frutas");
            for (int i = 0; i < nomeFrutas.Length; i++) {
                string entrada = Console.ReadLine();

                if (entrada.All(char.IsAsciiDigit)) {
                    Console.WriteLine("Erro: A entrada não pode ser numero. Tente Novamente");
                    i--;
                    continue;
                }
                nomeFrutas[i] = entrada;
            }
        foreach(string fruta  in nomeFrutas) {
                Console.WriteLine(fruta);
            }
            Console.WriteLine("Primeira: " + nomeFrutas.First());
            Console.WriteLine("Ultima: " + nomeFrutas.Last());
        }
    }
}