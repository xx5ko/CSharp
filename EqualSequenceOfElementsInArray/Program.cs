using System;
using System.Linq;

namespace EqualSequenceOfElementsInArray
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("How many friends with same names do you have?");
			int len = int.Parse(Console.ReadLine());
			string[] array = new string[len];
			for (int i = 0; i < len; i++)
			{
				Console.WriteLine("Enter name:");
				array[i] = Console.ReadLine();
			}
			int count = 0;
			int bestCount = 0;
			for (int i = 1; i < len; i++)
			{
				if (array[i] == array[i - 1])
				{
					count++;
					if (count > bestCount)
					{
						bestCount = count;
					}
				}
				else
				{
					count = 1;
				}
			}
			Console.WriteLine(bestCount);
		}
	}
}
