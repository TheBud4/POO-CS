namespace IdentificacaodeTipo;

public class Program {
    public static void Main() {
        Tarefa tarefaDesenvolvimento = new TarefaDesenvolvimento("Implementar API", "Desenvolver endpoints REST");
        Tarefa tarefaDesign = new TarefaDesign("Criar Wireframe", "Desenhar o layout da página inicial");
        Tarefa tarefaTeste = new TarefaTeste("Testar API", "Testar os endpoints desenvolvidos");

        IdentificarTarefa(tarefaDesenvolvimento);
        IdentificarTarefa(tarefaDesign);
        IdentificarTarefa(tarefaTeste);

        IdentificarTarefaComCast(tarefaDesenvolvimento);
        IdentificarTarefaComCast(tarefaDesign);
        IdentificarTarefaComCast(tarefaTeste);

        IdentificarTarefaComTypeOf(tarefaDesenvolvimento);
        IdentificarTarefaComTypeOf(tarefaDesign);
        IdentificarTarefaComTypeOf(tarefaTeste);
    }

    public static void IdentificarTarefa(Tarefa tarefa) {
        if (tarefa is TarefaDesenvolvimento) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Desenvolvimento.");
        }
        else if (tarefa is TarefaDesign) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Design.");
        }
        else if (tarefa is TarefaTeste) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Teste.");
        }
        else {
            Console.WriteLine($"{tarefa.Titulo} é de um tipo desconhecido.");
        }
    }

    public static void IdentificarTarefaComCast(Tarefa tarefa) {
        TarefaDesenvolvimento tarefaDesenvolvimento = tarefa as TarefaDesenvolvimento;
        if (tarefaDesenvolvimento != null) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Desenvolvimento.");
            return;
        }

        TarefaDesign tarefaDesign = tarefa as TarefaDesign;
        if (tarefaDesign != null) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Design.");
            return;
        }

        TarefaTeste tarefaTeste = tarefa as TarefaTeste;
        if (tarefaTeste != null) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Teste.");
            return;
        }

        Console.WriteLine($"{tarefa.Titulo} é de um tipo desconhecido.");
    }

    public static void IdentificarTarefaComTypeOf(Tarefa tarefa) {
        if (tarefa.GetType() == typeof(TarefaDesenvolvimento)) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Desenvolvimento.");
        }
        else if (tarefa.GetType() == typeof(TarefaDesign)) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Design.");
        }
        else if (tarefa.GetType() == typeof(TarefaTeste)) {
            Console.WriteLine($"{tarefa.Titulo} é uma tarefa de Teste.");
        }
        else {
            Console.WriteLine($"{tarefa.Titulo} é de um tipo desconhecido.");
        }
    }
}