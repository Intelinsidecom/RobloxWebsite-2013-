using System;
using System.Threading;

namespace Roblox.Random;

/// <summary>
/// Represents an <see cref="T:Roblox.Random.IRandom" /> that uses a <see cref="T:System.Threading.ThreadLocal`1" /> <see cref="T:System.Random" />.
/// </summary>
/// <seealso cref="T:Roblox.Random.IRandom" />
/// <seealso cref="T:System.Random" />
/// <seealso cref="T:System.Threading.ThreadLocal`1" />
public class ThreadLocalRandom : IRandom
{
	private readonly ThreadLocal<System.Random> _Random;

	private readonly LongRandom _LongRandom;

	private int _Seed;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Random.ThreadLocalRandom" /> class, using the specified seed.
	/// </summary>
	/// <param name="initialSeed">The initial seed.</param>
	public ThreadLocalRandom(int initialSeed)
	{
		_Seed = initialSeed;
		_Random = new ThreadLocal<System.Random>(() => new System.Random(Interlocked.Increment(ref _Seed)));
		_LongRandom = new LongRandom(NextBytes);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Random.ThreadLocalRandom" /> class, using a time dependent seed value.
	/// </summary>
	public ThreadLocalRandom()
		: this(Environment.TickCount)
	{
	}

	/// <inheritdoc />
	public int Next()
	{
		return _Random.Value.Next();
	}

	/// <inheritdoc />
	public int Next(int maxValue)
	{
		return _Random.Value.Next(maxValue);
	}

	/// <inheritdoc />
	public int Next(int minValue, int maxValue)
	{
		return _Random.Value.Next(minValue, maxValue);
	}

	/// <inheritdoc />
	public double NextDouble()
	{
		return _Random.Value.NextDouble();
	}

	/// <inheritdoc />
	public void NextBytes(byte[] buffer)
	{
		_Random.Value.NextBytes(buffer);
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
