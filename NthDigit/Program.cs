using System;
using System.Collections.Generic;

namespace NthDigit
{
    internal class Program
    {
        class NthDigit
        {
            public static void Main(string[] args)
            {
                var number = long.Parse(Console.ReadLine());
                var index = int.Parse(Console.ReadLine());

                var digitAtIndex = FindDigit(number, index);
                Console.WriteLine(digitAtIndex);

            }

            static int FindDigit(long number, int index)
            {
                var currentIndex = 1;
                while (number > 0)
                {
                    if (currentIndex == index)
                    {

                        return (int) (number % 10);
                    }

                    currentIndex++;
                    number /= 10;
                }
                return (int) (number % 10);
            }
        }
    }
}