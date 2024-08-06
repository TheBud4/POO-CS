namespace Exercicio_05.Models;

public class Playlist {
    public List<Musica> Musicas { get; } = new();

    public void AdicionarMusica(Musica musica) {
        Musicas.Add(musica);
    }

    public void RemoverMusica(string nome) {
        Musicas.RemoveAll(m => m.Titulo == nome);
    }
}