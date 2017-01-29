using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int a;

			int b;

			string mathSymbol;

			float result;


			a = Convert.ToInt32(Console.ReadLine());

			mathSymbol = Console.ReadLine();

			b = Convert.ToInt32(Console.ReadLine());



			switch (mathSymbol)

			{

				case "-":

					result = a - b;

					break;

				case "+":

					result = a + b;

					break;

				case "/":

					result = a / b;

					break;

				case "*":

					result = a * b;

					break;

				default:

					result = 0;

					break;

			}



			Console.WriteLine(a.ToString() + " " + mathSymbol + " " + b.ToString() + " = " + result.ToString());

		}

	}
}