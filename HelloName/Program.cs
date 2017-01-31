using System;

namespace HelloName
{
	class MainClass
	{
		private static void Main(string[] args)
		{
			string name = Console.ReadLine();

			string helloName = NameWithHello(name);

			Console.WriteLine(helloName);
		}

		static string NameWithHello(string name)
		{
			
			string fullName = "Hello" + ", " + name + "!";
			return fullName;

		}

	}
}
