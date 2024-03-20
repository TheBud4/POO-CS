/*
    Crie uma classe chamada "Pessoa" que contenha as propriedades "Nome", "Idade" e "Altura".
    Adicione um método chamado "ImprimirDados" que imprime essas informações no console. 
*/

namespace Exercicio_01;

public class Program{
   static void Main() {
        Pessoa pessoa = new();
        pessoa.AdicionarDados("Murilo", 20, 190);
        pessoa.ImprimirDados();
    }
}