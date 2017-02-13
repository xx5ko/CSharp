using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStringsDebugging
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			bool areaAllEqual = true;
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] != numbers[i + 1])
				{
					areaAllEqual = false;
					break;
				}
			}
			if (areaAllEqual)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}