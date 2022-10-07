using System;
using System.Collections.Generic;

namespace Task_2409
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Звдача 1");
            Console.Write("Введи высоту (в см) форточки a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введи ширину (в см) форточки b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введи диаметр (в см) головы d = ");
            int d = int.Parse(Console.ReadLine());
            if (d + 1 < a & d + 1 < b)
            {
                Console.WriteLine("Ты можешь высунуть голову");
            }
            else
            {
                Console.WriteLine("Ты не можешь высунуть голову");
            }


            Console.ReadKey();
            Console.WriteLine("Задача 2");
            Console.WriteLine("Введи число n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }

            Console.ReadKey();
            Console.WriteLine("Задача 3");
            Console.Write("Введи число: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Бум");

            }
            else if (num % 5 == 0 & num % 3 == 0)
            {
                Console.WriteLine("БэнгБум");

            }
            else
            {
                Console.WriteLine("Мимо");
            }


            Console.ReadKey();
            Console.WriteLine("Задача 4");
            Console.Write("Введи строку: ");
            string str = Console.ReadLine();
            Console.WriteLine(Upp(str));


            Console.ReadKey();
            Console.WriteLine("Задача 5");
            Console.Write("Введи количество овец: ");
            int sheep = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sheep; i++)
            {
                Console.WriteLine($"{i} овца");

            }

            Console.ReadKey();
            Console.WriteLine("Задача 6");

            int sum = 0;
            int number = 0;
            int count = -1;
            Console.WriteLine("Введи последовательность неотрицательных целых чисел, оканчивающаяся отрицательным числом");
            try
            {
                while (number >= 0)
                {
                    sum += number;
                    count += 1;
                    number = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"среднее арифметическое = {sum/count}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ты ввел строку а не число");
            }


            Console.ReadKey();
            Console.WriteLine("Задача 7");
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number == 6)
                {
                    Console.WriteLine("шестерка");
                }
                else if (number == 7)
                {
                    Console.WriteLine("семерка");
                }
                else if (number == 8)
                {
                    Console.WriteLine("восьмерка");
                }
                else if (number == 8)
                {
                    Console.WriteLine("девятка");
                }
                else if (number == 10)
                {
                    Console.WriteLine("десятка");
                }
                else if (number == 11)
                {
                    Console.WriteLine("валет");
                }
                else if (number == 12)
                {
                    Console.WriteLine("дама");
                }
                else if (number == 13)
                {
                    Console.WriteLine("король");
                }
                else
                {
                    Console.WriteLine("(6 <=k <= 14)");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ты ввел строку а не число");
            }
            Console.ReadKey();
            Console.WriteLine("Задача 8");
            var list_string = new List<string>() { "Tom", "Hello Kitty", "Barbie doll" };
            int sum_Hello_Kitty = 0;
            int sum_Barbie_doll = 0;
            foreach (string st in list_string)
            {
                if (st == "Hello Kitty")
                {
                    sum_Hello_Kitty++;
                }
                else if (st == "Barbie doll")
                {
                    sum_Barbie_doll++;
                }
            }
            Console.WriteLine($"Hello Kitty = {sum_Hello_Kitty}, Barbie doll = {sum_Barbie_doll}, всего {sum_Barbie_doll + sum_Hello_Kitty} куклол");

            Console.ReadKey();
            Console.WriteLine("Задача 9");
            Console.Write("Введите номер дня недели: ");
            int day = int.Parse(Console.ReadLine());
            string week = Enum.GetName(typeof(Week), day);
            Console.WriteLine(week);


            Console.ReadKey();
            Console.WriteLine("Задача 10");
            int[] numbers = { 3, 2, 7, 1 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers = BubbleSort(numbers);
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.WriteLine("Задача 11");
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 8, 7, 9, 10 };
            int c = 1;
            for (int i = 0; i < numbers2.Length - 1; i++)
            {
                if (!(numbers2[i] <= numbers2[i + 1]))
                {
                    Console.WriteLine("не верное последовательность");
                    break;
                }
                else
                {
                    c++;
                }
            }
            if (c == numbers2.Length)
            {
                Console.WriteLine("Все верно");
            }

            Console.ReadKey();




        }
        static int[] BubbleSort(int[] numbers)
        {
            int[] numbers_copy = numbers;
            int copy;
            for (int i = 0; i < numbers_copy.Length; i++)
            {
                for (int j = i + 1; j < numbers_copy.Length; j++)
                {
                    if (numbers_copy[i] > numbers_copy[j])
                    {
                        copy = numbers_copy[i];
                        numbers_copy[i] = numbers_copy[j];
                        numbers_copy[j] = copy;
                    }
                }

            }
            return numbers_copy;
        }
        enum Week
        {
            monday = 1,
            tuesday,
            Wednesday,
            Thursday,
            friday,
            saturday,
            sunday

        }
        public static bool Upp(string str)
        { return (str == str.ToUpper()); }


    }
}

