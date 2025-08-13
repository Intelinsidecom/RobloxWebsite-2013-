using System;
using System.Collections.Generic;

namespace Roblox.Common.NetStandard;

public class LambdaComparer<T> : IEqualityComparer<T>
{
	private readonly Func<T, T, bool> _LambdaComparer;

	private readonly Func<T, int> _LambdaHash;

	public LambdaComparer(Func<T, T, bool> lambdaComparer)
		: this(lambdaComparer, (Func<T, int>)((T o) => 0))
	{
	}

	public LambdaComparer(Func<T, T, bool> lambdaComparer, Func<T, int> lambdaHash)
	{
		_LambdaComparer = lambdaComparer ?? throw new ArgumentNullException("lambdaComparer");
		_LambdaHash = lambdaHash ?? throw new ArgumentNullException("lambdaHash");
	}

	public bool Equals(T x, T y)
	{
		return _LambdaComparer(x, y);
	}

	public int GetHashCode(T obj)
	{
		return _LambdaHash(obj);
	}
}
