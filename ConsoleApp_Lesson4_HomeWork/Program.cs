using System;

namespace ConsoleApp_Lesson4_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите размер массива");
                    var index = ReadNum();

                if (index < 2)
                {
                    Console.WriteLine("Нельзя чтобы индекс был меньше 2");
                    throw new ArgumentException("Нельзя чтобы индекс был меньше 2");
                }

                Console.WriteLine("Введите элемент массива");
                    var array = new int[index];

                    for(int i = 0; i < index; i++)
                    {
                        array[i] = ReadNum();
                    Console.WriteLine($"index {i}");
                    }

                Console.WriteLine("Массив:");
                foreach (var number in array)
                {
                    Console.Write($"{number}" + " ");
                }

                Array.Sort(array);

                Console.WriteLine("\nСортированный массив:");
                foreach (var number in array)
                {
                    Console.Write($"{number}" + " ");
                }
                Console.WriteLine($"\nВторой максимальный элемент массива: {array[index - 2]}");
                break;
            }
        }

        public static int ReadNum()
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out var result))
                {
                    return result;
                }
                Console.WriteLine("Пробуй ещё раз");
            }
        }
    }
}
