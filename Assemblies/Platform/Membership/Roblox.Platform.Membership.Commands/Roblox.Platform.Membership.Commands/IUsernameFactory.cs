namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// A factory handling the generation of usernames.
/// </summary>
public interface IUsernameFactory
{
	/// <summary>
	/// Tries to generate the username.
	/// </summary>
	/// <param name="username">The base username, the user is attempting.</param>
	/// <param name="ageBracket">The age bracket.</param>
	/// <param name="mustUsePiiFiltersForU13Usernames">if set to <c>true</c> [should paass through pii filtersout].</param>
	/// <param name="generatedUsername">The generated username.</param>
	/// <returns>
	///   <c>true</c> if the method was able to generate a username successfully, <c>false</c> otherwise.
	/// </returns>
	bool GenerateUserName(string username, AgeBracket ageBracket, bool mustUsePiiFiltersForU13Usernames, out string generatedUsername);
}
