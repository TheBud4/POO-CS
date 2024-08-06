using Exercicio_09.Models;

namespace Exercicio_09;

class Program {
    static void Main(string[] args) {
        Teatro teatro = new();

        teatro.AdicionarPeca(new Peca("O Rei Leão", "Nah Tvenya"));
        teatro.AdicionarPeca(new Peca("O Fantasma da Ópera", "Andrew Lloyd Webber"));
        teatro.AdicionarPeca(new Peca("Cats", "Andrew Lloyd Webber"));

        foreach (var peca in teatro.pecas) {
            Console.WriteLine($"Nome: {peca.Titulo}\n" +
                              $"Autor: {peca.Diretor}");
        }

        teatro.RemoverPeca("O Fantasma da Ópera");

        foreach (var peca in teatro.pecas) {
            Console.WriteLine($"Nome: {peca.Titulo}\n" +
                              $"Autor: {peca.Diretor}");
        }
    }
}