using System;
using Generico;
using GenericsClass;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 5;

            TrocaValores(ref a, ref b);
            Console.WriteLine("A - " + a);

            ClassFlex<int, string> classFlex = new ClassFlex<int, string>();
            classFlex.addres = 04;
            classFlex.value = "olá";
            classFlex.Mostrar();

            // Exercicio 1
            int num1 = 10;
            int num2 = 20;
            MaiorValor(num1, num2);

            // Exercicio 2
            string item1 = "Tomate";
            string item2 = "Cebola";
            Repositorio<string> repositorio = new Repositorio<string>();
            repositorio.Adicionar(item1);
            repositorio.Adicionar(item2);
            repositorio.Listar().ForEach(item => Console.WriteLine(item));

            // Exercicio 3
            Servico<string> servico = new Servico<string>();
            servico.Adicionar(1, "Cadeira");
            servico.Adicionar(2, "Mesa");
            Console.WriteLine(servico.BuscarPorId(1));

            // MiniDesafio
            // --- TESTE 1: Com tipo STRING ---
            Console.WriteLine("--- CADASTRO DE STRINGS ---");
            Cadastro<string> cadastroTextos = new Cadastro<string>();
            cadastroTextos.Salvar(1, "Desenvolvimento Web");
            cadastroTextos.Salvar(2, "Engenharia de Software");

            string textoBuscado = cadastroTextos.BuscarPorId(1);
            Console.WriteLine($"Busca ID 1: {textoBuscado}\n");


            // --- TESTE 2: Com tipo INT ---
            Console.WriteLine("--- CADASTRO DE NÚMEROS (INT) ---");
            Cadastro<int> cadastroNumeros = new Cadastro<int>();
            cadastroNumeros.Salvar(100, 55420); // Ex: Salvando um CEP ou Código
            cadastroNumeros.Salvar(200, 99887);

            int numeroBuscado = cadastroNumeros.BuscarPorId(200);
            Console.WriteLine($"Busca ID 200: {numeroBuscado}\n");


            // --- TESTE 3: Com a classe PESSOA ---
            Console.WriteLine("--- CADASTRO DE PESSOAS (OBJETO) ---");
            Cadastro<Pessoa> cadastroPessoas = new Cadastro<Pessoa>();
            cadastroPessoas.Salvar(10, new Pessoa { Nome = "Ana Clara" });
            cadastroPessoas.Salvar(11, new Pessoa { Nome = "Carlos Eduardo" });

            Pessoa pessoaBuscada = cadastroPessoas.BuscarPorId(10);
            Console.WriteLine($"Busca ID 10: {pessoaBuscada}");


        }

        public static void TrocaValores<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Exercicio 1
        public static void MaiorValor<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
            {
                Console.WriteLine("O maior valor é: " + a);
            }
            else if (a.CompareTo(b) < 0)
            {
                Console.WriteLine("O maior valor é: " + b);
            }
            else
            {
                Console.WriteLine("Os valores são iguais.");
            }
        }
    }
}