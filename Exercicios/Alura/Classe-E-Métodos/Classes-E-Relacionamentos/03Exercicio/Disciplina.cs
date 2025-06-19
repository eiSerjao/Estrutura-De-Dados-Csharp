using System.ComponentModel;

namespace _03Exercicio;
//A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
public class Disciplina
{
    public string NomeDisciplina { get; set; }
    public List<Aluno> AlunoMatriculados { get; set; } = new List<Aluno>();

    public Disciplina(string NomeDisciplina)
    {
        this.NomeDisciplina = NomeDisciplina;
        AlunoMatriculados = new List<Aluno>();
    }

    public void ExibirInformações()
    {
        Console.WriteLine($"A Materia {NomeDisciplina} possui esse alunos matriculados");
        if (!AlunoMatriculados.Any())
        {
            Console.WriteLine("Não a aluno matriculado nessa matéria");
            return;
        }

        foreach (var alunos in AlunoMatriculados)
        {
            Console.WriteLine(alunos.Nome);
        }
    }

}
