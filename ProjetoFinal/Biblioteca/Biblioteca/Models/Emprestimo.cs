namespace Biblioteca.Models;

public class Emprestimo {
    public int Id { get; set; }
    public DateTime Data { get; set; }

    public int CodFuncionario { get; set; }
    public Funcionario Funcionario { get; set; }

    public List<ExemplarEmprestimo> ExemplarEmprestimos { get; set; }

}