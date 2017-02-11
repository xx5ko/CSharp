using System;
using System.Linq;

namespace LargestElementinArray
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];

			var max = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				int currentNumbers = int.Parse(Console.ReadLine());
				numbers[i] = currentNumbers;
				max = numbers.Max();

			}
			Console.WriteLine(max);
		}
	}
}