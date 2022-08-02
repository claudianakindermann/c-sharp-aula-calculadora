// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string option = "0";

            Console.Clear();
            Console.WriteLine("************* CALCULATOR *************");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("Choose an option:");

            option = Console.ReadLine();

            switch (option)
            {
                case "1": Soma(); break;
                case "2": Subtracao(); break;
                case "3": Multiplicacao(); break;
                case "4": Divisao(); break;
                case "5": System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()

        {
            Console.WriteLine("Enter the first value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"Result of sum: {resultado}");
            Console.Write("Press enter to continue.");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.WriteLine("Enter the first value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            float v2 = float.Parse(Console.ReadLine());

            if (v1 < v2)
            {
                Console.WriteLine("The first value must be greater than or equal to the second value!");
            }
            else
            {
                float resultado = v1 - v2;
                Console.WriteLine($"Result of subtraction: {resultado} ");
            };
            Console.Write("Press enter to continue.");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Enter the first value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Result of multiplication: " + (v1 * v2));
            Console.Write("Press enter to continue.");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.WriteLine("Enter the first value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            float v2 = float.Parse(Console.ReadLine());

            if (v2 == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                float resultado = v1 / v2;
                Console.WriteLine($"Result of division: {resultado}");
            };
            Console.Write("Press enter to continue.");
            Console.ReadKey();
            Menu();
        }

    }


}
