

// Criando Dicionário para armazenar alunos e suas notas
Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>()
{
    { "João", new List<double> { 7.5, 8.0, 9.0 } },
    { "Maria", new List<double> { 6.5, 7.0, 8.5 } },
    { "Pedro", new List<double> { 9.5, 10.0, 9.0 } }
};

// Entrada para adicionar um novo aluno 
Console.Write("Digite o nome do aluno:");
string nomeAluno = Console.ReadLine()!;

// Adicionando o novo aluno ao dicionário
alunos.Add(nomeAluno, new List<double>());
// Como Adicionar uma nova chave
// nomeDoDicionario.add(nomeDaVariavelComAEntradaDoUsuario, new List<double>());

// Laço de repetição para adicionar as três notas dos alunos
for( int i = 0; i < 3; i++)
{
    Console.Write($"Digite a nota {i + 1} do aluno {nomeAluno}: ");
    double nota = double.Parse(Console.ReadLine()!);
    alunos[nomeAluno].Add(nota);
}


Console.WriteLine("Alunos Registrados e suas médias:");

foreach (var aluno in alunos)
{
    string nome = aluno.Key;
    List<double> notas = aluno.Value;
    double media = notas.Average();
    Console.WriteLine($"Nome: {nome}, Notas: {string.Join(", ", notas)}, Média: {media:F2}");
}