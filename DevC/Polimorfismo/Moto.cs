using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Moto : Veiculo
    {
        string modelo;

        public Moto(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoa = 2;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            Random random = new Random();
            chassi = random.Next().ToString("00000000000000000");
        }

        // override -> sobrescreve o método da classe mãe
        public override string VerificarPessoas()
        {
            return "Existe " + this.pessoas + " pessoas na Moto contando com o piloto";
        }
    }
}
