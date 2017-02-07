using System;

namespace SumArrayElements
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var numbers = int.Parse(Console.ReadLine());
            var array = new int[numbers];

            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine(sum);
        }
    }
}
