using System;

namespace RefactorSpecialNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int maxNumber kolko = int.Parse(Console.ReadLine());
			int obshto sum = 0; int takova = 0; bool toe = false;
			for (int ch = 1; ch <= maxNumber; ch++)
			{
				currentNumber = ch;
				while (ch > 0)
				{
					result += ch % 10;
					ch = ch / 10;
				}
				IAsyncResult toe = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine($"{currentNumber} -> {result}");
				sum = 0;
				ch = takova;
			}

		}
		}
	}
}
