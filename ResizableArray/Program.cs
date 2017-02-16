using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizableArray
{
	class ResizableArray
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ').ToArray();

			List<int> result = new List<int>();

			while (!input[0].Equals("end"))
			{

				if (input[0].Equals("push"))
				{
					result.Add(int.Parse(input[1]));
				}
				else if (input[0].Equals("pop"))
				{
					result.RemoveAt(result.Count - 1);
				}
				else if (input[0].Equals("removeAt"))
				{
					result.RemoveAt(int.Parse(input[1]));
				}
				else if (input[0].Equals("clear"))
				{
					result.Clear();
				}

				input = Console.ReadLine().Split(' ').ToArray();
			}

			Console.WriteLine(string.Join(" ", result));
		}
	}
}