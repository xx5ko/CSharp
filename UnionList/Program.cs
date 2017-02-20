using System;
using System.Collections.Generic;
using System.Linq;

namespace UnionList
{
	public class Program
	{
		public static void Main()
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

			var numberOfTempLists = int.Parse(Console.ReadLine());

			var tempList = new List<int>();

			for (int i = 0; i < numberOfTempLists; i++)
			{
				tempList = Console.ReadLine().Split().Select(int.Parse).ToList();

				var removeFromPrimalList = numbers.Except(tempList).ToList();
				var addToPrimalList = tempList.Except(numbers).ToList();

				var conjunctiveList = removeFromPrimalList.Union(addToPrimalList).ToList();

				numbers = conjunctiveList.ToList();
			}
			var listToPrint = numbers.OrderBy(x => x).ToList();
			Console.WriteLine($"{string.Join(" ", listToPrint)}");
		}
	}
}