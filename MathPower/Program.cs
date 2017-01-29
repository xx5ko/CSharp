using System;

namespace MathPower
{
	class MainClass
	{
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			double energy = double.Parse(Console.ReadLine());
			Console.WriteLine($"{MathPower(number, energy)}");
		}

		static double MathPower(double number, double energy)
		{
			double RaisedToPower = Math.Pow(number, energy);
			return RaisedToPower;
		}
	}
}