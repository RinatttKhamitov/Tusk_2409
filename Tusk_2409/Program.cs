using System;

namespace Tusk_2409
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи высоту форточки a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введи ширину форточки b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введи диаметр головы d = ");
            int d = int.Parse(Console.ReadLine());
            if (d > a + 1 & d > b + 1)
            {
                Console.WriteLine("");
            }
        }
    }
}
