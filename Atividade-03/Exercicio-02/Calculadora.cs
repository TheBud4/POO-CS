
namespace Exercicio_02;
public class Calculadora {

    private float _num1;

    public float Numero1 {
        get { return _num1; }
        set { _num1 = value; }
    }

    private float _num2;

    public float Numero2 {
        get { return _num2; }
        set { _num2 = value; }
    }

    public void Somar(float numero1, float numero2) {
        Numero1 = numero1;
        Numero2 = numero2;
        Console.WriteLine(Numero1 + Numero2);
    }

    public void Dividir(float numero1, float numero2) {
        Numero1 = numero1;
        Numero2 = numero2;
        Console.WriteLine(Numero1 /Numero2);
    }

    public void Subtrair(float numero1, float numero2) {
        Numero1 = numero1;
        Numero2 = numero2;
        Console.WriteLine(Numero1 - Numero2);
    }
    public void Multiplicar(float numero1, float numero2) {
        Numero1 = numero1;
        Numero2 = numero2;
        Console.WriteLine(Numero1 * Numero2);
    }

}
