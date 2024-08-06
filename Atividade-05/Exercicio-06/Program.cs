using Exercicio_06.Models;

namespace Exercicio_06;

class Program {
    static void Main() {
        Museu museu = new();
        Obra o1 = new("Mona Lisa", "Leonardo da Vinci");
        Obra o2 = new("A Noite Estrelada", "Vincent van Gogh");
        Obra o3 = new("O Grito", "Edvard Munch");

        museu.AdicionarObra(o1);
        museu.AdicionarObra(o2);
        museu.AdicionarObra(o3);

        foreach (var obra in museu.obras) {
            Console.WriteLine($"Título: {obra.Titulo}\n" +
                              $"Artista: {obra.Artista}");
        }

        museu.RemoverObra("A Noite Estrelada");

        foreach (var obra in museu.obras) {
            Console.WriteLine($"Título: {obra.Titulo}\n" +
                              $"Artista: {obra.Artista}");
        }
    }
}