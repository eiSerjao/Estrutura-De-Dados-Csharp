using System;

class ContaBancaria
{
    // Atributos
    public int NumeroIndicar { get; set; }    // Número identificador da conta
    public string NomeTitular { get; set; }    // Nome do titular
    public double Saldo { get; set; }         // Saldo da conta
    public string Senha { get; set; }           // Senha da conta

    // Método para exibir as informações da conta
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {NomeTitular}");
        Console.WriteLine($"Saldo: R$ {Saldo:F2}");
    }
}

class Program
{
    static void Main()
    {
        // Criando o objeto da conta bancária
        ContaBancaria conta1 = new ContaBancaria();

        // Atribuindo valores aos atributos
        conta1.NumeroIndicar = 123456;
        conta1.NomeTitular = "Maria Souza";
        conta1.Saldo = 2500.75;
        conta1.Senha = "senhaSecreta";

        // Exibindo as informações usando o método da própria classe
        conta1.ExibirInformacoes();

        Console.ReadKey();
    }
}
