using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoUm {
    public abstract class Forma(string id) {
        private readonly string id = id;
        public string ExibirID() => id;
        public virtual double CalcularArea() {
            return CalcularArea();
        }
    }
}