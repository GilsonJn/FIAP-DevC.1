using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1_Cadastro
{
    internal class Cadastro<T>
    {
        private Dictionary<int, T> pessoas = new Dictionary<int, T>();

        public void Adicionar(int id, T nome)
        {

            // Verificar se o id já existe
            if (pessoas.ContainsKey(id))
            {
                Console.WriteLine("ID já cadastrado. Por favor, escolha outro ID.");
                return;
            }

            pessoas.Add(id, nome);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
        }

        public void Listar()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
                return;
            }
            Console.WriteLine("=== Lista ===");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"ID: {pessoa.Key}, Nome: {pessoa.Value}");
            }

            // Contando o total 
            Console.WriteLine($"\nTotal de pessoas cadastradas: {pessoas.Count}");
        }

        public void Buscar(int id)
        {
            if (pessoas.TryGetValue(id, out T nomePessoa))
            {
                Console.WriteLine($"Pessoa encontrada: ID: {id}, Nome: {nomePessoa}");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrado com o ID fornecido.");
            }
        }

        public void Apagar(int id)
        {
            if (pessoas.TryGetValue(id, out T nomePessoa))
            {
                pessoas.Remove(id);
                Console.WriteLine($"{nomePessoa} foi deletada com sucesso!");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrado com o ID fornecido.");
            }
        }
    }
}
