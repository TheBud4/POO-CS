namespace IdentificacaodeTipo;
public enum TipoTarefa {
    Desenvolvimento,
    Design,
    Teste
}
public class Tarefa
{
    public TipoTarefa Tipo { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }

    public Tarefa(TipoTarefa tipo, string titulo, string descricao)
    {
        Tipo = tipo;
        Titulo = titulo;
        Descricao = descricao;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Descrição: {Descricao}, Tipo: {Tipo}");
    }
}
public class TarefaDesenvolvimento : Tarefa
{
    public TarefaDesenvolvimento(string titulo, string descricao)
        : base(TipoTarefa.Desenvolvimento, titulo, descricao) { }
}

public class TarefaDesign : Tarefa
{
    public TarefaDesign(string titulo, string descricao)
        : base(TipoTarefa.Design, titulo, descricao) { }
}

public class TarefaTeste : Tarefa
{
    public TarefaTeste(string titulo, string descricao)
        : base(TipoTarefa.Teste, titulo, descricao) { }
}