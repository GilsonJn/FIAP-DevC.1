using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    internal class Servico<T>
    {
        private Dictionary<int, T> dados = new();

        public void Adicionar(int id, T item)
        {
            dados[id] = item;
        }

        public T BuscarPorId(int id)
        {
            if (dados.TryGetValue(id, out T item))
            {
                return item;
            }
            else
            {
                throw new KeyNotFoundException($"Item com ID {id} não encontrado.");
            }
        }
    }
}
