
/*
Crie uma classe chamada "Pessoa" que contenha as propriedades "Nome" e "Idade".
Adicione um método chamado "EhMaiorDeIdade" que retorna verdadeiro se a pessoa tiver mais de 18 anos e falso caso contrário. 
*/

namespace Exercicio_05;

public class Program() {
    static void Main() {
        Pessoa pessoa = new() {
            Nome = "Murilo",
            Idade = 20
        };
        Console.WriteLine(pessoa.EhMaiorDeIdade());
    }
}