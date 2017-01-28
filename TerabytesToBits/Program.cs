using System;

namespace TerabytesToBits
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			decimal n = decimal.Parse(Console.ReadLine());

			n = n * 8796093022208;


			Console.WriteLine(n);
		}
	}
}
