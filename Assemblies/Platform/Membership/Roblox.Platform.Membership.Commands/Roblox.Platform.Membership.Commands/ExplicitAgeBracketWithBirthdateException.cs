using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Exception thrown for age bracket being explicitly set when user's birthdate is already set.
/// </summary>
public class ExplicitAgeBracketWithBirthdateException : PlatformException
{
	/// <summary>
	/// Constructs an <see cref="T:Roblox.Platform.Membership.Commands.ExplicitAgeBracketWithBirthdateException" />.
	/// </summary>
	/// <param name="birthdate">The birthdate that was already set.</param>
	public ExplicitAgeBracketWithBirthdateException(DateTime birthdate)
		: base($"Cannot explicitly set age bracket after birthdate is set. ({birthdate:yyyy-MM-dd})")
	{
	}
}
