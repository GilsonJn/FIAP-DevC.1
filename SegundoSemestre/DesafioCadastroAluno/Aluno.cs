using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCadastroAluno
{
    internal class Aluno
    {

        Dictionary<int, string> alunos = new Dictionary<int, string>();

        public void AdicionarAluno()
        {
            Console.Write("Digite o id do aluno: ");
            string id = Console.ReadLine();

            // Validar se o id é um número inteiro
            if (!int.TryParse(id, out int idAluno))
            {
                Console.WriteLine("ID inválido. Por favor, digite um número inteiro.");
                return;
            }

            // Verificar se o id já existe
            if (alunos.ContainsKey(idAluno))
            {
                Console.WriteLine("ID já cadastrado. Por favor, escolha outro ID.");
                return;
            }

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            // Validar se o nome não está vazio
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome inválido. Por favor, digite um nome válido.");
                return;
            }

            alunos.Add(idAluno, nome);
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }

        public void ListarAlunos()
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }
            Console.WriteLine("=== Lista de Alunos ===");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"ID: {aluno.Key}, Nome: {aluno.Value}");
            }

            // Contando o total 
            Console.WriteLine($"\nTotal de alunos cadastrados: {alunos.Count}");
        }

        public void BuscarAluno()
        {
            Console.Write("Digite o ID do aluno que deseja buscar: ");
            string id = Console.ReadLine();

            // Validar se o id é um número inteiro
            if (!int.TryParse(id, out int idAluno))
            {
                Console.WriteLine("ID inválido. Por favor, digite um número inteiro.");
                return;
            }
            if (alunos.TryGetValue(idAluno, out string nomeAluno))
            {
                Console.WriteLine($"Aluno encontrado: ID: {idAluno}, Nome: {nomeAluno}");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado com o ID fornecido.");
            }
        }
    }
}
