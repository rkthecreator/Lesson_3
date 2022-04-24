using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Programm
    {
        public static void Main()
        {
            var value = 10;
            value *= 2;
            value /= 5;
            value += 234;

            var counter = value;
            counter++;

            Console.WriteLine("wow " + value);
            Console.WriteLine("Counter: " + counter);
            Console.WriteLine(value + counter);
            Console.ReadLine();
        }
    }
}