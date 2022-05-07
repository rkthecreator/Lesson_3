using System;

namespace Классы_и_Методы_урок3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Добро пожаловать в калькулятор целых чисел.");
            Console.WriteLine("Введите первое целое число:");
            var value1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Введите второе целое число:");
            var value2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Результат:");
            Summ(value1, value2);
            Subtract(value1, value2);
            Divide(value1, value2);
            Multiply(value1, value2);
            Residual(value1, value2);
            
        }


        public static void Summ(int value1, int value2)
        {
            Console.WriteLine($"Result of summ: {value1 + value2}");
        }

        public static void Subtract(int value1, int value2)
        {
            Console.WriteLine($"Result of subtraction: {value1 - value2}");
        }

        public static void Divide(int value1, int value2)
        {
            Console.WriteLine($"Result of division: {value1 / value2}");
        }

        public static void Multiply(int value1, int value2)
        {
            Console.WriteLine($"Result of multiplication: {value1 * value2}");
        }

        public static void Residual(int value1, int value2)
        {
            Console.WriteLine($"Result of finding residual: {value1 % value2}");
        }
    }



    public class Item
    {
        public int Value;
    }

}

