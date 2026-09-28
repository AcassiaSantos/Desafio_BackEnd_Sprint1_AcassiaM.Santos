using System;

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno(
            "Maria",
            "12345678900",
            new DateTime(2007, 5, 10),
            "001"
        );

        aluno.AdicionarNota(8);
        aluno.AdicionarNota(9);

        Professor professor = new Professor(
            "João",
            "98765432100",
            new DateTime(1980, 3, 15),
            4500
        );

        Turma turma = new Turma(
            "Turma A",
            "Programação"
        );

        professor.AdicionarTurma(turma);

        Console.WriteLine(@"                                  
                                    
▄████▄ ██     ██  ██ ███  ██ ▄████▄ 
██▄▄██ ██     ██  ██ ██ ▀▄██ ██  ██ 
██  ██ ██████ ▀████▀ ██   ██ ▀████▀ 
                                    

");
        aluno.ExibirDados();

        Console.WriteLine();

        Console.WriteLine(@" 
                                               
█████▄ ▄▄▄▄   ▄▄▄  ▄▄▄▄▄ ▄▄▄▄▄  ▄▄▄▄  ▄▄▄▄  ▄▄▄  ▄▄▄▄  
██▄▄█▀ ██▄█▄ ██▀██ ██▄▄  ██▄▄  ███▄▄ ███▄▄ ██▀██ ██▄█▄ 
██     ██ ██ ▀███▀ ██    ██▄▄▄ ▄▄██▀ ▄▄██▀ ▀███▀ ██ ██ 

");
        professor.ExibirDados();

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para sair...");
        Console.ReadLine();
    }
}