using System;

namespace Phonebook
{
	class MainClass
	{
		public static void Main()
		{
			string[] phoneNumbers = Console.ReadLine().Split(' ');
			string[] names = Console.ReadLine().Split(' ');

			var result = string.Empty;

			for (int i = 0; ; i++)
			{
				var name = Console.ReadLine();

				if (name == "done")
				{
					break;
				}

				for (int i2 = 0; i2 < names.Length; i2++)
				{
					if (name == names[i2])
					{
						result += $"{names[i2]} -> {phoneNumbers[i2]}" + Environment.NewLine;
					}
				}
			}

			Console.WriteLine(result.Remove(result.Length - 1));
		}
	}
}