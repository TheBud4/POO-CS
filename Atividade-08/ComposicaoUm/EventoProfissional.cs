using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoUm {
    public class EventoProfissional(Evento evento, string empresa) {
        public Evento Evento { get; set; } = evento;
        public string Empresa { get; set; } = empresa;

        public void MostrarDetalhes() {
            Evento.MostrarDetalhes();
            Console.WriteLine($"Empresa: {Empresa}");
        }
    }
}