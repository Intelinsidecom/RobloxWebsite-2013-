using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.Security.Codes;

/// <inheritdoc />
public class RandomCodeAuthority : IRandomCodeAuthority
{
	private readonly Random _Random;

	public RandomCodeAuthority()
	{
		_Random = new Random();
	}

	/// <inheritdoc />
	public string Generate(string characters, int length)
	{
		if (string.IsNullOrWhiteSpace(characters))
		{
			throw new PlatformArgumentException("characters");
		}
		if (length <= 0)
		{
			throw new PlatformArgumentException(string.Format("{0} must be positive", "length"));
		}
		char[] result = new char[length];
		for (int i = 0; i < length; i++)
		{
			result[i] = RandomChar(characters);
		}
		return new string(result);
	}

	[ExcludeFromCodeCoverage]
	internal virtual char RandomChar(string characters)
	{
		return characters[_Random.Next(characters.Length)];
	}
}
