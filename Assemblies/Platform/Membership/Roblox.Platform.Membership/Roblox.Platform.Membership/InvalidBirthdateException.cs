using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Membership;

/// <summary>
/// Exception thrown for a birthday that is invalid according to <see cref="T:Roblox.Platform.Membership.IBirthdateValidator" />.
/// </summary>
public class InvalidBirthdateException : PlatformException
{
	public InvalidBirthdateException()
		: base("Invalid Birthdate")
	{
	}

	internal InvalidBirthdateException(DateTime? birthdate)
		: base($"The birthday supplied is not valid. ({birthdate:yyyy-MM-dd})")
	{
	}
}
