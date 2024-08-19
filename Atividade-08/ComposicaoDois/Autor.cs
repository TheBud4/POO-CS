using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoDois {
    public class Autor(Livro livro, int id, string nome) {
        public Livro Livro { get; set; } = livro;
        public int Id { get; set; } = id;
        public string Nome { get; set; } = nome;

        public void MostrarDetalhes() {
            Livro.MostrarDetalhes();
            Console.WriteLine($"Autor: {Nome}");
        }
    }
}