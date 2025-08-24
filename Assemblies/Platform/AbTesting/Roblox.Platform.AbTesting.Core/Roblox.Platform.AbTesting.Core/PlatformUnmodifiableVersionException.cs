using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// The exception thrown when illegal modifications to an experiment version are attempted.
/// </summary>
public class PlatformUnmodifiableVersionException : PlatformException
{
	public PlatformUnmodifiableVersionException()
	{
	}

	public PlatformUnmodifiableVersionException(string message)
		: base(message)
	{
	}

	public PlatformUnmodifiableVersionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
