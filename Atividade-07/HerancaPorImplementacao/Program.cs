using HerancaPorImplementacao.Models;

namespace HerancaPorImplementacao;

class Program {
    static void Main(string[] args) {
        Aluno aluno = new Aluno("Pedro", 20, "123.456.789-00", "20220001", "Ciência da Computação");
        Professor professor = new Professor("Joao", 35, "987.654.321-00", "Matemática", 3000m);
        FuncionarioAdministrativo funcionario =
            new FuncionarioAdministrativo("Lucas", 40, "111.222.333-44", "Financeiro", "Assistente", 2500m);

        Console.WriteLine(aluno);
        aluno.ExecutarAtividade();

        Console.WriteLine(professor);
        professor.ExecutarAtividade();

        Console.WriteLine(funcionario);
        
    }
}