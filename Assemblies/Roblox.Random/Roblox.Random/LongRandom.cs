using System;

namespace Roblox.Random;

/// <summary>
/// Used to abstract logic for NextLong which is the same between all known IRandom implementations.
/// </summary>
internal class LongRandom
{
	private readonly Action<byte[]> _NextBytes;

	public LongRandom(Action<byte[]> nextBytes)
	{
		_NextBytes = nextBytes ?? throw new ArgumentNullException("nextBytes");
	}

	public long NextLong(long minValue, long maxValue)
	{
		if (minValue < 0)
		{
			throw new ArgumentOutOfRangeException("minValue");
		}
		if (minValue > maxValue)
		{
			throw new ArgumentOutOfRangeException("maxValue");
		}
		byte[] buffer = new byte[8];
		_NextBytes(buffer);
		long returnValue = BitConverter.ToInt64(buffer, 0);
		returnValue = returnValue % (maxValue - minValue) + minValue;
		if (returnValue == long.MinValue)
		{
			return NextLong(minValue, maxValue);
		}
		if (returnValue < 0)
		{
			return Math.Abs(returnValue);
		}
		return returnValue;
	}
}
