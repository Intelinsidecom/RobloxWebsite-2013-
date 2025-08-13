using System.Collections.Generic;

namespace Roblox.Platform.Math.Numerics;

public static class SequenceGenerator
{
	public static int[] GenerateSequence(int start, int end, int step = 1)
	{
		List<int> sequence = new List<int>();
		for (int value = start; value <= end; value += step)
		{
			sequence.Add(value);
		}
		return sequence.ToArray();
	}

	public static double[] GenerateSequence(double start, double end, double step = 1.0)
	{
		List<double> sequence = new List<double>();
		for (double value = start; value <= end; value += step)
		{
			sequence.Add(value);
		}
		return sequence.ToArray();
	}
}
