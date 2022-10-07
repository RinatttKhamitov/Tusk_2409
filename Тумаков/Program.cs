using System;

namespace Тумаков
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кл работа 4.1 и 4.2");
            Console.WriteLine("Введи день");
            int day = int.Parse(Console.ReadLine());
            DateTime date = new DateTime();
            if (day > 365 || day < 1)
            {
                Console.WriteLine("ОШИБКА");
            }
            else
            {
                date += new TimeSpan(day, 0, 0, 0);


                Console.WriteLine(date.ToString("MMMM"));
            }
            Console.WriteLine("дз 4.1");
            Console.WriteLine("Введи день");
            day = int.Parse(Console.ReadLine());
            date = new DateTime();
            date += new TimeSpan(day, 0, 0, 0);
            if (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                Console.WriteLine($"год високосный {date.ToString("MMMM")}");
            }
            else
            {
                Console.WriteLine($"год не високосный {date.ToString("MMMM")}");
            }
        }
    }
}
