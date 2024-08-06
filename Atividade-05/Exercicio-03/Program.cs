using Exercicio_03.Models;

namespace Exercicio_03;

class Program {
    static void Main() {
        Escola escola = new();

        Aluno aluno1 = new("João", 1);
        Aluno aluno2 = new("Maria", 2);
        Aluno aluno3 = new("José", 3);

        escola.MatricularAluno(aluno1);
        escola.MatricularAluno(aluno2);
        escola.MatricularAluno(aluno3);

        foreach (var aluno in escola.alunos) {
            Console.WriteLine($"Nome: {aluno.Nome}\n" +
                              $"Matrícula: {aluno.Matricula}");
        }

        escola.DesmatricularAluno(2);

        foreach (var aluno in escola.alunos) {
            Console.WriteLine($"Nome: {aluno.Nome}\n" +
                              $"Matrícula: {aluno.Matricula}");
        }
    }
}