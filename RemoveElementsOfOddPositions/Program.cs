using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveElementsOfOddPositions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split().ToList();
			List<string> evenList = new List<string>();

			for (int i = 0; i < input.Count - 1; i++)
			{
				if (i % 2 == 0)
				{
					evenList.Add(input[i + 1]);
				}
			}

			Console.WriteLine(string.Join("", evenList));
		}
	}
}