// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
            Subtracao();
        }

        static void Soma()

        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.Write($"O Resultado da soma: {resultado}");
            Console.ReadLine();
        }
        static void Subtracao()
        {

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            if (v1 < v2)
            {
                Console.WriteLine("O primeiro valor deve ser maior ou igual ao segundo valor");
            }
            else
            {
                float resultado = v1 - v2;
                Console.WriteLine($"Resultado da subtracao: {resultado} ");
            };

        }
    }


}
