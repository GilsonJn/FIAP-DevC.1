using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Exercício 1: Criar uma classe genérica para comparar dois valores
            int i1 = 2;
            int i2 = 3;
            float f1 = 2;

            ComparaClass<int, int> obj1 = new ComparaClass<int, int>();
            obj1.Compare(i1, i2);

        // Exercício 2: Criar um repositório genérico para armazenar e recuperar itens
            Repositorio<string> repositorio = new Repositorio<string>();
            repositorio.Adicionar("Hello");
            repositorio.Adicionar("World");

            string item = repositorio.Obter(1);
            Console.WriteLine(item);

        // Exercício 3: Criar métodos genéricos para trocar valores e encontrar o maior valor
            // Testando o TrocarValores (exige o ref na chamada também)
            int x = 10;
            int y = 20;
            Utilitarios.TrocarValores(ref x, ref y);
            // Agora x é 20 e y é 10!

            // Testando o MaiorValor
            int maiorNumero = Utilitarios.MaiorValor(50, 100); // Retorna 100
            string maiorTexto = Utilitarios.MaiorValor("Ana", "Zebra"); // Retorna "Zebra" (ordem alfabética)
           
            Console.WriteLine(maiorNumero);
            Console.WriteLine(maiorTexto);

        // Exercício 4: Criar uma pilha genérica para armazenar um histórico de ações
            Pilha<string> pilha = new Pilha<string>(5);
            pilha.Empilhar("Primeiro");
            pilha.Empilhar("Segundo");
            pilha.Empilhar("Terceiro");

            Console.WriteLine($"\nTotal de itens no histórico: {pilha.Contar()}");

            string ultimaPeca = pilha.Desempilhar();
            Console.WriteLine($"Item removido do topo: {ultimaPeca}"); // Vai remover o Terceiro
            Console.WriteLine($"Total de itens agora: {pilha.Contar()}");

            string pecaAnterior = pilha.Desempilhar();
            Console.WriteLine($"Item removido do topo: {pecaAnterior}"); // Vai remover o Segundo
            Console.WriteLine($"Total de itens agora: {pilha.Contar()}");

            
            Estoque<string> estoque = new Estoque<string>();
            estoque.Adicionar("Produto A");
            estoque.Adicionar("Produto B");
            estoque.Adicionar("Produto C");
    
            Console.WriteLine("\nItens no estoque:");
            foreach (var itemEstoque in estoque.ListarTodos())
            {
                Console.WriteLine(itemEstoque);
            }
    
            estoque.Remover(1); // Remove o "Produto B"
    
            Console.WriteLine("\nItens no estoque após remoção:");
            foreach (var itemEstoque in estoque.ListarTodos())
            {
                Console.WriteLine(itemEstoque);
            }

        }
    }
}