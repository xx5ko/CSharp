using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
	class Program10
	{
		static void Main(string[] args)
		{

			List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			List<int> right = new List<int>();
			List<int> left = new List<int>();

			for (int i = 0; i < input.Count / 2; i++)
			{
				left.Add(input[i]);
			}
			for (int i = input.Count / 2; i < input.Count; i++)
			{
				right.Add(input[i]);
			}

			List<int> result = new List<int>();

			for (int i = 0; i < left.Count; i++)

			{
				result.Add(right[i] / 10);
				result.Add(left[i]);
				result.Add(right[i] % 10);
			}
			Console.WriteLine(string.Join(" ", result));
		}
	}
}