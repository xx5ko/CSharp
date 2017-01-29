using System;

namespace IncrementVariable
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			long number = long.Parse(Console.ReadLine());
			var bytex = 256;

			if (number <= bytex)
			{
				Console.WriteLine(number);
			}
			else if (number > bytex)
			{
				Console.WriteLine(number % bytex);
				Console.WriteLine("Overflowed {0} times", (number / bytex));
			}
		}
	}
}
