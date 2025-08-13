using System;

namespace Roblox.Platform.Math.Numerics;

/// <summary>
/// NOTE: This class will extrapolate if the x value is outside of the range provided for the slope; buyer beware.
/// </summary>
public static class Interpolation
{
	public static double LinearlyInterpolate(double y_i, double y_im1, DateTime x_i, DateTime x_im1, DateTime x)
	{
		return y_im1 + (y_i - y_im1) / (x_i - x_im1).TotalDays * (x - x_im1).TotalDays;
	}

	public static double? LinearlyInterpolate(double? y_i, double? y_im1, DateTime? x_i, DateTime? x_im1, DateTime x)
	{
		if (!y_i.HasValue || !y_im1.HasValue || !x_i.HasValue || !x_im1.HasValue)
		{
			return null;
		}
		return LinearlyInterpolate(y_i.Value, y_im1.Value, x_i.Value, x_im1.Value, x);
	}

	public static double LinearlyInterpolate(double y_i, double y_im1, double x_i, double x_im1, double x)
	{
		return y_im1 + (y_i - y_im1) / (x_i - x_im1) * (x - x_im1);
	}
}
