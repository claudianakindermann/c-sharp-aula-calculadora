// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("Selecione a opção desejada:");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Console.WriteLine("Escolha uma opção de 1 a 4"); break;
            }
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
                Console.WriteLine($"Resultado da subtração: {resultado} ");
            };

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("Resultado da multiplicação: " + resultado);
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            if (v2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                float resultado = v1 / v2;
                Console.WriteLine($"Resultado da divisão: {resultado}");
            };
        }

    }


}
