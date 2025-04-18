
// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

// Criando Dicionário para armazenar alunos e suas notas
Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>()
{
    { "João", new List<double> { 7.5, 8.0, 9.0 } },
    { "Maria", new List<double> { 6.5, 7.0, 8.5 } },
    { "Pedro", new List<double> { 9.5, 10.0, 9.0 } }
};

// Entrada para adicionar um novo aluno e criar uma nova chave 
Console.Write("Digite o nome do aluno:");
string nomeAluno = Console.ReadLine()!;

// Adicionando o novo aluno ao dicionário
// Como Adicionar uma nova chave
alunos.Add(nomeAluno, new List<double>());
// nomeDoDicionario.add(nomeDaVariavelComAEntradaDoUsuario, new List<double>());

// Laço de repetição para adicionar as três notas do aluno
for( int i = 0; i < 3; i++)
{
    Console.Write($"Digite a nota {i + 1} do aluno {nomeAluno}: ");
    // Criando uma variável para armazenar a nota e logo ser adicionada ao dicionário correspondente
    double nota = double.Parse(Console.ReadLine()!);

    // Como adicionar um valor a uma chave já existente
    alunos[nomeAluno].Add(nota);
    // nomeDoDicionario[nomeDaChaveQueVocêQuerAdicionarOValor].Add(nomeDaVariavelOndeEstarArmazenadaOValor);
}


Console.WriteLine("Alunos Registrados e suas médias:");
Console.WriteLine("===================================");

// Laço de repetição para percorrer o dicionário e calcular a média
foreach (var aluno in alunos)
{
    // Variavel para armazenar a chave com o nome do aluno
    string nome = aluno.Key;

    // Criando uma variável do tipo List<double> para armazenar todas as notas do aluno
    List<double> notas = aluno.Value;

    // Calculando a média de todas as notas do aluno
    double media = notas.Average();

    // Saida formatada com o nome do aluno, suas notas e a média
    Console.WriteLine($"Nome: {nome}, Notas: {string.Join(", ", notas)}, Média: {media:F2}");
}

Console.ReadKey();
