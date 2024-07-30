
namespace Exercicio_08;
public class Funcionario {
	private string _nome = String.Empty;

	public string Nome {
		get { return _nome; }
		set { _nome = value; }
	}

	private double _salario;

	public double Salario {
		get { return _salario; }
		set { _salario = value; }
	}

	private int _horasTrabalhadas;

	public int HorasTrabalhadas {
		get { return _horasTrabalhadas; }
		set { _horasTrabalhadas = value; }
	}

	public double CalcularSalarioTotal() {
		return Salario * HorasTrabalhadas;
	}

}
