
/*
    Crie uma classe chamada "Carro" que contenha as propriedades "Modelo", "Ano" e "Preco".
    Adicione um método chamado "CalcularDesconto" que calcule e retorne o valor do desconto a ser aplicado no preço do carro 
    (10% se o ano do carro for anterior a 2010 e 5% caso contrário). 
*/

namespace Exercicio_09;

public class Program() {
    static void Main() {

        Carro carro = new() {
            Modelo ="Ferrari",
            Ano = 2005,
            Preco = 1000000,
        };

        Console.WriteLine(carro.CalcularDesconto());
    }
}