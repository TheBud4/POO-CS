
public class Pessoa {
    private string _nome = String.Empty;
    private int _idade;
    private double _altura;

    public string Nome {
        get { return _nome; }
        set { _nome = value; }
    }

    public int Idade {
        get { return _idade; }
        set { _idade = value; }
    }

    public double Altura {
        get { return _altura; }
        set { _altura = value; }
    }

    public void ImprimirDados() {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}");
    }
}
