namespace Biblioteca.Models;

public class Cliente {
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

    public int PrazoDevol { get; set; }

    public List<Reserva> Reservas { get; set; }
}