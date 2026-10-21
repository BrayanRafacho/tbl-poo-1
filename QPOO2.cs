using System;

class Pessoa
{
    public string Nome;
}

class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João";

        Pessoa pessoa2 = pessoa1;

        pessoa2.Nome = "Maria";

        Console.WriteLine("Nome da primeira pessoa: " + pessoa1.Nome);
    }
}
