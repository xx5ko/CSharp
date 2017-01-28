using System;

namespace DistanceOfTheStars
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			decimal earthToStar = 4.22m;
			decimal centerGalaxy = 26000;
			decimal milkyWay = 100000;
			decimal distanceFromEarth = 46500000000;

			decimal  lightyear = 9450000000000;

			earthToStar = earthToStar * lightyear;
			centerGalaxy = centerGalaxy * lightyear;
			milkyWay = milkyWay * lightyear;
			distanceFromEarth = distanceFromEarth * lightyear;

			Console.WriteLine(earthToStar.ToString("e2"));
			Console.WriteLine(centerGalaxy.ToString("e2"));
			Console.WriteLine(milkyWay.ToString("e2"));
			Console.WriteLine(distanceFromEarth.ToString("e2"));

		}
	}
}
