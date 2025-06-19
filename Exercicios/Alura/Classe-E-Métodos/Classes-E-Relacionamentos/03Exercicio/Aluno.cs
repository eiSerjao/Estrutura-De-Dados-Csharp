namespace _03Exercicio;

//A classe Aluno deve ter informações como nome, idade e notas. 
public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Nota { get; set; }

    public Aluno(string nome, int idade, double nota)
    {
        Nome = nome;
        Idade = idade;
        Nota = nota;
    }
}
