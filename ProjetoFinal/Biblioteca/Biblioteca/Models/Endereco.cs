namespace Biblioteca.Models;

public class Endereco {
    public int Id { get; set; }
    public string Descricao { get; set; }

    public List<Cliente> Clientes { get; set; }
    public List<Funcionario> Funcionarios { get; set; }
    public List<Editora> Editoras { get; set; }
}