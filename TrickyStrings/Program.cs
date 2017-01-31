using System;

namespace TrickyStrings
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string delimiter = Console.ReadLine();
			int number = int.Parse(Console.ReadLine());
			string result = string.Empty;
			string secondResult = string.Empty;
			for (int i = 1; i <= number; i++)
			{
				string toPrint = Console.ReadLine();

				if (i <= number - 1)
				{
					result = result + toPrint + delimiter;
				}
				else
				{
					secondResult = toPrint;

				}

			}
			Console.WriteLine($"{result}{secondResult}");
		}
	}
}
