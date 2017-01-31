using System;

namespace StringRepater
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string str = Console.ReadLine();
			int number = int.Parse(Console.ReadLine());

			string repeated = RepearString(str,number);

			Console.WriteLine(repeated);
		}

		static string RepearString(string str, int number)
		{
			string stringToRepeat = str;

			for (int i = 0; i < number; i++)

			{
				Console.Write(stringToRepeat, number);
			}
			return stringToRepeat;

	}
	}
}

