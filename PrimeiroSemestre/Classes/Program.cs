using Classes;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro[] carList = new Carro[]
            {
                new Carro("Sedan", "ABC1234", "Vermelho", "V6"),
                new Carro("SUV", "XYZ7890", "Azul", "Elétrico"),
                new Carro("Hatchback", "HCK4567", "Preto", "1.4 Turbo"),
                new Carro("Coupé", "CPE1122", "Branco", "V8"),
                new Carro("Perua", "PRU3344", "Prata", "2.0 Diesel"),
                new Carro("Conversível", "CON5566", "Amarelo", "V6"),
                new Carro("Picape", "PIC7788", "Verde", "3.0 Diesel"),
                new Carro("Minivan", "MIN9900", "Azul Claro", "Híbrido"),
                new Carro("Esportivo", "ESP1213", "Laranja", "V10"),
                new Carro("Compacto", "CMP1415", "Roxo", "1.0")
            };

            foreach (Carro car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}