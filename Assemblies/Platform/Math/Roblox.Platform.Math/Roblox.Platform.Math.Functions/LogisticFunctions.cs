using System;

namespace Roblox.Platform.Math.Functions;

public static class LogisticFunctions
{
	/// <summary>
	/// Computes a logistic curve.
	/// </summary>
	/// <remarks>
	/// https://en.wikipedia.org/wiki/Logistic_function
	/// </remarks>
	/// <param name="m">Slope of the line at inflection point.</param>
	/// <param name="k">Vertical size of curve, positive numbers for up, negative for down.</param>
	/// <param name="b">y-intercept (Moves the line vertically).</param>
	/// <param name="c">x-value of inflection point (Moves the line horizontally).</param>
	/// <param name="x">The input value.</param>
	/// <returns>f(x)</returns>
	public static float Compute(float m, float k, float b, float c, float x)
	{
		return b + k * (1f / (1f + (float)System.Math.Pow(System.Math.E * 1000.0 * (double)m, c - x)));
	}
}
