
namespace Exercicio_07;
public class Retangulo {
	private int _base;

	public int Base {
		get { return _base; }
		set { _base = value; }
	}
	private int _altura;

	public int Altura {
		get { return _altura; }
		set { _altura = value; }
	}

	public int CalcularPerimetro() {
		return 2* (Base + Altura);
	}
}
