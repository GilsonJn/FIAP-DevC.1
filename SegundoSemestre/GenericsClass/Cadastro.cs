using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    internal class Cadastro<T>
    {
        private Dictionary<int, T> registros = new Dictionary<int, T>();

        public void Salvar(int id, T registro) 
        { 
            registros[id] = registro;
        }

        public T BuscarPorId(int id)
        {
            if(registros.ContainsKey(id))
            {
                return registros[id];
            }

            Console.WriteLine($"Registro com ID {id} não encontrado.");
            return default;

        }

    }
}
