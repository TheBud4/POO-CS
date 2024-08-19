using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoUm {
    public class Circulo(string id, double raio) : Forma(id) {
        public double Raio { get; set; } = raio;

        public override double CalcularArea() => double.Pi * Raio * Raio;
    }
}