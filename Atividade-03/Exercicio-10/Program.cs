
/*
     Crie uma classe chamada "ConversorDeMoedas" que contenha um método para cada tipo de conversão
    (de real para dólar, de dólar para real, de real para euro e de euro para real). 
    Cada método deve receber o valor a ser convertido como parâmetro e retornar o valor convertido.
*/

namespace Exercicio_10;

public class Program() {
    static void Main() {

        ConversorDeMoedas conversorDeMoedas = new ConversorDeMoedas();
        Console.WriteLine(conversorDeMoedas.RealParaDolar(1));
        Console.WriteLine(conversorDeMoedas.RealParaEuro(1));
        Console.WriteLine(conversorDeMoedas.DolarParaReal(1));
        Console.WriteLine(conversorDeMoedas.EuroParaReal(1));

    }
}