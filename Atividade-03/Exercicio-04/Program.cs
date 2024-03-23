
/*
    Crie uma classe chamada "Produto" que contenha as propriedades "Nome", "Preco" e "Quantidade".
    Adicione um método chamado "CalcularTotal" que calcule e retorne o valor total do produto
    (preço multiplicado pela quantidade).  
*/

namespace Exercicio_04;

public class Program() {

    static void Main(string[] args) {
        Produto produto = new() {
            Nome = "Maçã",
            Preco = 2.50,
            Quantidade = 5,
        };
        Console.WriteLine(produto.CalculaTotal());
    }
}