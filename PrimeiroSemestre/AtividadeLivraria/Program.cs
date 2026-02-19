using AtividadeLivraria;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("AAA", "Jonas", 2002, "10/10/2002");
            Livro livro2 = new Livro("BBB", "Maria", 2010, "15/05/2010");

            livro1.Detalhes();
            Console.WriteLine(livro1.Status());

            livro2.Detalhes();
            livro2.Emprestado();
            Console.WriteLine(livro2.Status());

        }
    }
}