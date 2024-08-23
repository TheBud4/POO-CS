namespace Biblioteca.Models;

public class ExemplarEmprestimo {
    public int CodExemplar { get; set; }
    public Exemplar Exemplar { get; set; }

    public int CodEmprestimo { get; set; }
    public Emprestimo Emprestimo { get; set; }

    public DateTime DtPrevDevolucao { get; set; }
    public DateTime DtDevolucao { get; set; }
    public DateTime DtPrevMulta { get; set; }
    public decimal ValorMulta { get; set; }
}