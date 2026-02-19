using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    // abstract -> não permite que seja instanciado objetos
    abstract class Veiculo
    {
        // protected -> torna o atributo seja acessa na propria classe ou na classe herdada
        protected string placa;
        protected string chassi;
        protected string cor;
        protected string motor;

        bool motorLigado;
        protected int pessoas;
        protected int capacidadePessoa;
        protected float estadoTanque;

        public void LigarMotor()
        {
            motorLigado = true;
        }

        public void DesligarMotor()
        {
            motorLigado = false;
        }

        public int EstadoTanque()
        {
            return (int)(estadoTanque * 100);
        }

        public void AdicionarPessoas(int pessoas)
        {
            if (pessoas > capacidadePessoa)
            {
                Console.WriteLine("Não é possível adicionar " + pessoas + " pessoas. A capacidade máx. é " + capacidadePessoa);
            }

            this.pessoas += pessoas;
        }

        // Método virtual -> pode ser sobrescrito, mas não é obrigatório
        // Método abstrato -> deve ser sobrescrito em todas as classes filhas
        public virtual string VerificarPessoas()
        {
            return "Existe " + this.pessoas + " pessoas no " + this.GetType().Name + " contando com o motorista";
        }

    }
}
