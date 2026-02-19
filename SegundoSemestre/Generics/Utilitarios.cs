using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class Utilitarios
    {
        // ref: os parâmetros são passados por referência, permitindo que as alterações feitas dentro do método sejam refletidas fora dele.
        public static void TrocarValores<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T MaiorValor<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
