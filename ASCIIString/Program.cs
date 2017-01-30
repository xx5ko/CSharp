using System;

namespace ASCIIString
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var number = int.Parse(Console.ReadLine());
			string result = "";
			for (int i = 0; i < number; i++)
			{
				char ConvertToChar = (char)int.Parse(Console.ReadLine());
				result = result + ConvertToChar;
			}
			Console.WriteLine(result);
		}
	}
}

	