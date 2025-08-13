using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Roblox.Common;

public class RoundRobin<T>
{
	private readonly T[] _Candidates;

	private int _CurrentIndex;

	public RoundRobin(IEnumerable<T> elements)
	{
		_Candidates = elements.ToArray();
	}

	public T Next()
	{
		int index = Interlocked.Increment(ref _CurrentIndex);
		if (index >= _Candidates.Length)
		{
			_CurrentIndex = 0;
			return _Candidates[0];
		}
		return _Candidates[index];
	}
}
