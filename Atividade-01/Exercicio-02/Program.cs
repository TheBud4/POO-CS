namespace Exercicio_02;

public class Program {
    static void Main() {
        Console.WriteLine("Escolha um numero!");
        string? entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out int numero)) { 
            Console.WriteLine("Por favor, digite um número válido.");
        }
        Console.WriteLine("Vai explodir!!!");
        while(numero> 0) {
            Console.WriteLine(numero);
            numero -= 1;
            Thread.Sleep(1000);
        }
        Console.WriteLine("Boom!!");
    }
}
