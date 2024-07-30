namespace Exercicio_03;

public class Program {

       static  List<Produto> produtos = new List<Produto>();
    static void Main() {
        string? entrada;
        bool sair = false;
        

        while (sair == false) {
            Console.WriteLine("Selecione uma opção!");
            Console.WriteLine("1 - Cadastrar Produtos");
            Console.WriteLine("2 - Ver Produtos");
            Console.WriteLine("3 - Sair");
            entrada = Console.ReadLine();

            switch (entrada) {
                case "1":
                    CriarProduto();
                    break;
                case "2":
                    GetProduto();
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

    static void CriarProduto() {

        Console.WriteLine("Digite o nome do produto:");

        string nome = Console.ReadLine();
        if (nome == null) {
            Console.WriteLine("Por favor digite um nome");
        }
        Console.WriteLine("Digite o preço do produto:");
        if (decimal.TryParse(Console.ReadLine(), out decimal preco)) {
            produtos.Add(new Produto(nome, preco));
            Console.WriteLine("Produto cadastrado com sucesso!");
        } else {
            Console.WriteLine("Preço inválido. Por favor, digite um número válido.");
        }

    }
    
    static void GetProduto() {

        Console.WriteLine("Lista de produtos:");
        foreach (var produto in produtos) {
            
            Console.WriteLine($"Id: {produto.Id}");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco:C}");
        }
    }
}


