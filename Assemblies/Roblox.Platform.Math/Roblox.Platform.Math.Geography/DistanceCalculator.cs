using System;

namespace Roblox.Platform.Math.Geography;

public static class DistanceCalculator
{
	/// <summary>
	/// Calculates distance in miles between two locations
	/// </summary>
	public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
	{
		double rlat1 = System.Math.PI * lat1 / 180.0;
		double rlat2 = System.Math.PI * lat2 / 180.0;
		double theta = lon1 - lon2;
		double rtheta = System.Math.PI * theta / 180.0;
		return System.Math.Acos(System.Math.Sin(rlat1) * System.Math.Sin(rlat2) + System.Math.Cos(rlat1) * System.Math.Cos(rlat2) * System.Math.Cos(rtheta)) * 180.0 / System.Math.PI * 60.0 * 1.1515;
	}
}
