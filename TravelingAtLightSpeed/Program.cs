using System;

namespace TravelingAtLightSpeed
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			decimal n = int.Parse(Console.ReadLine());

			decimal lightYear = 9450000000000; //km
			decimal speedLightForSecond = 300000; //km.second

			decimal speedLightForHours = speedLightForSecond / 60;
			decimal speedLightForDays = speedLightForHours / 24;
			decimal speedLightForWeeks = speedLightForDays / 7;
			decimal speedLightForEarthYear = speedLightForDays / 365;




			// lightyeartoconvert
			decimal Weeks = (speedLightForEarthYear  52) * n;
			decimal Days = speedLightForDays / lightYear;
			decimal Hours = speedLightForHours / lightYear;
		    decimal Minutes = Hours / lightYear;
			decimal Second = Minutes / 60;
	

			//Seconds = ;

			Console.WriteLine(Weeks);
		}
	}
}
