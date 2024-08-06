using Exercicio_10.Models;

namespace Exercicio_10;

class Program {
    static void Main(string[] args) {
        Hospital hospital = new();

        hospital.AdicionarPaciente(new Paciente("João", "Meningite"));
        hospital.AdicionarPaciente(new Paciente("Maria", "Cancer"));
        hospital.AdicionarPaciente(new Paciente("José", "Gripe"));

        foreach (var paciente in hospital.pacientes) {
            Console.WriteLine($"Nome: {paciente.Nome}\n" +
                              $"Doença: {paciente.Doenca}");
        }

        hospital.RemoverPaciente("Maria");

        foreach (var paciente in hospital.pacientes) {
            Console.WriteLine($"Nome: {paciente.Nome}\n" +
                              $"Doença: {paciente.Doenca}");
        }
    }
}