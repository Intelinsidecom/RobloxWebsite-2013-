using System;

namespace Roblox.Platform.Marketing;

public class RandomNumberFactory
{
	public int GetRandomNumberBetween0AndN(int n)
	{
		return new Random(new object().GetHashCode()).Next(n + 1);
	}
}
