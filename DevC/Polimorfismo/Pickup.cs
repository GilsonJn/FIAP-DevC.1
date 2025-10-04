using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Pickup : Carro
    {
        float cargaMax;

        public Pickup(string placa, string modelo, string cor, string motor, float cargaMax) : base(placa, modelo, cor, motor)
        {
            capacidadePessoa = 2;
            this.cargaMax = cargaMax;

            Console.WriteLine("Pickup criada com placa: " + placa + 
                ", modelo: " + modelo + 
                ", cor: " + cor + 
                ", motor: " + motor + 
                ", carga máxima: " + cargaMax + " kg.");
        }
    }
}
