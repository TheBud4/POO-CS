namespace HerancaPorImplementacao2.Models;

public class Moto : Veiculo
{
    public int Cilindrada { get; private set; }

    public Moto(string placa, string modelo, int ano, decimal valorDiaria, int cilindrada)
        : base(placa, modelo, ano, valorDiaria)
    {
        Cilindrada = cilindrada;
    }

    public override decimal CalcularAluguel(int dias)
    {
        return dias * ValorDiaria;
    }

    public override string ToString()
    {
        return base.ToString() + $" Cilindrada: {Cilindrada}cc \n";
    }
}
