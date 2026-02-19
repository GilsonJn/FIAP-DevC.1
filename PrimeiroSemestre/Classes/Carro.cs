using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Carro
    {
        private string chassis;
        private string licensePlate;
        private string cor;
        private string motor;

        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            this.chassis = chassis;
            this.licensePlate = licensePlate;
            this.cor = cor;
            this.motor = motor;

        }

        public override string ToString()
        {
            return $"Detalhes do carro: \n" +
                $"Chassis: {chassis} Placa: {licensePlate} Cor: {cor} Motor: {motor}\n";
        }
    }
}
