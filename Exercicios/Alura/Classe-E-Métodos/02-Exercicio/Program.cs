using System;

public class Carro
{
    public string marca;
    public string modelo;
    public int anoFrabicacao;
    public string cor;
    public string tipoCombustivel;
    public int velocidadeMaxima;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Ano de Fabricação: {anoFrabicacao}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Tipo de Combustível: {tipoCombustivel}");
        Console.WriteLine($"Velocidade Máxima: {velocidadeMaxima} km/h");
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

class Program
{
    static void Main()
    {
        Carro FordKaSedan = new Carro();

        FordKaSedan.marca = "Ford";
        FordKaSedan.modelo = "Ford Ka Sedan";
        FordKaSedan.anoFrabicacao = 2016;
        FordKaSedan.cor = "Branco";
        FordKaSedan.tipoCombustivel = "Gasolina & Etanol";
        FordKaSedan.velocidadeMaxima = 180;

        FordKaSedan.ExibirInformacoes();

        FordKaSedan.Acelerar();

        FordKaSedan.Freando();

        FordKaSedan.Buzinar();

        Console.ReadKey();
    }
}