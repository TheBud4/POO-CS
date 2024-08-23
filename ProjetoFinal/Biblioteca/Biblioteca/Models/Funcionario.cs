namespace Biblioteca.Models;

public class Funcionario {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string RG { get; set; }
    public string CPF { get; set; }

    public int CodEndereco { get; set; }
    public Endereco Endereco { get; set; }

    public int CodBairro { get; set; }
    public Bairro Bairro { get; set; }

    public int CodCidade { get; set; }
    public Cidade Cidade { get; set; }

    public int CodCargo { get; set; }
    public Cargo Cargo { get; set; }

    public List<Emprestimo> Emprestimos { get; set; }
    public List<Reserva> Reservas { get; set; }
}