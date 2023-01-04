using System;

class Desafio1
{
    string nome = "Fortnite";

    private static void Main(string[] args)
    {
        Desafio1 program = new Desafio1();

        Console.WriteLine(program.nome + " < " + MudarString(program.nome, "Minecraft"));

        Console.ReadKey();
    }

    private static string MudarString(string variavel, string nome)
    {
        variavel = nome;

        return variavel;
    }
}