namespace Exercicio_04;

public class Program {
    static void Main() {
        string? entrada;
        bool ganhar = false;
        Random random = new Random();
        int aleatorio = random.Next(1, 20);
        while (ganhar == false) {
            Console.WriteLine("Escolha um numero de 1 a 20!");
            entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out int numero)) {
                Console.WriteLine("Por favor, digite um número válido.");
            }
            if (numero == aleatorio) {
                Console.WriteLine("Parabens você acertou!");
                ganhar = true;
            } 
            if(numero > aleatorio) {
                Console.WriteLine("Passou do numero! Escolha um numero menor!");
            }
            if (numero < aleatorio) {
                Console.WriteLine("Quase la! tente um numero mais alto!");
            }
            
        }
    }
}
