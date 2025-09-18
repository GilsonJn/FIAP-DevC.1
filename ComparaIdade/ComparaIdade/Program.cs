using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String aluno1, aluno2;
            int age1, age2;

            Console.WriteLine("Insira o seu nome do primeiro aluno: ");
            aluno1 = Console.ReadLine();

            Console.WriteLine("Insira a idade desse aluno:");
            age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o seu nome do segundo aluno: ");
            aluno2 = Console.ReadLine();

            Console.WriteLine("Insira a idade desse aluno:");
            age2 = int.Parse(Console.ReadLine());

            if (age1 > age2)
            {
                Console.WriteLine($"{aluno1} é o mais velho e o {aluno2} é o mais novo.");
            }
            if (age2 > age1)
            {
                Console.WriteLine($"{aluno2} é o mais velho e o {aluno1} é o mais novo.");
            }
            if (age1 == age2)
            {
                Console.WriteLine("Ambos os alunos têm a mesma idade.");
            }
        }
    }
}