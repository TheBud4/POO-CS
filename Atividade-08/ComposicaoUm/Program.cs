namespace ComposicaoUm {
    internal class Program {
        static void Main(string[] args) {
            Evento evento = new Evento("Evento de TI", new DateTime(2021, 10, 15), "Online");
            evento.MostrarDetalhes();
            EventoPessoal eventoPessoal = new EventoPessoal( evento, "João, Maria, José" );
            eventoPessoal.MostrarDetalhes();
            Evento evento2 = new Evento("Evento de TI", new DateTime(2021, 10, 15), "Online");
            evento2.MostrarDetalhes();
            EventoProfissional eventoProfissional = new EventoProfissional( evento2, "Eunuco de Faraó" );
            eventoProfissional.MostrarDetalhes();
        }
    }
}