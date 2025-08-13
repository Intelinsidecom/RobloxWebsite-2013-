using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BeIT.MemCached;

internal class RoundRobin<T>
{
	private readonly IReadOnlyCollection<T> _Candidates;

	private int _CurrentIndex;

	public RoundRobin(IReadOnlyCollection<T> elements)
	{
		_Candidates = elements ?? throw new ArgumentNullException("elements");
	}

	public T Next()
	{
		int index = Math.Abs(Interlocked.Increment(ref _CurrentIndex) % _Candidates.Count);
		return _Candidates.ElementAt(index);
	}
}
