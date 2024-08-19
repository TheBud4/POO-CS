
namespace PolimorfismoUm {
    public class Triangulo(string id, double lado, double altura) : Forma(id) {
        public double Base { get; set; } = lado;
        public double Altura { get; set; } = altura;

        public override double CalcularArea() {
            return (Base * Altura) / 2.0;
        }

    }
}