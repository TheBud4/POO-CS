namespace Biblioteca.Models;

public class Cargo {
    public int Id { get; set; }
    public string Descricao { get; set; }
    public decimal SalarioBase { get; set; }

    public List<Funcionario> Funcionarios { get; set; }
}