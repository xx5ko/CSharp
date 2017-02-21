using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
	class FlipListSides
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

			for (int i = 1; i < input.Count / 2; i++)
			{
				int temp = input[i];
				input[i] = input[input.Count - i - 1];
				input[input.Count - i - 1] = temp;
			}

			Console.WriteLine(string.Join(" ", input));
		}
	}
}