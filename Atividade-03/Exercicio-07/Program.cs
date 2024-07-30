
/*
   Crie uma classe chamada "Retangulo" que contenha as propriedades "Base" e "Altura". 
   Adicione um método chamado "CalcularPerimetro" que calcule e retorne o perímetro do retângulo. 
*/

namespace Exercicio_07;

public class Program() {
    static void Main() {
        Retangulo retangulo = new Retangulo() {
            Base = 2,
            Altura = 2
        };
        Console.WriteLine(retangulo.CalcularPerimetro());
    }
}