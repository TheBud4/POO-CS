namespace ComposicaoDois {
    internal class Program {
        public static void Main() {
            Livro livro = new Livro(1, "Ventos do Inverno");
            Autor autor = new Autor(livro, 1, "George R. R. Martin");
            Categoria categoria = new Categoria(livro, "Fantasia");
            autor.MostrarDetalhes();
            categoria.MostrarDetalhes();
        }
    }
}