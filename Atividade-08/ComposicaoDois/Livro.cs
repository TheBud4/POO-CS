using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoDois {
    public class Livro(int id, string nome) {
        public int Id { get; set; } = id;
        public string Nome { get; set; } = nome;

        public void MostrarDetalhes() {
            Console.WriteLine($"Livro '{Nome}', do código: '{Id}'");
        }
    }
}