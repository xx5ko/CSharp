using System;

namespace RefactorVolumeOfPyramid
{
	class MainClass
	{
		public static void Main(string[] args)
		{
				
			double width, sh, lenght = 0;
			Console.Write("Length: ");

			width = double.Parse(Console.ReadLine());
			Console.Write("Width: ");

			heigh = double.Parse(Console.ReadLine());
			Console.Write("Heigth: ");

			lenght = double.Parse(Console.ReadLine());
			lenght = (width + sh + lenght) / 3;
			Console.WriteLine("Pyramid Volume: {0:F2}", lenght);
		}
	}
}
