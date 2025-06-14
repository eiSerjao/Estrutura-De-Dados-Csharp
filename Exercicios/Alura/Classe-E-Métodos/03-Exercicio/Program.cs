namespace _02_Exercicio;

public class Produto
{
    public string NomeProduto { get; set; }
    public string Marca { get; set; }
    private int _preco;
    public int Preco
    {
        get
        {
            return _preco;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O preço deve ser maior que zero.");
            }
            else
            {
                _preco = value;
            }
        }
    }
    private int _estoque;
    public int Estoque
    {
        get
        {
            return _estoque;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("O estoque não pode ser negativo.");
            }
            else
            {
                _estoque = value;
            }
        }
    }
    public string Descricao
    {
        get
        {
            return $"Nome: {NomeProduto}, Marca: {Marca}, Preço: {Preco:C}, Estoque: {Estoque}";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto produto00 = new Produto();
        produto00.NomeProduto = "Notebook";
        produto00.Marca = "Dell";
        produto00.Preco = 3500;
        produto00.Estoque = 10;
        Console.WriteLine(produto00.Descricao);
    }
}