namespace _01Exercicio;

/*
Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, 
como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
*/
public class Conta
{
    private Titular Titular { get; set; }
    private string Agencia { get; set; }
    private string NumeroConta { get; set; }
    private decimal Saldo { get; set; }
    private decimal Limite { get; set; }

    public Conta(Titular titular, string agencia, string numeroConta, decimal saldom, decimal limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldom;
        Limite = limite;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da Conta:");
        Console.WriteLine($"Titular: {Titular.Nome}");
        Console.WriteLine("Agência: " + Agencia);
        Console.WriteLine("Número da Conta: " + NumeroConta);
        Console.WriteLine("Saldo: " + Saldo.ToString("C"));
        Console.WriteLine("Limite: " + Limite.ToString("C"));
    }
}
