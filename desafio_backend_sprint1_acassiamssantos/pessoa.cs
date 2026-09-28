using System;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }

    public Pessoa(string nome, string cpf, DateTime dataNascimento)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
    }

    public abstract void ExibirDados();
}