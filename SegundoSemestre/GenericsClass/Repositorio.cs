using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    internal class Repositorio <T>
    {
        private List<T> itens = new();
       
        public void Adicionar(T item)
        {
            itens.Add(item);
        }
   
        public List<T> Listar()
        {
            return itens;
        }
    }
}
