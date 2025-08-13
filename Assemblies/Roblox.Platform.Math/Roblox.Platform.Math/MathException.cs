using System;

namespace Roblox.Platform.Math;

public sealed class MathException : Exception
{
	public MathException(string message)
		: base(message)
	{
	}

	public MathException(string message, Exception innerEx)
		: base(message, innerEx)
	{
	}
}
