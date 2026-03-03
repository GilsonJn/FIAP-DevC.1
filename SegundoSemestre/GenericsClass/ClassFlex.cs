using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Generico

{

    internal class ClassFlex<T1, T2> 

    {

        public T1 addres { get; set; }
        public T2 value { get; set; }

        public void Mostrar()
        {
            Console.WriteLine(value.ToString() + ", " + addres.ToString());
        }

    }

}

