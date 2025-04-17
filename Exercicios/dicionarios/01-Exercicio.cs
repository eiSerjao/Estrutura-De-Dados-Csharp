// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>()
{
    { "João", new List<double> { 7.5, 8.0, 9.0 } },
    { "Maria", new List<double> { 6.5, 7.0, 8.5 } },
    { "Pedro", new List<double> { 9.5, 10.0, 9.0 } }
};


foreach (var aluno in alunos)
{
    string nome = aluno.Key;
    List<double> notas = aluno.Value;
    double media = notas.Average();
    Console.WriteLine($"A média de {nome} é {media:F2}");
}


