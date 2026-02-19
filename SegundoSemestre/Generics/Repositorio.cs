using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Repositorio<T>
    {
        // Array chamado itens do tipo T, com capacidade para 10 elementos
        private T[] itens = new T[10];
        private int contador = 0;

        public void Adicionar(T item) 
        {
            itens[contador++] = item;
        }

        public T Obter(int indice)
        {
            return itens[indice];
        }

    }
}
