namespace HerancaPorImplementacao2.Models;

public abstract class Veiculo : IVeiculo
{
    public string Placa { get; protected set; }
    public string Modelo { get; protected set; }
    public int Ano { get; protected set; }
    public decimal ValorDiaria { get; protected set; }

    public Veiculo(string placa, string modelo, int ano, decimal valorDiaria)
    {
        Placa = placa;
        Modelo = modelo;
        Ano = ano;
        ValorDiaria = valorDiaria;
    }

    public abstract decimal CalcularAluguel(int dias);

    public override string ToString()
    {
        return $"Modelo: {Modelo}\n Placa: {Placa}\n Ano: {Ano}\n Valor Diária: {ValorDiaria:C}\n";
    }
}
