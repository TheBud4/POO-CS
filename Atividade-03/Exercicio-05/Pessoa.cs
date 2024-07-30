namespace Exercicio_05;
public class Pessoa {
	private string _nome;

	public string Nome {
		get { return _nome; }
		set { _nome = value; }
	}
	private int _idade;

	public int Idade {
		get { return _idade; }
		set { _idade = value; }
	}

	public bool EhMaiorDeIdade() {
        if (Idade < 18) return false;
        else return true;
    }

}
