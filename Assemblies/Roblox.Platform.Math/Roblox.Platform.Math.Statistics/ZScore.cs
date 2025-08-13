using System;

namespace Roblox.Platform.Math.Statistics;

/// <summary>
/// This implementation was transcribed from:
/// http://www.fourmilab.ch/rpkp/experiments/analysis/zCalc.html
/// </summary>
internal static class ZScore
{
	private const double _ZMax = 6.0;

	/// <summary>
	/// Calculates the z score
	/// </summary>
	/// <param name="confidence">Confidence percentile, must be between 0 and 1.</param>
	/// <returns>The normal z score</returns>
	/// <exception cref="T:System.ArgumentException">Throws if <paramref name="confidence" /> is not between 0 and 1.</exception>
	internal static double Calculate(double confidence)
	{
		if (confidence < 0.0 || confidence > 1.0)
		{
			throw new ArgumentException($"Probability {confidence} must be between 0 and 1.");
		}
		return System.Math.Abs(CalculateCriticalNormalZ(CalculateRightSideQuantile(confidence)));
	}

	/// <summary>
	/// Converts a confidence to the right side quantile when calculating the Z Score.
	/// e.g .95 -&gt; .975
	/// </summary>
	/// <param name="confidence">The confidence </param>
	/// <returns>The right side quantile confidence.</returns>
	private static double CalculateRightSideQuantile(double confidence)
	{
		return (1.0 + confidence) / 2.0;
	}

	/// <summary>
	/// Compute critical normal z value to produce given p.
	/// Bisection search for a value within CHI_EPSILON, relying on the monotonicity of pochisq.
	/// </summary>
	/// <param name="p"></param>
	/// <returns></returns>
	private static double CalculateCriticalNormalZ(double p)
	{
		double minz = -6.0;
		double maxz = 6.0;
		double zval = 0.0;
		if (p < 0.0 || p > 1.0)
		{
			return -1.0;
		}
		while (maxz - minz > 1E-06)
		{
			if (ProbabilityOfNormalZ(zval) > p)
			{
				maxz = zval;
			}
			else
			{
				minz = zval;
			}
			zval = (maxz + minz) * 0.5;
		}
		return zval;
	}

	/// <summary>
	/// Calculates the probability of normal z value.
	/// Adapted from a polynomial approximation in: Ibbetson D, Algorithm 209 Collected Algorithms of the CACM 1963 p. 616
	/// This routine has six digit accuracy, so it is only useful for absolute z values &lt;= 6.
	/// </summary>
	/// <param name="z"></param>
	/// <returns>The probability of normal Z. For z values &gt; to 6.0, returns 0.0.</returns>
	private static double ProbabilityOfNormalZ(double z)
	{
		double x;
		if (z == 0.0)
		{
			x = 0.0;
		}
		else
		{
			double y = 0.5 * System.Math.Abs(z);
			if (y > 3.0)
			{
				x = 1.0;
			}
			else if (y < 1.0)
			{
				double w = y * y;
				x = ((((((((0.000124818987 * w - 0.001075204047) * w + 0.005198775019) * w - 0.019198292004) * w + 0.059054035642) * w - 0.151968751364) * w + 0.319152932694) * w - 0.5319230073) * w + 0.797884560593) * y * 2.0;
			}
			else
			{
				y -= 2.0;
				x = (((((((((((((-4.5255659E-05 * y + 0.00015252929) * y - 1.9538132E-05) * y - 0.000676904986) * y + 0.001390604284) * y - 0.00079462082) * y - 0.002034254874) * y + 0.006549791214) * y - 0.010557625006) * y + 0.011630447319) * y - 0.009279453341) * y + 0.005353579108) * y - 0.002141268741) * y + 0.000535310849) * y + 0.999936657524;
			}
		}
		if (!(z > 0.0))
		{
			return (1.0 - x) * 0.5;
		}
		return (x + 1.0) * 0.5;
	}
}
