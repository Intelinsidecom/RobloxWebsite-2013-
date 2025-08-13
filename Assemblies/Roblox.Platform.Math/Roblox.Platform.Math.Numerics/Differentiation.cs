using System;

namespace Roblox.Platform.Math.Numerics;

public static class Differentiation
{
	public static double ComputeFirstDerivative(double y_i, double y_im1, DateTime x_i, DateTime x_im1, TimeUnits units)
	{
		double timeSpan = ComputeTimeSpan(x_i, x_im1, units);
		if (timeSpan != 0.0)
		{
			return (y_i - y_im1) / timeSpan;
		}
		return 0.0;
	}

	public static double ComputeSecondDerivative(double y_i, double y_im1, double y_im2, DateTime x_i, DateTime x_im1, DateTime x_im2, TimeUnits units)
	{
		double timeSpan = ComputeTimeSpan(x_i, x_im2, units);
		return (y_i - 2.0 * y_im1 + y_im2) / System.Math.Pow(0.5 * timeSpan, 2.0);
	}

	public static double[] DifferentiateSeries(double[] input)
	{
		double[] diff = new double[input.Length - 1];
		for (int i = 0; i < diff.Length; i++)
		{
			diff[i] = input[i + 1] - input[i];
		}
		return diff;
	}

	private static double ComputeTimeSpan(DateTime x_i, DateTime x_im1, TimeUnits units)
	{
		TimeSpan timeSpan = x_i - x_im1;
		return units switch
		{
			TimeUnits.Seconds => timeSpan.TotalSeconds, 
			TimeUnits.Minutes => timeSpan.TotalMinutes, 
			TimeUnits.Hours => timeSpan.TotalHours, 
			_ => timeSpan.TotalMilliseconds, 
		};
	}
}
