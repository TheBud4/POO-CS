
/*
    Remoção de Números Ímpares em uma Matriz: 
    Crie uma matriz de números inteiros. 
    Permita que o usuário insira valores na matriz. 
    Após a inserção, remova todos os números ímpares da matriz e exiba a matriz atualizada.
 */

namespace Exercicio07 {
    public class Program {
        static void Main() {
            int[] numerosImpares = new int[5];
            int[] resultado = new int[5];
            Console.WriteLine("Preencha a matriz de dimensão 5 com numeros INTEIROS!");

            for (int i = 0; i < numerosImpares.Length; i++) {
                bool numValido = false;
                while (!numValido) {
                    string entrada = (Console.ReadLine());
                    if (!int.TryParse(entrada, out int valor) || valor < 0) {
                        Console.WriteLine("NÚMERO INVALIDO!!!");
                    } else {
                        numValido = true;
                        numerosImpares[i] = valor;
                    }
                }
            }

            Console.WriteLine("Valores informados:");

            for (int i = 0; i < numerosImpares.GetLength(0); i++) {
                Console.WriteLine($" valor {i + 1}: {numerosImpares[i]}");

            }
            for (int i = 0; i < numerosImpares[i]; i++) {
                if (numerosImpares[i] % 2 != 0) {
                    continue;
                } else {
                    resultado[i] = numerosImpares[i];
                }

            }
            Console.WriteLine("Valores Pares:");

            for (int i = 0; i < numerosImpares.GetLength(0); i++) {
                Console.WriteLine($" Numeros: {resultado[i]}");
            }
        }
    }
}