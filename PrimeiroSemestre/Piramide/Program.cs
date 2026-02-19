using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ETAPA 1: Definindo as variaveis

            int altura = 0;            // Quantidade de linhas da Pirâmide
            int linha = 0;             // Contagem das linhas       
            String caracter = null;    // Caracter usado pra montar a pirâmide


            // ETAPA 2: Entrada de dados

            Console.WriteLine("Digite a altura da sua pirâmide: (Uma escolha comum é entre 5 a 10 linhas.)");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual caracter deseja montar sua pirâmide (ex: *, #, A): ");
            caracter = Console.ReadLine();

            Console.WriteLine("\n--- Sua pirâmide ---\n");

            // ETAPA 3: Loop While para gerar a Pirâmide

            while (linha <= altura)
            {
                for (int i = 0; i < (altura - linha + 1); i++)
                {
                    Console.Write(" "); // Imprime espaços em branco
                }

                for (int i = 0; i < linha; i++)
                {
                    Console.Write(caracter); // Imprime os caracteres, montando a pirâmide
                }

                Console.WriteLine(); // Pula a linha
                linha++;
            }


        }
    }
}