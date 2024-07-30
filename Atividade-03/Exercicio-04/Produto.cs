
namespace Exercicio_04;
public class Produto {

    private string _nome = String.Empty;

    private double _preco;

    private int _quantidade;

    public string Nome {
        get { return _nome; }
        set { _nome = value; }
    }
    public double Preco {
        get { return _preco; }
        set { _preco = value; }
    }
    public int Quantidade {
        get { return _quantidade; }
        set { _quantidade = value; }
    }

    public double CalculaTotal() {
        return Quantidade * Preco;
    }
}
