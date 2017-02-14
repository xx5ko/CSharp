using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
	class ArraySymmetry
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split(' ').ToArray();
			bool isSymetric = false;

			var rev = words.Reverse().ToArray();

			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == rev[i])
				{
					isSymetric = true;
				}
				else
				{
					isSymetric = false;
					break;
				}
			}
			if (isSymetric == true)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}

		}
	}
}