
namespace Exercicio_06 {
    public class Aluno {
        private string _nome = String.Empty;

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        private List<double> _notas = new List<double>();

        public List<double> Notas {
            get { return _notas; }
            set { _notas = value; }
        }

        public Aluno(string nome, params double[] notas) {
            Nome = nome;
            foreach (var nota in notas) {
                _notas.Add(nota);
            }
        }

        public void AdicionarNota(double nota) {
            Notas.Add(nota);
        }

        public void RemoverNota(double nota) {
            Notas.Remove(nota);
        }

        public double CalcularMedia() {
            double soma = 0;
            foreach (double nota in Notas) {
                soma += nota;
            }
            return soma / Notas.Count;
        }
    }
}
