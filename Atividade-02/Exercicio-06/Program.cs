
/*
    Remoção de Cidades com a Letra 'S': 
    Crie uma matriz para armazenar nomes de cidades.
    Permita que o usuário insira os nomes das cidades na matriz.
    Após a inserção, remova todas as cidades que começam com a letra "S" e exiba a matriz atualizada.
 */


namespace Exercicio_06 {

    public class Program {
        static void Main() {
            string[] nomeCidades = new string[5];

            for (int i = 0; i < nomeCidades.Length; i++) {
            Console.WriteLine("Insira nome da cidade " + i + 1);
                string entrada = Console.ReadLine();

                if (entrada.All(char.IsAsciiDigit)) {
                    Console.WriteLine("Erro: A entrada não pode ser numero. Tente Novamente");
                    i--;
                    continue;
                }
                if (entrada.StartsWith("S") || entrada.StartsWith("s")) {
                    entrada = null;
                }
                nomeCidades[i] = entrada;
            }

            foreach (string str in nomeCidades) { 
                Console.WriteLine(str); 
            }
        }
    }
}