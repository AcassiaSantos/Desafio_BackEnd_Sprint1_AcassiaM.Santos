using System;
using System.Collections.Generic;

public class Aluno : Pessoa
{
    public string Matricula { get; set; }

    public List<double> Notas { get; set; }

    public Aluno(
        string nome,
        string cpf,
        DateTime dataNascimento,
        string matricula)
        : base(nome, cpf, dataNascimento)
    {
        Matricula = matricula;
        Notas = new List<double>();
    }

    public void AdicionarNota(double nota)
    {
        Notas.Add(nota);
    }

    public double CalcularMedia()
    {
        if (Notas.Count == 0)
        {
            return 0;
        }

        double soma = 0;

        foreach (double nota in Notas)
        {
            soma += nota;
        }

        return soma / Notas.Count;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Data de nascimento: {DataNascimento:dd/MM/yyyy}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Média: {CalcularMedia():F2}");
    }
}