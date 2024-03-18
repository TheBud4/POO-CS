/*
    Ordenação Alfabética de Frutas: 
    Crie uma matriz para armazenar nomes de frutas.
    Permita que o usuário insira os nomes das frutas na matriz.
    Após a inserção, exiba a matriz completa em ordem alfabética. 
*/

namespace Exercicio_03 {
    public class Program {
        static void Main() {
            string[] frutas = new string[5];
            Console.WriteLine("Insira as frutas na matriz!");
            for (int i = 0; i < frutas.Length; i++) {
                string entrada = Console.ReadLine();
                frutas[i] = entrada;
            } 
            Array.Sort(frutas);

            Console.WriteLine("Aqui estao suas frutas em ordem alfabetica!");
            
            for (int i = 0; i < frutas.Length; i++) {
                Console.WriteLine(frutas[i]);
            }

        }
    }
}
