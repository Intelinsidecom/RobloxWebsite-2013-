using System;

namespace Roblox.Classification;

internal class Range<T> : IComparable<Range<T>> where T : IComparable<T>
{
	public T Start { get; }

	public T End { get; }

	public Range(T start, T end)
	{
		Start = start;
		End = end;
	}

	public bool Contains(T value)
	{
		if (Start.CompareTo(value) <= 0)
		{
			return End.CompareTo(value) >= 0;
		}
		return false;
	}

	public int CompareTo(Range<T> other)
	{
		return Start.CompareTo(other.Start);
	}
}
