using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoUm {
    public class EventoSocial(Evento evento, string vestimenta) {
        public Evento Evento { get; set; } = evento;
        public string Vestimenta { get; set; } = vestimenta;

        public void MostrarDetalhes() {
            Evento.MostrarDetalhes();
            Console.WriteLine($"Vestimenta: {Vestimenta}");
        }
    }
}