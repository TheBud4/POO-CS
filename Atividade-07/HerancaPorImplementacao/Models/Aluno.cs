namespace HerancaPorImplementacao.Models;

public class Aluno : Pessoa, IAtividadeEscolar {
    public string Matricula { get; private set; }
    public string Curso { get; private set; }

    public Aluno(string nome, int idade, string cpf, string matricula, string curso)
        : base(nome, idade, cpf) {
        Matricula = matricula;
        Curso = curso;
    }

    public void ExecutarAtividade() {
        Console.WriteLine($"{Nome} está assistindo às aulas e estudando para as provas.");
    }

    public override string ToString() {
        return base.ToString() + $" Matrícula: {Matricula}\n Curso: {Curso}\n";
    }
}