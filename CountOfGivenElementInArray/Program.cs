using System;

namespace CountOfGivenElementInArray
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int[] arr = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			int p = int.Parse(Console.ReadLine());

			var count = 0;

			for (int i = 0; i < arr.Length; i++)
			{

				if (arr[i] == p)
				{
					count++;
				}
			}
			Console.WriteLine(count);

		}
	}
}
