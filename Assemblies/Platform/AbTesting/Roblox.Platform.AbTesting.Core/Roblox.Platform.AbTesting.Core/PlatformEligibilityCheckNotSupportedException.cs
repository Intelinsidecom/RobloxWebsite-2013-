using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// The exception thrown when an experiment's eligibility depends on an <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" /> that is not supported.
/// </summary>
public class PlatformEligibilityCheckNotSupportedException : PlatformException
{
	public PlatformEligibilityCheckNotSupportedException()
	{
	}

	public PlatformEligibilityCheckNotSupportedException(string message)
		: base(message)
	{
	}

	public PlatformEligibilityCheckNotSupportedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
