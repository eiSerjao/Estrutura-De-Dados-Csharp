

/*Crie um programa que implemente um quiz simples de perguntas e respostas. 
 Utilize um dicionário para armazenar as perguntas e as respostas corretas.
*/


// Dicionário para armazenar perguntas e respostas
Dictionary<int, String[,]> Perguntas = new Dictionary<int, String[,]>()
{
    { 1, new String[,] { { "Qual é a capital da França?", "Paris" } } },
    { 2, new String[,] { { "Qual é a capital da Alemanha?", "Berlim" } } },
    { 3, new String[,] { { "Qual é a capital da Espanha?", "Madri" } } },
    { 4, new String[,] { { "Qual é a capital da Itália?", "Roma" } } },
    { 5, new String[,] { { "Qual é a capital do Brasil?", "Brasília" } } }
};


// Metodo para exibir o menu
void gerarPergunta()
{
    // Gerar um número aleatório para acessar o dicionário e selecionar uma pergunta a partir de sua chave
    Random random = new Random();

    // Variável para armazenar o número aleatório
    int numeroAleatorio = random.Next(1, 6);


    //string[,] perguntaSelecionada = Perguntas[numeroAleatorio];

    // Exibir a pergunta ao usuário
    Console.WriteLine(Perguntas[numeroAleatorio][0,0]);

    // Solicitar a resposta do usuário e armazenar na variável respostaUsuario
    Console.Write("Digite sua resposta: ");
    string respostaUsuario = Console.ReadLine()!;

    // Chamar o método confirmarReposta passando a resposta do usuário e o número aleatório
    confirmarReposta(respostaUsuario, numeroAleatorio);

    Console.ReadKey();
};

// Método para confirmar a resposta do usuário
void confirmarReposta(string reposta, int pergunta)
{
    // Verifica se a resposta do usuário está correta
    if (reposta.ToLower() == Perguntas[pergunta][0, 1].ToLower())
    {
        Console.WriteLine("Resposta Correta!");
    }
    else
    {
        Console.WriteLine($"Reposta Incorreta! A reposta correta é: {Perguntas[pergunta][0, 1]}");
    };
       

};

// Chamar o método gerarPergunta para iniciar o quiz
gerarPergunta();