namespace Roblox.Platform.Membership;

/// <summary>
/// Responsible for generating a username
/// </summary>
public interface IUsernameGenerator
{
	/// <summary>
	/// Generates a username
	/// </summary>
	/// <returns>Generated username</returns>
	string GenerateUsername();
}
