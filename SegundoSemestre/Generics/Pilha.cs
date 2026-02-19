using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Pilha<T>
    {
        private T[] itens;
        private int topo;

        public Pilha(int capacidade = 10)
        {
            itens = new T[capacidade];
            topo = 0;
        }

        public void Empilhar(T item)
        {
            if (topo < itens.Length)
            {
                itens[topo] = item;
                topo++;
            }
            else
            {
                throw new InvalidOperationException("Pilha cheia");
            }
        }

        public T Desempilhar()
        {
            if (topo > 0)
            {
                topo--;
                return itens[topo];
            }
            else
            {
                throw new InvalidOperationException("Pilha vazia");
            }
        }

        public int Contar()
        {
            return topo;
        }
    }
}
