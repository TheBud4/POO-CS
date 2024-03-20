
namespace Exercicio_02;
public class Calculadora {

    private float _num1;

    private float _num2;

    public float Resultado;

     public void Somar(float numero1,float numero2) {
        _num1 = numero1;
        _num2 = numero2;
        Resultado = _num1 + _num2;
    }
}
