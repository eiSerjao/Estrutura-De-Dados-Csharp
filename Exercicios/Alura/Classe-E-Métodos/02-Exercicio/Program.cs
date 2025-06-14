using System;

public class Carro 
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    public string Carroceria { get; set; }

    private int _ano;
    public int Ano
    {
        get
        {
            return _ano;
        }
        set
        {
            if (value < 1960 || value > 2025)
            {
                Console.WriteLine("Ano inválido. O ano deve estar entre 1960 e 2025.");
            }
            else
            {
                _ano = value;
            }
        }
    }
    public string Cor {get; set;}
    public string TipoCombustivel {get; set;}
    public int VelocidadeMaxima {get; set;}

    public string DescricaoDetalhada
    {
        get
        {
            return $"Fabricante: {Marca}, Carroceria: {Carroceria}, Ano: {Ano}";
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Carroceria}");
        Console.WriteLine($"Ano de Fabricação: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Tipo de Combustível: {TipoCombustivel}");
        Console.WriteLine($"Velocidade Máxima: {VelocidadeMaxima} km/h");
    }

    public void Acelerar()
    {
        Console.WriteLine("\nAcelerando...");
    }

    public void Freando()
    {
        Console.WriteLine("\nFreiando...");
    }

    public void Buzinar()
    {
        Console.WriteLine("\nBuzinando...");
    }
}

public class Produto
{
    
}
class Program
{
    static void Main()
    {
        Carro FordKa = new Carro();
        FordKa.Nome = "Ford Ka";
        FordKa.Marca = "Ford";
        FordKa.Carroceria = "Sedan";
        FordKa.Ano = 2016;
        FordKa.Cor = "Branco";
        FordKa.TipoCombustivel = "Gasolina & Etanol";
        FordKa.VelocidadeMaxima = 180;

        //FordKaSedan.ExibirInformacoes();

        Console.WriteLine($"Informações do Carro {FordKa.Nome}:");
        Console.WriteLine(FordKa.DescricaoDetalhada);

        // FordKa.Acelerar();

        // FordKa.Freando();

        // FordKa.Buzinar();

        // Console.ReadKey();

    }

}