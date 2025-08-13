using System.Collections.Generic;
using Roblox.Random;

namespace Roblox.Collections;

public class CollectionSampler
{
	private readonly IRandom _Random;

	public CollectionSampler(IRandom random)
	{
		_Random = random;
	}

	public IList<T> GetSample<T>(IList<T> elements, int sampleSize)
	{
		if (sampleSize >= elements.Count)
		{
			return elements;
		}
		int lastIndex = elements.Count;
		List<T> sample = new List<T>();
		while (lastIndex > 0 && sample.Count < sampleSize)
		{
			lastIndex--;
			int randomLocation = _Random.Next(0, lastIndex);
			T randomElement = elements[randomLocation];
			elements[randomLocation] = elements[lastIndex];
			sample.Add(randomElement);
		}
		return sample;
	}
}
