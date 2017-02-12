using System;
using System.Linq;

namespace CountOfNegativeElementsInArray
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];

			var count = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());
				arr[i] = currentNumber;

				if (arr[i] < 0)
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}
}
