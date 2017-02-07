﻿using System;

namespace SmallestElementInArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var stringArray = Console.ReadLine().Split();
            var array = new int[stringArray.Length];

            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(stringArray[i]);

            var smallest = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < smallest)
                    smallest = array[i];
            Console.WriteLine(smallest);

        }
    }
}
