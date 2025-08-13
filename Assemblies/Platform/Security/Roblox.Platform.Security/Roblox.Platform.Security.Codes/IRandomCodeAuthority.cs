namespace Roblox.Platform.Security.Codes;

/// <summary>
/// Provides the hability to generate random codes. The codes are not persisted.
/// </summary>
public interface IRandomCodeAuthority
{
	/// <summary>
	/// Returns a code consisting using the given characters.
	/// </summary>
	/// <param name="characters">All the charracters allowed in this code. <see cref="T:Roblox.Platform.Security.Codes.RandomCodeCharacters" /></param>
	/// <param name="length">The amount of characters the code should have</param>
	/// <returns>The code of lenght <paramref name="length" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	///     If <paramref name="characters" /> is empty or null
	///     If <paramref name="length" /> is not positive
	/// </exception>
	string Generate(string characters, int length);
}
