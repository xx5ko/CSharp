using System;

namespace DrawAFilledSquare
{
	class MainClass
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintHeader(n);
			PrintMiddle(n);
			PrintHeader(n);
		}

		private static void PrintMiddle(int n)
		{
			for (int i = 0; i < n - 2; i++)
			{
				Console.Write("-");
				for (int j = 1; j < n; j++)
				{
					Console.Write("\\/");
				}
				Console.WriteLine("-");
			}
		}

		private static void PrintHeader(int n)
		{
			Console.WriteLine(new string('-', n * 2));
		}
	}
}