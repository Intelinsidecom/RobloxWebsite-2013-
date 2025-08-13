using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Membership;

/// <summary>
/// Exception thrown for age bracket being explicitly set when user's birthdate is already set.
/// </summary>
public class ExplicitAgeBracketWithBirthdateException : PlatformException
{
	public ExplicitAgeBracketWithBirthdateException(DateTime birthdate)
		: base($"Cannot explicitly set age bracket after birthdate is set. ({birthdate:yyyy-MM-dd})")
	{
	}
}
