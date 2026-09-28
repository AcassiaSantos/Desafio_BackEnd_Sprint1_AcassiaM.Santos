using System;
using System.Collections.Generic;

public class Professor : Pessoa
{
    public double Salario { get; set; }

    public List<Turma> Turmas { get; set; }

    public Professor(
        string nome,
        string cpf,
        DateTime dataNascimento,
        double salario)
        : base(nome, cpf, dataNascimento)
    {
        Salario = salario;
        Turmas = new List<Turma>();
    }

    public void AdicionarTurma(Turma turma)
    {
        Turmas.Add(turma);
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Data de nascimento: {DataNascimento:dd/MM/yyyy}");
        Console.WriteLine($"Salário: R$ {Salario:F2}");

        Console.WriteLine("Turmas:");

        foreach (Turma turma in Turmas)
        {
            Console.WriteLine($"- {turma.Nome}");
        }
    }
}