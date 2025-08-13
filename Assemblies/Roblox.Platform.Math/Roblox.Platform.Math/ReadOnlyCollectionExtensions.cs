using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Math;

public static class ReadOnlyCollectionExtensions
{
	/// <summary>
	/// Normalizes the specified weight values such that the lowest weight is normalized to 0 and the highest weight is normalized to 1.
	/// </summary>
	/// <remarks>
	/// https://en.wikipedia.org/wiki/Standard_score
	/// </remarks>
	/// <typeparam name="T">The type of values that are weighted.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>
	/// The normalized weighted values.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">values</exception>
	public static IEnumerable<Tuple<float, T>> Normalize<T>(this IReadOnlyCollection<Tuple<long, T>> values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		long currentMin = long.MaxValue;
		long currentMax = long.MinValue;
		foreach (Tuple<long, T> kvp2 in values)
		{
			if (kvp2.Item1 > currentMax)
			{
				currentMax = kvp2.Item1;
			}
			if (kvp2.Item1 < currentMin)
			{
				currentMin = kvp2.Item1;
			}
		}
		long delta = currentMax - currentMin;
		if (delta == 0L)
		{
			return values.Select((Tuple<long, T> kvp) => new Tuple<float, T>(1f, kvp.Item2));
		}
		return values.Select((Tuple<long, T> kvp) => new Tuple<float, T>((float)(kvp.Item1 - currentMin) / (float)delta, kvp.Item2));
	}

	/// <summary>
	/// Gets the index of a weighted random element.
	/// </summary>
	/// <param name="weights">The weights.</param>
	/// <param name="seed">The seed.</param>
	/// <returns>
	/// The index of the chosen element from the collection.
	/// </returns>
	/// <exception cref="T:System.ArgumentException">Thrown if <paramref name="weights" /> is empty or contains a negative weight.</exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="weights" /> is null.</exception>
	public static int GetWeightedRandomElementIndex(this IReadOnlyCollection<float> weights, int seed)
	{
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (!weights.Any())
		{
			throw new ArgumentException("weights");
		}
		float total = weights.Sum(delegate(float weight)
		{
			if (weight < 0f)
			{
				throw new ArgumentException("negative weight");
			}
			return weight;
		});
		double randomOffset = new Random(seed).NextDouble() * (double)total;
		float currentOffset = 0f;
		int index = 0;
		foreach (float weight2 in weights)
		{
			currentOffset += weight2;
			if (randomOffset <= (double)currentOffset)
			{
				return index;
			}
			index++;
		}
		throw new ArithmeticException("Mathematical impossibility");
	}
}
