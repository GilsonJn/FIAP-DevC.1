using CP1_Cadastro;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadastro<Pessoa> cadastro = new Cadastro<Pessoa>();
            bool continuar = true;
            string id = "";

            while (continuar)
            {
                //Console.Clear();
                Console.WriteLine("=== SISTEMA DE CADASTRO ===");
                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Apagar");
                Console.WriteLine("5. Sair");

                string opcao = Console.ReadLine();

                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o id: ");
                        id = Console.ReadLine();

                        // Validar se o id é um número inteiro
                        if (!int.TryParse(id, out int idPessoa))
                        {
                            Console.WriteLine("ID inválido. Por favor, digite um número inteiro.");
                            return;
                        }

                        Console.Write("Digite o nome: ");
                        string nomeInput = Console.ReadLine();
                        Pessoa nome = new Pessoa { Nome = nomeInput };
                        cadastro.Adicionar(idPessoa, new Pessoa { Nome = nomeInput });

                        break;

                    case "2":
                        cadastro.Listar();
                        break;

                    case "3":
                        Console.Write("Digite o ID que deseja buscar: ");
                        id = Console.ReadLine();

                        // Validar se o id é um número inteiro
                        if (!int.TryParse(id, out int idPessoaFind))
                        {
                            Console.WriteLine("ID inválido. Por favor, digite um número inteiro.");
                            return;
                        }

                        cadastro.Buscar(idPessoaFind);
                        break;

                    case "4":
                        Console.WriteLine("Digite o ID da pessoa que deseja deletar:");
                        id = Console.ReadLine();

                        // Validar se o id é um número inteiro
                        if (!int.TryParse(id, out int idPessoaDelete))
                        {
                            Console.WriteLine("ID inválido. Por favor, digite um número inteiro.");
                            return;
                        }
                        cadastro.Apagar(idPessoaDelete);
                        break;

                    case "5":
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