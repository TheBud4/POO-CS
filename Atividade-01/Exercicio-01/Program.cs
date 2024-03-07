namespace Exercicio_01;

public class Program {
    static void Main() {
        List<int> notas = new List<int>();
        string entrada;
        int media = 0;

        Console.WriteLine("Sistema de Calculo de Media Escolar ");
        Console.WriteLine("Por Favor digite as notas, digite sair para encerrar a inserção");
        
        while ((entrada = Console.ReadLine()) != "sair") {
            if (int.TryParse(entrada, out int nota)) {
                notas.Add(nota);
            } else {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }

        foreach (int nota in notas) {
            media += nota;
        }
        media /= notas.Count;
        Console.WriteLine("A media de notas é:" + media);

    }
}
