using Polimorfismo;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[4];

            veiculos[0] = new Carro("ABC1234", "Gol", "Prata", "1.0");
            veiculos[1] = new Carro("DEF5678", "Uno", "Branco", "1.0");
            veiculos[2] = new Moto("XYZ9876", "Biz", "Preta", "125cc");
            veiculos[3] = new Pickup("GHI4321", "Ranger", "Azul", "2.2", 700);

            for (int i = 0; i < veiculos.Length; i++)
            {
                veiculos[i].LigarMotor();
                veiculos[i].AdicionarPessoas(2);
                Console.WriteLine(veiculos[i].VerificarPessoas());

            }
        }
    }
}