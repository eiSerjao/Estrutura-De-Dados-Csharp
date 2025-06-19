/*
Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. 
A classe Aluno deve ter informações como nome, idade e notas. 
A classe Professor deve ter informações sobre nome e disciplinas lecionadas. 
A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
*/

using _03Exercicio;


class Progam
{
    public static void Main(string[] args)
    {
        Aluno aluno = new Aluno(
            "Paulo Sérgio",
            21,
            7
        );

        
        Professor professor = new Professor(
        "Flavio",
        "Matematica"
    );

        Disciplina disciplina = new Disciplina(professor.DisciplinaSelecionada);

        disciplina.AlunoMatriculados.Add(aluno);

        disciplina.ExibirInformações();
    }
}

