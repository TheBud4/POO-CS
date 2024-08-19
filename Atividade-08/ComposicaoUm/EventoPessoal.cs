using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoUm {
    public class EventoPessoal(Evento evento, string participantes) {
        public Evento Evento { get; set; } = evento;
        public string Participantes { get; set; } = participantes;

        public void MostrarDetalhes() {
            Evento.MostrarDetalhes();
            Console.WriteLine($"Participantes: {Participantes}");
        }
    }
}