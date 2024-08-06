﻿using HerancaPorImplementacao2.Models;

namespace HerancaPorImplementacao2;

class Program
{
    static void Main(string[] args)
    {
        List<IVeiculo> veiculos = new List<IVeiculo>
        {
            new Carro("ABC-1234", "Sedan", 2020, 150, 4),
            new Moto("XYZ-5678", "Coupe", 2021, 100, 600),
            new Caminhao("LMN-9101", "Caminhao", 2019, 300, 10)
        };

        foreach (var veiculo in veiculos)
        {
            Console.WriteLine(veiculo);
            Console.WriteLine($"Aluguel para 5 dias: {veiculo.CalcularAluguel(5):C}");
            Console.WriteLine();
        }
    }
}