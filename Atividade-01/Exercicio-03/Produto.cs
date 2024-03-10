
namespace Exercicio_03;
public class Produto {
    public Produto(string nome,decimal preco) {
        Nome = nome;
        Preco = preco;
    }

    public int Id { get; set; } = new Random().Next(1,100);
      public string Nome { get; set; } = string.Empty;
      public decimal Preco  { get; set; }
}
