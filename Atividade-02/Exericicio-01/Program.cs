/*
 *Contagem de Números Pares em uma Matriz: 
 *Crie uma matriz de números inteiros. 
 *Permita que o usuário insira valores na matriz. 
 *Após a inserção, exiba a matriz completa e informe quantos números pares existem nela.
 */

namespace Exercicio_01 {
    public class Program {
        static void Main() {
            int[] numeros = new int[5];
            int pares = 0;
            
            Console.WriteLine("Insira os numeros na matriz!");

            for (int i = 0; i < numeros.Length; i++) {
                bool numeroValido = false;
                while (!numeroValido) {
                    string entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out int numero) || numero < 0) {
                        Console.WriteLine("Por favor, digite um número inteiro válido.");
                    } else {
                        numeroValido = true;
                        numeros[i] = numero;
                    }

                }
            }
            Console.WriteLine("Valores informados:");
            for(int i = 0;i < numeros.Length; i++) {
                if (numeros[i]%2 == 0) {
                    pares++;
                }

                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine($"Existem {pares} numeros pares nessa matriz! ");

        }
    }
}
