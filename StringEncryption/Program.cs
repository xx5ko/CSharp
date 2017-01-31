﻿using System;

namespace StringEncryption
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            Console.WriteLine(Encrypt(result));

            for (int i = 0; i < n; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());
                var encrypted = Encrypt(currentChar);

                result += encrypted;
            }

            Console.WriteLine(result);

        }

        static string Encrypt(char currentChar)
        {

            var asciiCode = (int) currentChar;

            var firstDigit = GetFirstDigit(asciiCode);
            var lastDigit = GetLastDigit(asciiCode);

            var firstSymbol = (char)(asciiCode + lastDigit);
            var lastSymbol = (char) (asciiCode - firstDigit);

            var result = $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";
            return result;
        }

        private static int GetLastDigit(int asciiCode)
        {
            return asciiCode % 10; // взима последна цифра на int
        }

        static int GetFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode; // взима последна цифра на int
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            return firstDigit;
        }
    }
}

