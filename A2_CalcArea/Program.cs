using System;

namespace MyApp
{
    internal class Program
    {
        static String nome;
        static int opcao = 0;


        /// <summary>
        /// Função com SOBRECARGA STRING
        /// </summary>
        /// <param name="value">Valor que deseja imprimir</param>
        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Função com SOBRECARGA double
        /// </summary>
        /// <param name="value">Valor que deseja imprimir</param>
        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Função que calcula da area do CIRCULO
        /// </summary>
        /// <param name="value">Raio do circulo</param>
        /// <returns>Area do Circulo</returns>
        static double AreaCirculo(double value)
        {
            double area = 0;
            area = Math.Pow(value, 2) * Math.PI;
            return area;
        }

        /// <summary>
        /// Função que calcula da area do TRIANGULO
        /// </summary>
        /// <param name="baseTri">Base do triangulo</param>
        /// <param name="altura">Altura do triangulo</param>
        /// <returns>Area do triangulo</returns>
        static double AreaTriangulo(double baseTri, double altura)
        {
            double area = 0;
            area = (baseTri * altura) / 2;
            return area;
        }

        /// <summary>
        /// Função que calcula da area do RETANGULO
        /// </summary>
        /// <param name="baseReta">Base do retangulo</param>
        /// <param name="altura">Altura do retangulo</param>
        /// <returns>Area do retangulo</returns>
        static double AreaRetangulo(double baseReta, double altura)
        {
            double area = 0;
            area = baseReta * altura;
            return area;
        }

        static void Main(string[] args)
        {
            Print("Digite seu nome: ");
            nome = Console.ReadLine();

            Print(nome + " escolha a conta que deseja");
            Print("1 - Area do Cirlulo 2 - Area do Triangulo 3 - Area do Retangulo");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                double raio = 0;

                Print("Insira o raio:");
                raio = double.Parse(Console.ReadLine());

                double area = AreaCirculo(raio);

                Print("A area do circulo é " + area);
            }
            if (opcao == 2)
            {
                double baseTriangulo = 0;
                double altura = 0;

                Print("Insira a base do triangulo:");
                baseTriangulo = double.Parse(Console.ReadLine());

                Print("Insira a altura do triangulo:");
                altura = double.Parse(Console.ReadLine());

                double area = AreaTriangulo(baseTriangulo, altura);

                Print("A area do triangulo é " + area);
            }
            if (opcao == 3)
            {
                double baseRetangulo = 0;
                double altura = 0;

                Print("Insira a base do Retangulo:");
                baseRetangulo = double.Parse(Console.ReadLine());

                Print("Insira a altura do Retangulo:");
                altura = double.Parse(Console.ReadLine());

                double area = AreaRetangulo(baseRetangulo, altura);

                Print("A area do Retangulo é " + area);
            }
        }
    }
}

