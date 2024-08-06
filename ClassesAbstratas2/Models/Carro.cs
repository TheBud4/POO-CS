namespace ClassesAbstratas2.Models;

public class Carro : Veiculo {
    public int NumeroPortas { get; private set; }

    public Carro(string placa, string modelo, int ano, decimal valorDiaria, int numeroPortas)
        : base(placa, modelo, ano, valorDiaria) {
        NumeroPortas = numeroPortas;
    }

    public override decimal CalcularAluguel(int dias) {
        return dias * ValorDiaria;
    }

    public override string ToString() {
        return base.ToString() + $", Portas: {NumeroPortas}";
    }
}