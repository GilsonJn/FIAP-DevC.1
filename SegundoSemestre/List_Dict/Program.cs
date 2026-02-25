using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício 1
            List<string> produtos = new List<string>();

            produtos.Add("Camiseta");
            produtos.Add("Calça");
            produtos.Add("Tênis");
            produtos.Add("Boné");
            produtos.Add("Jaqueta");

            Console.WriteLine("Produtos disponíveis:");

            foreach (string item in produtos)
            {
                Console.WriteLine(item);
            }

            produtos.Remove("Boné");

            Console.WriteLine("\nProdutos disponíveis após remoção:");

            foreach (string item in produtos)
            {
                Console.WriteLine(item);
            }

            // Exercício 2
            Dictionary<string, int> agenda = new Dictionary<string, int>();
            agenda.Add("Alice", 123456789);
            agenda.Add("Maria", 987654321);
            agenda.Add("João", 555555555);

            Console.WriteLine("\nAgenda de contatos:");

            if (agenda.ContainsKey("Alice"))
            {
                Console.WriteLine($"Número de Alice: {agenda["Alice"]}");
            }

            if (agenda.TryGetValue("Maria", out int telefone))
            {
                Console.WriteLine($"Número de Maria: {telefone}");
            }
            else
            {
                Console.WriteLine("Contato não encontrada na agenda.");

            }
        }
    }
}