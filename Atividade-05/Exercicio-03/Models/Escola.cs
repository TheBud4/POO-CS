namespace Exercicio_03.Models;

public class Escola {
    public List<Aluno> alunos = new();

    public void MatricularAluno(Aluno aluno) {
        alunos.Add(aluno);
        Console.WriteLine($"Aluno {aluno.Nome} matriculado com sucesso.");
    }

    public void DesmatricularAluno(int matricula) {
        alunos.RemoveAll(a => a.Matricula == matricula);
    }
}