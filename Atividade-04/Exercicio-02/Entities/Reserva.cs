
namespace Exercicio_02.Entities;
public class Reserva {
    public Cliente Cliente { get; set; }
    public Quarto Quarto { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public void ValidarDatas(DateTime checkIn, DateTime checkOut) {
        if (checkIn > checkOut) {
            throw new Exception("A data de check-in deve ser anterior à data de check-out.");
        }

        if (checkIn < DateTime.Now) {
            throw new Exception("As datas de check-in e check-out devem ser no futuro.");
        }
    }
}