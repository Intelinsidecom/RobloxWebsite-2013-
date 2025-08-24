using System;
using System.Collections.Generic;

namespace Roblox.Collections;

public static class Partitioner
{
	public static IEnumerable<ICollection<T>> SplitIntoChunks<T>(List<T> allItems, int maxChunkSize)
	{
		for (int i = 0; i < allItems.Count; i += maxChunkSize)
		{
			int length = Math.Min(maxChunkSize, allItems.Count - i);
			yield return allItems.GetRange(i, length);
		}
	}
}
