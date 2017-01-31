﻿using System;
using System.Globalization;

namespace NthDigit
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());
            var digitAtIndex = FindNthDigit(number, index);

            Console.WriteLine(digitAtIndex);

        }

        static int FindNthDigit(long number, int index)
        {
            var currentIndex = 1;

            while (number > 0)
            {
                if (currentIndex == index)
                {

                    return (int) (number % 10);
                }

                currentIndex++
                ((int)(number /= 10));
            }
            return (int) (number % 10);
        }
    }
}