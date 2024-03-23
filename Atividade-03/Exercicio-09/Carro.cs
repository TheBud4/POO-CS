
namespace Exercicio_09;
public class Carro {

	private string _modelo;

	public string Modelo {
		get { return _modelo; }
		set { _modelo = value; }
	}

	private int _ano;

	public int Ano {
		get { return _ano; }
		set { _ano = value; }
	}

	private double _preco;

	public double Preco {
		get { return _preco; }
		set { _preco = value; }
	}

	public double CalcularDesconto() {
        if (Ano < 2010) return 0.1 * Preco;

		else return 0.05 * Preco;
	}

}
