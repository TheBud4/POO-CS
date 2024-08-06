namespace HerancaPorImplementacao2.Models;

public class Caminhao : Veiculo
{
    public int CapacidadeCarga { get; private set; } // Em toneladas

    public Caminhao(string placa, string modelo, int ano, decimal valorDiaria, int capacidadeCarga)
        : base(placa, modelo, ano, valorDiaria)
    {
        CapacidadeCarga = capacidadeCarga;
    }

    public override decimal CalcularAluguel(int dias)
    {
        return dias * ValorDiaria;
    }

    public override string ToString()
    {
        return base.ToString() + $" Capacidade de Carga: {CapacidadeCarga}t \n";
    }
}
