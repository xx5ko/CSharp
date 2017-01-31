using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;

namespace StringEncryption
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;





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

            var asciiCode = (uint) currentChar;

            var lastDigit = asciiCode % 10; // взима последна цифра на int
            var firstDigit = asciiCode; // взима последна цифра на int
            var result = $"{firstDigit}{lastDigit}";
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            return lastDigit = V;

            return asciiCode.ToString();

        }
    }
}

