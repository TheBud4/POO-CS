
namespace Exercicio_02.Entities;

public class Quarto {
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public decimal PrecoPorNoite { get; set; }

    public void AtualizarPrecoPorNoite(decimal novoPreco) {
        PrecoPorNoite = novoPreco;
    }

    public void MarcarComoOcupado() {
        // Marca o quarto como ocupado
    }
}
