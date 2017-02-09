using System;
using System.Linq;


namespace RefactorSpecialNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			for (int i = 1; i <= num; i++)
			{
				int temporaryN = i;
				int sum = 0;
				while (temporaryN > 0)
				{
					sum += temporaryN % 10;
					temporaryN /= 10;
				}
				bool special = false;
				special = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine($"{i} -> {special}");
				sum = 0;
			}
		}
	}
}
