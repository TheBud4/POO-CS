using Atividade_06.Models;

namespace Atividade_06;

public class Program {
    public static void Main(string[] args) {
        var revista = new Revista("Revista de Teste", "Edição 1", 123456, DateTime.Now);
        var livro = new Livro("Autor de Teste", "Livro de Teste", 123456, 100, DateTime.Now);
        var dvd = new Dvd("Autor de Teste", "DVD de Teste", 120, DateTime.Now);
        var item = new Item("Item de Teste", "Item de Teste", DateTime.Now);
        
        revista.Descricao();
        livro.Descricao();
        dvd.Descricao();
        item.Descricao();
        
    }
}