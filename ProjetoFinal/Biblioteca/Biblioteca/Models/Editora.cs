namespace Biblioteca.Models;

public class Editora {
    public int Id { get; set; }
    public string Nome { get; set; }

    public int CodEndereco { get; set; }
    public Endereco Endereco { get; set; }

    public int CodCidade { get; set; }
    public Cidade Cidade { get; set; }

    public int CodBairro { get; set; }
    public Bairro Bairro { get; set; }

    public string Contato { get; set; }
}