
namespace Exercicio_01.Entities;
public class Cliente {

    private string _nome = String.Empty;
    private string _email = String.Empty;
    private DateTime _nascimento;
    private Endereco _endereco;

    private string _telefone = String.Empty;
    public string Nome { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public Endereco Endereco { get; set; }
    public string Telefone { get; set; } = String.Empty;

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
        if (Endereco == null) {
            Endereco = new Endereco();
        }
        Endereco.Cep = novoCep;
        Endereco.Bairro = novoBairro;
        Endereco.Logradouro = novoLogradouro;
        Endereco.Numero = novoNumero;
    }
}
