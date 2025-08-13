using System;
using System.Security.Cryptography;

namespace Roblox.Random;

/// <summary>
/// Represents an <see cref="T:Roblox.Random.IRandom" /> adapter for the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class.
/// </summary>
/// <seealso cref="T:Roblox.Random.IRandom" />
/// <seealso cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" />
public class RngCryptoServiceRandom : IRandom
{
	private readonly RandomNumberGenerator _RandomNumberGenerator = (RandomNumberGenerator)(object)new RNGCryptoServiceProvider();

	private readonly LongRandom _LongRandom;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Random.RngCryptoServiceRandom" />.
	/// </summary>
	public RngCryptoServiceRandom()
	{
		_LongRandom = new LongRandom(NextBytes);
	}

	/// <inheritdoc />
	public int Next()
	{
		byte[] data = new byte[4];
		_RandomNumberGenerator.GetBytes(data);
		return BitConverter.ToInt32(data, 0) & 0x7FFFFFFE;
	}

	/// <inheritdoc />
	public int Next(int maxValue)
	{
		return Next(0, maxValue);
	}

	/// <inheritdoc />
	public int Next(int minValue, int maxValue)
	{
		if (minValue > maxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		long range = (long)maxValue - (long)minValue;
		return (int)(long)Math.Floor((double)minValue + (double)range * NextDouble());
	}

	/// <inheritdoc />
	public void NextBytes(byte[] buffer)
	{
		_RandomNumberGenerator.GetBytes(buffer);
	}

	/// <inheritdoc />
	public double NextDouble()
	{
		byte[] data = new byte[4];
		_RandomNumberGenerator.GetBytes(data);
		return (double)BitConverter.ToUInt32(data, 0) / 4294967296.0;
	}

	/// <inheritdoc cref="M:Roblox.Random.IRandom.NextLong" />
	public long NextLong()
	{
		return NextLong(long.MaxValue);
	}

	/// <inheritdoc cref="M:Roblox.Random.IRandom.NextLong(System.Int64)" />
	public long NextLong(long maxValue)
	{
		if (maxValue < 0)
		{
			throw new ArgumentOutOfRangeException("maxValue");
		}
		return NextLong(0L, maxValue);
	}

	/// <inheritdoc cref="M:Roblox.Random.IRandom.NextLong(System.Int64,System.Int64)" />
	public long NextLong(long minValue, long maxValue)
	{
		return _LongRandom.NextLong(minValue, maxValue);
	}
}
