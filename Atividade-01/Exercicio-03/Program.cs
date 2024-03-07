namespace Exercicio_03;

internal class Program {

    static void Main() {
        
        List<Produto> produtos = new List<Produto>();
        string? entrada;
        bool sair = false;
        

        while (sair == false) {
            Console.WriteLine("Selecione uma opção!");
            Console.WriteLine("1 - Ver Produtos");
            Console.WriteLine("2 - Cadastrar Produtos");
            Console.WriteLine("3 - Sair");
            entrada = Console.ReadLine();

            switch (entrada) {
                case "1":
                    
                    
                    break;
                case "2":
                    Console.WriteLine("2");
                    
                    break;
                case "3":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Digite um numero valido por favor!");
                    break;
            }
        }
    }

     public void CriarProduto() {

        Console.WriteLine("1");

    }
    
    public void GetProduto() {
        Console.WriteLine("2");
    }

}
