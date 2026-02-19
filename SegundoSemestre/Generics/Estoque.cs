using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Estoque<T>
    {
        private List<T> itens = new List<T>();
        private int contador = 0;

        public void Adicionar (T item)
        {
            itens.Add(item);
            Console.WriteLine($"Item adicionado: {item}");
        }

        public void Remover(int id)
        {
            T itemRemovido = itens[id];
            itens.RemoveAt(id);
        }

        public T BuscaPorId(int id)
        {
            return itens[id];
        }

        public List<T> ListarTodos()
        {
            return itens;
        }

    }
}
