using Exercicio_05.Models;

namespace Exercicio_05;

class Program {
    static void Main() {
        Playlist playlist = new();
        Musica m1 = new("Música 1", "Artista 1");
        Musica m2 = new("Música 2", "Artista 2");
        Musica m3 = new("Música 3", "Artista 3");

        playlist.AdicionarMusica(m1);
        playlist.AdicionarMusica(m2);
        playlist.AdicionarMusica(m3);

        foreach (var musica in playlist.Musicas) {
            Console.WriteLine($"Título: {musica.Titulo}\n" +
                              $"Artista: {musica.Artista}");
        }

        playlist.RemoverMusica("Música 2");

        foreach (var musica in playlist.Musicas) {
            Console.WriteLine($"Título: {musica.Titulo}\n" +
                              $"Artista: {musica.Artista}");
        }
    }
}