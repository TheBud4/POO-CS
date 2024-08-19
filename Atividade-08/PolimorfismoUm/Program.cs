namespace PolimorfismoUm {
    public class Program {
        static void Main() {
            var formas = new Forma[] {
                new Retangulo("Retângulo 1", 10, 20),
                new Circulo("Círculo 1", 10),
                new Retangulo("Retângulo 2", 20, 30),
                new Circulo("Círculo 2", 20)
            };

            foreach (var forma in formas) {
                Console.WriteLine($"{forma.ExibirID()}: {forma.CalcularArea()}");
            }
        }
    }
}