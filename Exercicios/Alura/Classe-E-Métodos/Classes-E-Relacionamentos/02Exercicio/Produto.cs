using _02Exercicio;

namespace _02Exercicio;

public class Produto
{
    public string TipoDoProduto { get; set; }
    public string NomeProduto { get; set; }
    public string Marca { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    //Construtor
    public Produto(string tipoDoProduto, string nome, string marca, decimal preco, int quantidade)
    {
        TipoDoProduto = tipoDoProduto;
        NomeProduto = nome;
        Marca = marca;
        Preco = preco > 0 ? preco : throw new ArgumentException("Preço deve ser maior do que zero!");
        Quantidade = quantidade;
    }
    public void ExibirProduto()
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine($"Tipo do Produto: {TipoDoProduto}");
        Console.WriteLine($"Nome: {NomeProduto}");
        Console.WriteLine($"Nome da Marca: {Marca}");
        Console.WriteLine($"Valor do Produto: {Preco.ToString("C")}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine("-----------------------------------------------");
    }
}