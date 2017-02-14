using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
	class Program
	{
		static void Main(string[] args)
		{
			string Strarray = Console.ReadLine();
			int[] numbers = Strarray.Split().Select(int.Parse).ToArray();
			bool increasing = false;
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] < numbers[i + 1])
				{
					increasing = true;
				}
				else
				{
					increasing = false;
					Console.WriteLine("No");
					break;

				}
			}
			if (increasing)
			{
				Console.WriteLine("Yes");
			}
		}
	}
}