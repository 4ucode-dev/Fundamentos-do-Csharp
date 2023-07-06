using System;

namespace Aula02
{
    class Program
    {
        static void main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.WriteLine("O resultado da soma é " + (v1 + v2));
            Console.WriteLine("O resultado da soma é " + v1 + v2);
        }
    }
}
