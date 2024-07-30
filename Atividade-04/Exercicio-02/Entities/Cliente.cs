
namespace Exercicio_02.Entities;
public class Cliente {
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public void AtualizarEndereco(string novoEndereco) {
        Endereco = novoEndereco;
    }

    public void AtualizarContato(string novoContato) {
        Contato = novoContato;
    }
}


