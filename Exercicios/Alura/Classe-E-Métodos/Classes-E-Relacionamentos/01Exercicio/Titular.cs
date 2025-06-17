namespace _01Exercicio;

public class Titular
{
    public string Nome { get; set; }
    private string CPF { get; set; }
    private string Endereco { get; set; }

    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        CPF = cpf;
        Endereco = endereco;
    }
}
