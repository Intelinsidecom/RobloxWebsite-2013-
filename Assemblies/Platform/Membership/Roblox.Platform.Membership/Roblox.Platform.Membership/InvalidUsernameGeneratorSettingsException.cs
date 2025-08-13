using System;

namespace Roblox.Platform.Membership;

/// <summary>
/// Exception thrown when settings for an <see cref="T:Roblox.Platform.Membership.IUsernameGenerator" /> are invalid
/// </summary>
public class InvalidUsernameGeneratorSettingsException : Exception
{
	public InvalidUsernameGeneratorSettingsException(string message)
		: base(message)
	{
	}
}
