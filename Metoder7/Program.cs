using System;

namespace Metoder7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            Console.WriteLine(calculator(double.Parse(Console.ReadLine())));
        }

        static string calculator(double input)
        {
            double define = input / 2;

            for (int i = 1; i < define; i++)
            {
                if (input % 2 == 0)
                {
                    return "Talet är inte ett Primtal";
                }
                else
                {
                    return "Talet är ett Primtal";
                }
            }
            return "AAAAA";
        }
    }
}