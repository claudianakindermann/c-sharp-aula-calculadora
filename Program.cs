// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("v1 = " + v1);
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("v2 = " + v2);
            Console.Write("Resultado da soma:" + Soma(v1, v2));
        }

        private static float Soma(float v1, float v2)
        {
            return v1 + v2;
        }
    }

}
