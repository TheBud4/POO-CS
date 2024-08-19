using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoUm {
    public class Retangulo(string id, double ladoUm, double ladoDois) : Forma(id) {
        public double LadoUm { get; set; } = ladoUm;
        public double LadoDois { get; set; } = ladoDois;

        public override double CalcularArea() => LadoUm * LadoDois;

    }
}