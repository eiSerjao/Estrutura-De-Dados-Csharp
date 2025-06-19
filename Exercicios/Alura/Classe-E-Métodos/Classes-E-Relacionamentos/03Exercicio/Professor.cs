namespace _03Exercicio;
// A classe Professor deve ter informações sobre nome e disciplinas lecionadas.
public class Professor
{
    public string Nome { get; set; }
    public string DisciplinaSelecionada { get; set; }

    public Professor(string nome, string disciplinaSelecionada)
    {
        this.Nome = nome;
        this.DisciplinaSelecionada = disciplinaSelecionada;
    }
}
