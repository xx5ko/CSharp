using System;

namespace TriplesOfLatinLetters
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());

			for (char a = 'a'; a < 'a' + n; a++)
			{
				for (char b = 'a'; b < 'a' + n; b++)
				{
					for (char c = 'a'; c < 'a' + n; c++)
					{
						Console.WriteLine($"{a}{b}{c}");
					}
				}
			}
		}
	}
}