using System;

namespace TerabytesToBits
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			double n = double.Parse(Console.ReadLine());

			ulong bytes = 8796093022208;

			Console.WriteLine(n * bytes);
		}
	}
}