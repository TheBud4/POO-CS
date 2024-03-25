
/*
    Crie uma classe chamada "Aluno" que contenha as propriedades "Nome" e "Notas".
    Adicione um método chamado "CalcularMedia" que calcule e retorne a média das notas do aluno.
*/

namespace Exercicio_06;

public class Program() {
    static void Main() {
        Aluno aluno = new() { 
        Nome ="Murilo"
        };
        aluno.AdicionarNota(1.0);
        aluno.AdicionarNota(2.6);
        aluno.AdicionarNota(6.2);
        aluno.AdicionarNota(5.3);
        aluno.AdicionarNota(7.4);

        Console.WriteLine(aluno.CalcularMedia());
    }
}