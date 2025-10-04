using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Carro : Veiculo
    {
        string modelo;

        public Carro(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoa = 4;
            this.placa = placa;
            this.modelo = modelo;
            Random random = new Random();

            chassi = random.Next().ToString("00000000000");
        }
    }
}
