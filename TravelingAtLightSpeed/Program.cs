using System;

namespace TravelingAtLightSpeed
{
	class MainClass
	{
		public static void Main(string[] args)
		{
	        decimal lightYears = decimal.Parse(Console.ReadLine());
	        decimal lightYearsToKM = 9450000000000M;
	        decimal lightSpeed = 300000M;
	        decimal total = (lightYearsToKM / lightSpeed) * lightYears;
	        TimeSpan diff = TimeSpan.FromSeconds((double)total);

	        var weeks = diff.Days / 7;
	        var days = diff.Days % 7;
	        var hours = diff.Hours;
	        var minutes = diff.Minutes;
	        var seconds = diff.Seconds;

	        Console.WriteLine($"{weeks} weeks");
	        Console.WriteLine($"{days} days");
	        Console.WriteLine($"{hours} hours");
	        Console.WriteLine($"{minutes} minutes");
	        Console.WriteLine($"{seconds} seconds");
	    }
	}
	}
