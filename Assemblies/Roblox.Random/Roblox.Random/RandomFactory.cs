using System;
using System.Security.Cryptography;

namespace Roblox.Random;

/// <summary>
/// Represents a factory to create <see cref="T:Roblox.Random.IRandom" /> objects.
/// </summary>
public class RandomFactory : IRandomFactory
{
	private readonly RandomNumberGenerator _CryptoSeedGenerator;

	private readonly IRandom _DefaultRandom;

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Random.RandomFactory" /> class.
	/// </summary>
	public RandomFactory()
	{
		_CryptoSeedGenerator = (RandomNumberGenerator)(object)new RNGCryptoServiceProvider();
		_DefaultRandom = new ThreadLocalRandom(GetCryptoSeed());
	}

	/// <inheritdoc />
	public IRandom GetDefaultRandom()
	{
		return _DefaultRandom;
	}

	private int GetCryptoSeed()
	{
		byte[] buffer = new byte[4];
		_CryptoSeedGenerator.GetBytes(buffer);
		return BitConverter.ToInt32(buffer, 0);
	}
}
