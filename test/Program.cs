using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.WriteLine("Задача 10");
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
        public enum Week
        {
            monday = 1,
            tuesday,
            Wednesdayl,
            Thursday,
            friday,
            saturday,
            sunday

        }
    }
}