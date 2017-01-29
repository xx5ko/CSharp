using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int a = int.Parse(Console.ReadLine());
			char b = char.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());



			switch ("b")
			{
				case "*": Console.WriteLine(a + b + c + "=" + (a * c));
				case "+": Console.WriteLine(a + b + c + "=" + (a + c));
				case "-": Console.WriteLine(a + b + c + "=" + (a - c));
				case "/": Console.WriteLine(a / c);
			}
		}
	}
}

