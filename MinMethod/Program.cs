using System;

namespace MinMethod
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			int firstMinimum = GetMin(a, b, c);
			Console.WriteLine();
			Console.WriteLine(firstMinimum);
		}


		static int GetMin(int a, int b, int c)
		{
			int firstMinimum = Math.Min(a, b);

			if (firstMinimum > c)
			{
				return c;
			}
			else
			{
				return firstMinimum;
			}
		}
	}
}

