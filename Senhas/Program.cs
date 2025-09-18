using System;

class Program
{
    static void Main(string[] args)
    {
        // Array de números que formam a senha
        int[] listaNumeros = { 5, 6, 4, 13 };

        Console.WriteLine("Digite 4 números separados por espaço:");
        string[] entrada = Console.ReadLine().Split(' ');

        // Verifica se o usuário digitou 4 números
        if (entrada.Length != listaNumeros.Length)
        {
            Console.WriteLine("Você deve digitar exatamente 4 números.");
            return; // encerra o programa imediatamente
        }

        // Loop para validar cada número digitado
        for (int i = 0; i < listaNumeros.Length; i++)
        {
            int numeroDigitado;

            // Valida se realmente foi digitado um número
            if (!int.TryParse(entrada[i], out numeroDigitado))
            {
                Console.WriteLine($"A posição {i + 1} não é um número válido.");
                continue; // volta para a próxima iteração do loop
            }

            // Compara o número digitado com o número correto da senha
            if (numeroDigitado != listaNumeros[i])
            {
                Console.WriteLine("Senha incorreta!");
                break; // sai do loop ao encontrar um erro
            }

            // Se chegou aqui, o número está correto
            if (i == listaNumeros.Length - 1)
            {
                Console.WriteLine("Senha correta! Acesso permitido.");
            }
        }
    }
}
