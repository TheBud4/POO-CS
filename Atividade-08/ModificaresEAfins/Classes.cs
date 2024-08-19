namespace ModificadoresDeAcesso;

public abstract class Tarefa {
    public string Titulo { get; set; }

    protected string Descricao { get; set; }

    internal DateTime DataCriacao { get; set; }

    protected internal int Prioridade { get; set; }

    public Tarefa(string titulo, string descricao, DateTime dataCriacao, int prioridade) {
        Titulo = titulo;
        Descricao = descricao;
        DataCriacao = dataCriacao;
        Prioridade = prioridade;
    }

    public virtual void MostrarDetalhes() {
        Console.WriteLine(
            $"Título: {Titulo}, Descrição: {Descricao}, Data de Criação: {DataCriacao}, Prioridade: {Prioridade}");
    }
}

public class TarefaDesenvolvimento : Tarefa {
    public string LinguagemDeProgramacao { get; set; }

    public TarefaDesenvolvimento(string titulo, string descricao, DateTime dataCriacao, int prioridade,
        string linguagemDeProgramacao)
        : base(titulo, descricao, dataCriacao, prioridade) {
        LinguagemDeProgramacao = linguagemDeProgramacao;
    }

    public override void MostrarDetalhes() {
        base.MostrarDetalhes();
        Console.WriteLine($"Linguagem de Programação: {LinguagemDeProgramacao}");
    }
}

public class TarefaDesign : Tarefa {
    public string FerramentaDesign { get; set; }

    public TarefaDesign(string titulo, string descricao, DateTime dataCriacao, int prioridade, string ferramentaDesign)
        : base(titulo, descricao, dataCriacao, prioridade) {
        FerramentaDesign = ferramentaDesign;
    }

    public override void MostrarDetalhes() {
        base.MostrarDetalhes();
        Console.WriteLine($"Ferramenta de Design: {FerramentaDesign}");
    }
}

public class TarefaTeste : Tarefa {
    protected string AmbienteTeste { get; set; }

    public TarefaTeste(string titulo, string descricao, DateTime dataCriacao, int prioridade, string ambienteTeste)
        : base(titulo, descricao, dataCriacao, prioridade) {
        AmbienteTeste = ambienteTeste;
    }

    public override void MostrarDetalhes() {
        base.MostrarDetalhes();
        Console.WriteLine($"Ambiente de Teste: {AmbienteTeste}");
    }
}