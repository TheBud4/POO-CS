

using System.Runtime.CompilerServices;

namespace Exercicio_01.Entites;
public class Cliente {

    private string _nome;
    private string _email;
    private DateTime _nascimento;
    private Endereco _endereco;

    public string Nome { get; set; }
    public string Email { get; set; }
    public Endereco Endereco { get; set; }

    public DateTime Nascimeto {
        get { return _nascimento; }
        set {
            if (value > DateTime.Now) {
                throw new ArgumentException("A data de nascimento não pode ser no futuro.");
            }
            if (value > DateTime.Today.AddYears(-18)) {
                throw new ArgumentException("A data de nascimento não pode ser de uma pessoa menor de 18 anos.");
            }

            _nascimento = value;
        }
    }

    public void AtualizarEndereco(string novoCep, string novoBairro, string novoLogradouro, int novoNumero) {
        if (_endereco == null) {
            _endereco = new Endereco();
        }
        _endereco.Cep = novoCep;
        _endereco.Bairro = novoBairro;
        _endereco.Logradouro = novoLogradouro;
        _endereco.Numero = novoNumero;
    }
}
