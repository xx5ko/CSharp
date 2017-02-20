﻿using System;
using System.Linq;

namespace CamelsBack
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var buildings = Console.ReadLine().Split().Select(int.Parse).ToList();
			var camelBack = int.Parse(Console.ReadLine());
			var rounds = 0;

			while (buildings.Count > camelBack)
			{
				buildings.RemoveAt(0);
				buildings.RemoveAt(buildings.Count - 1);
				rounds++;
			}
			if (rounds == 0)
			{
				Console.WriteLine("already stable: {0}", string.Join(" ", buildings));
			}
			else
			{
				Console.WriteLine($"{rounds} rounds");
				Console.WriteLine("remaining: {0}", string.Join(" ", buildings));
			}
		}
	}
}
