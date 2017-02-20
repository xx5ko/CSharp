using System;
using System.Linq;

namespace DistinctList
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			for (int i = 0; i < numbers.Count; i++)
			{
				for (int j = i + 1; j < numbers.Count; j++)
				{
					if (numbers[i] == numbers[j])
					{
						numbers.RemoveAt(j);
						i = 0;
					}
				}
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
