
/*
    Crie uma classe chamada "Aluno" que contenha as propriedades "Nome" e "Notas".
    Adicione um método chamado "CalcularMedia" que calcule e retorne a média das notas do aluno.
*/

namespace Exercicio_06;

public class Program() {
    static void Main() {
        Aluno aluno = new("Murilo",1.0,6.8,2.0,8.8,9.8);

        Console.WriteLine(aluno.CalcularMedia());
    }
}