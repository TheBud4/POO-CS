namespace Biblioteca.Models;

public class Livro {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string CodBarras { get; set; }
    public string CodCategoria { get; set; }
    public string Edicao { get; set; }
    public int Ano { get; set; }
    public int PrazoMaximo { get; set; }

    public int CatCodigo { get; set; }
    public Categoria Categoria { get; set; }

    public List<AutorLivro> AutorLivros { get; set; }
    public List<Reserva> Reservas { get; set; }
    public List<Exemplar> Exemplares { get; set; }}