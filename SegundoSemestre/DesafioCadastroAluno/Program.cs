using DesafioCadastroAluno;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();
            bool continuar = true;

            while (continuar)
            {
                //Console.Clear();
                Console.WriteLine("=== SISTEMA DE CADASTRO DE ALUNOS ===");
                Console.WriteLine("1. Cadastrar aluno");
                Console.WriteLine("2. Listar alunos");
                Console.WriteLine("3. Buscar Aluno");
                Console.WriteLine("4. Sair");

                string opcao = Console.ReadLine();

                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        aluno.AdicionarAluno();
                        break;

                    case "2":
                        aluno.ListarAlunos();
                        break; 

                    case "3":
                        aluno.BuscarAluno();
                        break;

                    case "4":
                        continuar = false;
                        Console.WriteLine("Saindo do sistema. Até logo!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}