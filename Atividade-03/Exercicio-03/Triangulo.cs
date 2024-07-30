
namespace Exercicio_03;
public class Triangulo {

    private int _base;
    private int _altura;

    public int Base {
        get { return _base; }
        set { _base = value; }
    }

    public int Altura {
        get { return _altura; }
        set { _altura = value; }
    }

    public int CalcularArea() {
        return (Base * Altura) / 2;
    }

}
