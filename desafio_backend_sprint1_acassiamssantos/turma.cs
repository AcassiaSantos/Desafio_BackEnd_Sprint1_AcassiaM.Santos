public class Turma
{
    public string Nome { get; set; }
    public string Disciplina { get; set; }

    public Turma(string nome, string disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }
}