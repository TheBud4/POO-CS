
/*
    Soma de Números em uma Matriz: 
    Crie uma matriz de números inteiros. Permita que o usuário insira valores na matriz.
    Após a inserção, exiba a soma de todos os números na matriz.
*/

namespace Exercicio_05 {

    public class Program {
        static void Main() {

            int[] numeros = new int[5];
            int soma = 0;
            Console.WriteLine("Insira os numeros na matriz!");

            for (int i = 0; i < numeros.Length; i++) {
                bool numeroValido = false;
                while (!numeroValido) {
                    string entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out int numero)) {
                        Console.WriteLine("Por favor, digite um número inteiro válido.");
                    } else {
                        numeroValido = true;
                        numeros[i] = numero;
                    }

                }
            }
            for (int i = 0;i < numeros.Length;i++) {
                soma += numeros[i];
            }
           Console.WriteLine("A soma dos numeros é: " + soma);

        }
    }
}