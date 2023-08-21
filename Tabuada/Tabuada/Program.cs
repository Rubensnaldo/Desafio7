using System;

namespace TabuadaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número para a tabuada (0 a 10): ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"A tabuada solicitada foi: {numero}\n");

            for (int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}

