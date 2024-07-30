
/*
    Contagem de Cores Primárias:
    Crie uma matriz para armazenar nomes de cores.
    Permita que o usuário insira os nomes das cores na matriz.
    Após a inserção, informe quantas cores primárias (vermelho, azul e amarelo) estão presentes na matriz. 
*/


namespace Exercicio_09 {

    public class Program {
        static void Main() {

            string[] nomeCores = new string[5];
            int primarias = 0;
            Console.WriteLine("Digite as cores");
            for (int i = 0; i < nomeCores.Length; i++) {
                string entrada = Console.ReadLine();

                if (entrada.All(char.IsAsciiDigit)) {
                    Console.WriteLine("Erro: A entrada não pode ser numero. Tente Novamente");
                    i--;
                    continue;
                }
                nomeCores[i] = entrada;
                if (entrada.ToLower().Equals("azul") || entrada.ToLower().Equals("amarelo") || entrada.ToLower().Equals("vermelho")) {
                    primarias++;
                }
            }

            foreach (var cor in nomeCores){
                Console.WriteLine(cor);
            }
            Console.WriteLine("Quantidade de primarias:" + primarias);

        }
    }
}