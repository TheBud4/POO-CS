
/*
    Crie uma classe chamada "Triangulo" que contenha as propriedades "Base" e "Altura".
    Adicione um método chamado "CalcularArea" que calcule e retorne a área do triângulo.
*/

namespace Exercicio_03;

public class Program
{

    static void Main()
    {
        Triangulo triangulo = new Triangulo() {
            Base = 2,
            Altura = 3
        };
        Console.WriteLine(triangulo.CalcularArea());
    }
}
