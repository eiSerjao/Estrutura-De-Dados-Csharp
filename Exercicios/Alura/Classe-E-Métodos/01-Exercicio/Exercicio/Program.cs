using System;

class ContaBancaria
{
    // Atributos
    public int numeroIndicar;      // Número identificador da conta
    public string nomeTitular;     // Nome do titular
    public double saldo;           // Saldo da conta
    public string senha;           // Senha da conta

    // Método para exibir as informações da conta
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {nomeTitular}");
        Console.WriteLine($"Saldo: R$ {saldo:F2}");
    }
}

class Program
{
    static void Main()
    {
        // Criando o objeto da conta bancária
        ContaBancaria conta1 = new ContaBancaria();

        // Atribuindo valores aos atributos
        conta1.numeroIndicar = 123456;
        conta1.nomeTitular = "Maria Souza";
        conta1.saldo = 2500.75;
        conta1.senha = "senhaSecreta";

        // Exibindo as informações usando o método da própria classe
        conta1.ExibirInformacoes();

        Console.ReadKey();
    }
}
