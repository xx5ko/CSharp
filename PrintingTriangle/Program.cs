﻿using System;

namespace PrintingTriangle
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			var n = int.Parse(Console.ReadLine());

			PrintTriangle(n);

		}
		static void PrintTriangle(int n)
		{

			for (int i = 1; i <= n; i++)
			{
				PrintLine(i);
			}

			for (int i = n - 1; i >= 1; i--)
			{
				PrintLine(i);
			}
		}

		static void PrintLine(int size, int start = 1)
		{
			for (int i = 1; i <= size; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}
