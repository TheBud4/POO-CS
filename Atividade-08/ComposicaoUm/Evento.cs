namespace ComposicaoUm {
    public class Evento(string titulo, DateTime data, string local) {
        public string Titulo { get; set; } = titulo;
        public DateTime Data { get; set; } = data;
        public string Local { get; set; } = local;

        public virtual void MostrarDetalhes() {
            Console.WriteLine($"Evento: {Titulo}");
            Console.WriteLine($"Data: {Data}, em {Local}");
        }
    }
}