
namespace Exercicio_01;
public class Pessoa {

    private string _nome = String.Empty;
    private int _idade = 0;
    private int _altura = 0;

    public string Nome {
        get { return _nome; }
    }
    public int Idade {
        get { return _idade; }
    }
    public int Altura {
        get { return _altura; }
    }

    public void AdicionarDados(string nome,int idade,int altura) {
        _nome = nome;
        _idade = idade;
        _altura = altura;
    }

    public void ImprimirDados() {
        Console.WriteLine(_nome);
        Console.WriteLine(_idade);
        Console.WriteLine(_altura);
    }

}
