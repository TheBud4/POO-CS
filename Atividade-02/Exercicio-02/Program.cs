/*
    Contagem de Animais com a Letra 'C': 
    Crie uma matriz para armazenar nomes de animais. 
    Permita que o usuário insira os nomes dos animais na matriz. 
    Após a inserção, exiba a matriz completa e informe quantos nomes de animais começam com a letra "C".
 */

namespace Exercicio_02 { 
    public class Program() {
        static void Main() {
            string[] animais = new string[5];
            int animaisComC =0;

            Console.WriteLine("Insira os animais na matriz!");
            for(int i = 0; i < animais.Length; i++) { 
                    string entrada = Console.ReadLine();

                if (entrada.ToLower().StartsWith("c")) {
                    animaisComC++;
                    }
                    animais[i] = entrada;
            }
            
            Console.WriteLine("Aqui estao seus animais!");
            
            for (int i = 0; i < animais.Length; i++) {
                Console.WriteLine(animais[i]);
            }

            Console.WriteLine($"Existem {animaisComC} animais com C nessa matriz! ");

        }
    }
}
