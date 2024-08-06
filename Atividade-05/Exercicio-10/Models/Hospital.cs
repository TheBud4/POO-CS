namespace Exercicio_10.Models;

public class Hospital {
    public List<Paciente> pacientes = new();

    public void AdicionarPaciente(Paciente paciente) {
        pacientes.Add(paciente);
        Console.WriteLine($"Paciente {paciente.Nome} adicionado com sucesso.");
    }

    public void RemoverPaciente(string nome) {
        pacientes.RemoveAll(p => p.Nome == nome);
    }
}