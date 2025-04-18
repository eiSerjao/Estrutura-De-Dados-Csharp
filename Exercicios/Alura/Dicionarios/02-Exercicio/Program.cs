/* Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos
* e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
*/


Dictionary<string, int> estoque = new Dictionary<string, int>()
{
    { "Macarrão", 10 },
    { "Acerola", 20 },
    { "Queijo Qualo", 30 },
    { "Pudim", 40 },
    { "Coxinha", 50 }
};


// Irei criar um método para toda final do progama, o usuário escolher voltar ao menu ou sair do programa
void VoltarMenu()
{
    Console.WriteLine("==========================");
    Console.WriteLine("Deseja voltar ao menu? (s/n)");
    string resposta = Console.ReadLine()!;
    if (resposta.ToLower() == "s")
    {
        Menu();
    }
    else
    {
        Console.WriteLine("Saindo do programa...");

        // metodo para encerrar o programa
        Environment.Exit(0);
    }
}

void AdicionarProduto()
{
    Console.Write("Digite o nome do produto: ");
    String nomeProduto = Console.ReadLine()!;

    Console.Write("Digite a quantidade do produto: ");
    int quantidadeProduto = int.Parse(Console.ReadLine()!);

    estoque.Add(nomeProduto, quantidadeProduto);

    Thread.Sleep(2000);
    Console.Clear();
    VoltarMenu();
    // Adicionar um tempo antes de limpar a tela
    
}


void ExibirProdutos()
{
    // Verifica se o dicionário está vazio
    if (estoque.Count == 0)
    {
        Console.WriteLine("Nenhum produto cadastrado.");
        VoltarMenu();
        return;
    }
    foreach (var item in estoque)
    {
        Console.WriteLine($"Produto: {item.Key}, Quantidade: {item.Value}");
    }
    Thread.Sleep(2000);
    VoltarMenu();
    
}

void ConsultarProduto()
{
    Console.Write("Digite o nome do produto que deseja contular:");
    string nomeProduto = Console.ReadLine()!;

    // Se o dicionário contém a chave, exibe o valor correspondente
    if (estoque.ContainsKey(nomeProduto))
    // função containskey verifica se o dicionário contém a chave
    {
        Console.WriteLine($"Produto: {nomeProduto}, Quantidade: {estoque[nomeProduto]}");
    }
    else
    {
        Console.WriteLine("Produto não encontrado.");
    }
    Thread.Sleep(2000);
    Console.Clear();
    VoltarMenu();
    
}

void Menu()
{
    Console.Clear();
    int opcao = 0;
    Console.WriteLine("Bem vindo ao sistema de estoque!\n\n");
    Console.WriteLine("Opçãos disponíveis:");
    Console.WriteLine("1 - Adicionar produto");
    Console.WriteLine("2 - Exibir produtos");
    Console.WriteLine("3 - Consultar produto");
    Console.WriteLine("4 - Sair do programa");
    Console.Write("Escolha uma opção:");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            AdicionarProduto();
            break;
        case 2:
            ExibirProdutos();
            break;
        case 3:
            ConsultarProduto();
            break;
        case 4:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Menu();

