using Roblox.Platform.Security.Properties;

namespace Roblox.Platform.Security.Codes;

/// <summary>
/// Provides access to the characters to be used in the <see cref="T:Roblox.Platform.Security.Codes.IRandomCodeAuthority" />
/// </summary>
public static class RandomCodeCharacters
{
	/// <summary>
	/// Numeric string
	/// </summary>
	public static string Numbers => Settings.Default.NumberCharacters;
}
