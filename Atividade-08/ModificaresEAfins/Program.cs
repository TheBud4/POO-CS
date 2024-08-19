namespace ModificadoresDeAcesso {
    namespace GerenciamentoDeTarefas
    {
        public class Program
        {
            public static void Main()
            {
                TarefaDesenvolvimento tarefaDev = new TarefaDesenvolvimento("Desenvolver API", "Criar endpoints RESTful", DateTime.Now, 1, "C#");
                TarefaDesign tarefaDesign = new TarefaDesign("Criar Wireframe", "Design do layout da página inicial", DateTime.Now, 2, "Figma");
                TarefaTeste tarefaTeste = new TarefaTeste("Testar API", "Realizar testes de integração", DateTime.Now, 1, "Ambiente de Teste 1");
                
                tarefaDev.MostrarDetalhes();
                tarefaDesign.MostrarDetalhes();
                tarefaTeste.MostrarDetalhes();
            }
        }
    }
}   