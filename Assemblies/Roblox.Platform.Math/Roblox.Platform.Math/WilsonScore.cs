using System;
using Roblox.Platform.Math.Statistics;

namespace Roblox.Platform.Math;

public static class WilsonScore
{
	/// <summary>
	/// Calculates the lower bound of Wilson score confidence interval for a Bernoulli parameter
	/// http://www.evanmiller.org/how-not-to-sort-by-average-rating.html
	/// </summary>
	/// <param name="positiveValues">The count of the positive values.</param>
	/// <param name="totalValue">The total count of values.</param>
	/// <param name="confidence">The value of the confidence. This value must be between 0 and 1.</param>
	/// <returns>The value of the wilson score.</returns>
	/// <exception cref="T:System.ArgumentException">Throws if <paramref name="confidence" /> is not between 0 and 1.</exception>
	public static double Calculate(double positiveValues, double totalValue, double confidence)
	{
		double negative = totalValue - positiveValues;
		double zScore = ZScore.Calculate(confidence);
		double zSquared = zScore * zScore;
		double voteScore = 0.0;
		if (totalValue > 0.0 && positiveValues >= 0.0 && negative >= 0.0)
		{
			double num = (positiveValues + zSquared / 2.0) / totalValue;
			double secondTerm = zScore * System.Math.Sqrt(positiveValues * negative / totalValue + zSquared / 4.0) / totalValue;
			double denominator = 1.0 + zSquared / totalValue;
			voteScore = (num - secondTerm) / denominator;
		}
		return voteScore;
	}
}
