namespace Biblioteca.Models;

public class Reserva {
    public int Id { get; set; }
    public DateTime Data { get; set; }

    public int CodLivro { get; set; }
    public Livro Livro { get; set; }

    public int CodFuncionario { get; set; }
    public Funcionario Funcionario { get; set; }

    public int CodCliente { get; set; }
    public Cliente Cliente { get; set; }

    public string Situacao { get; set; }
}