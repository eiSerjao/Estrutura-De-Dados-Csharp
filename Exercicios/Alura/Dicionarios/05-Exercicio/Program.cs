Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

String carro = "Lamborghini Aventador";

if (vendasCarros.ContainsKey(carro))
{
    List<int> vendas = vendasCarros[carro];
    double media = vendas.Average();
    Console.WriteLine($"Esse carro {carro} teve {vendas.Count} vendas, com uma média de {media:F2} vendas por mês.");
}
else
{
    Console.WriteLine($"O carro {carro} não foi encontrado.");
}

Console.ReadKey();