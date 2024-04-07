
namespace Exercicio_02.Entities;

public class Hotel {
    private List<Quarto> quartos;
    private List<Reserva> reservas;

    public Hotel() {
        quartos = new List<Quarto>();
        reservas = new List<Reserva>();
    }

    public bool VerificarDisponibilidade(DateTime checkIn, DateTime checkOut) {
        // Verifica a disponibilidade de quartos para as datas fornecidas
        // Retorna true se houver quartos disponíveis, false caso contrário
        return true;
    }

    public void RealizarReserva(Cliente cliente, Quarto quarto, DateTime checkIn, DateTime checkOut) {
        if (ValidarDatas(checkIn, checkOut)) {
            // Realiza a reserva do quarto para as datas fornecidas
            // Adiciona a reserva à lista de reservas
        } else {
            throw new Exception("Datas inválidas para realizar a reserva.");
        }
    }
}