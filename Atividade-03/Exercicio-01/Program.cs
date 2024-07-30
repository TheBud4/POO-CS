/*
    Crie uma classe chamada "Pessoa" que contenha as propriedades "Nome", "Idade" e "Altura".
    Adicione um método chamado "ImprimirDados" que imprime essas informações no console. 
*/

namespace Exercicio_01;

public class Program {
    static void Main() {
        Pessoa pessoa = new Pessoa() {
            Altura = 190,
            Idade = 20,
            Nome = "Murilo"
        };
        pessoa.ImprimirDados();
    }
}