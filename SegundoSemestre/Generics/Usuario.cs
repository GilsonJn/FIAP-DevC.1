using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Usuario
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
