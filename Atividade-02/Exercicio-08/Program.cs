
/*
    Contagem de Países com Mais de 10 Letras:
    Crie uma matriz para armazenar nomes de países.
    Permita que o usuário insira os nomes dos países na matriz.
    Após a inserção, informe quantos países têm mais de 10 letras em seu nome.  
*/

namespace Exercicio_08 {
    public class Program {
        static void Main() {
            string[] nomePaises = new string[5];

            for (int i = 0; i < nomePaises.Length; i++) {
                Console.WriteLine("Insira nome dos paises");
                string paises = Console.ReadLine();

                if (paises.All(char.IsAsciiDigit)) {
                    Console.WriteLine("Erro: A entrada não pode ser numero. Tente Novamente");
                    i--;
                    continue;
                }

                if (nomePaises.Contains(paises)) {
                    Console.WriteLine("Esse pais já foi inserido. Digite outro");
                    i--;
                    continue;
                }
                nomePaises[i] = paises;
            }
            int contador = 0;
            foreach (string pais in nomePaises) {
                if (!string.IsNullOrEmpty(pais) && pais.Length > 10) {
                    contador++;
                }
            }
            Console.WriteLine($"Número de países com mais de 10 letras em seu nome: {contador}");
        }
    }
}