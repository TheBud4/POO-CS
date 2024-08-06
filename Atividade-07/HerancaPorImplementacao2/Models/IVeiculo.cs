namespace HerancaPorImplementacao2.Models;

public interface IVeiculo
{
    string Placa { get; }
    string Modelo { get; }
    int Ano { get; }
    decimal ValorDiaria { get; }

    decimal CalcularAluguel(int dias);
}
