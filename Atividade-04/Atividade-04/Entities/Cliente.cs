
namespace Exercicio_01.Entities;
public class Cliente {

    private string _nome;
    private string _email;
    private DateTime _nascimento;
    private Endereco _endereco;
    private string _telefone;
    public string Nome { get; set; }
    public string Email { get; set; }
    public Endereco Endereco { get; set; }
    public string Telefone { get; set; }

    public DateTime Nascimento {
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
