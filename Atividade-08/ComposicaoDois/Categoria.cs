using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoDois {
    public class Categoria(Livro livro, string nomeCategoria) {
        public Livro Livro { get; set; } = livro;
        public string NomeCategoria { get; set; } = nomeCategoria;

        public void MostrarDetalhes() {
            Livro.MostrarDetalhes();
            Console.WriteLine($"Categoria: {NomeCategoria}");
        }
    }
}