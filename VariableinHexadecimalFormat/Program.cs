using System;

namespace VariableinHexadecimalFormat
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			string code = Console.ReadLine();

			Console.WriteLine(Convert.ToInt32(code, 16));

		}
	}
}
