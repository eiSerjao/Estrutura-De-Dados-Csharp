// Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

using System.ComponentModel.Design;

// Criar um dicionário para armazenar os usuários e senhas
Dictionary<string, string> usuarios = new Dictionary<string, string>();


// Função para cadastrar um novo usuário
void cadastrarUsuario()
{
    Console.Clear();
    Console.WriteLine("==========================");
    Console.WriteLine("Cadastrar Usuário");
    Console.WriteLine("==========================");


    // Loop para garantir que o usuário não exista
    while (true)
    {
        Console.Write("Digite o nome de usuário: ");
        string usuario = Console.ReadLine()!;

        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine()!;

        // Verifica se o usuário já existe no dicionário utilizando ContainsKey
        if (usuarios.ContainsKey(usuario))
        {
            Console.Clear();
            Console.WriteLine("Usuário já existe. Tente novamente.");
            Thread.Sleep(2000); // Pausa por 2 segundos
            Console.Clear();
        }
        else
        {
            // Adiciona o usuário e a senha ao dicionário
            usuarios.Add(usuario, senha);

            Console.Clear();
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Thread.Sleep(2000); // Pausa por 2 segundos
            break;

        }
    }

    // Retorna ao menu principal
    Menu();

}

// Função para fazer login
void fazerLogin()
{
    Console.Clear();
    Console.WriteLine("==========================");
    Console.WriteLine("Fazer Login");
    Console.WriteLine("==========================");

    // Loop para garantir que o usuário insira as credenciais corretas
    bool acessoPermitido = false;

    // Loop para garantir que o usuário insira as credenciais corretas
    while (acessoPermitido == false)
    {
        Console.Write("Digite o nome de usuário: ");
        string usuario = Console.ReadLine()!;

        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine()!;

        // Verifica se o usuário existe e se a senha está correta
        if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senha)
        {
            Console.Clear();
            Console.WriteLine("Login realizado com sucesso!");
            Thread.Sleep(2000); // Pausa por 2 segundos

            Console.Clear();
            Console.WriteLine($"Bem-vindo ao sistema {usuario}");
            Thread.Sleep(2000); // Pausa por 2 segundos

            // Acesso permitido, sai do loop
            acessoPermitido = true;
            break;
           
        }
        else // se o usuário não existe ou a senha está incorreta
        {
            Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
            Thread.Sleep(2000); // Pausa por 2 segundos
            Console.Clear();
        }
    }

    // Retorna ao menu principal
    Menu();

}

// Função para exibir o menu principal
void Menu()
{

    Console.Clear();

    Console.WriteLine("==========================");
    Console.WriteLine("Sistema de Login");
    Console.WriteLine("==========================");
    Console.WriteLine("1. Cadastrar Usuário");
    Console.WriteLine("2. Fazer Login");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma opção: ");

    // Lê e armazena a opção escolhida pelo usuário
    string opcao = Console.ReadLine()!;

    // Verifica a opção escolhida e chama a função correspondente
    switch (opcao)
    {
        case "1":
            cadastrarUsuario();
            break;
        case "2":
            fazerLogin();
            break;
        case "3":
            // Encerra o programa utilizando Environment.Exit(0)
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

// Chama a função Menu para iniciar o programa
Menu();