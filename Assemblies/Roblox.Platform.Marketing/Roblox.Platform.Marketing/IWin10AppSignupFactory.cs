using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Marketing;

/// <summary>
/// Provides a common interface for creation of <see cref="T:Roblox.Platform.Marketing.IWin10AppSignup" />s.
/// </summary>
public interface IWin10AppSignupFactory
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Marketing.IWin10AppSignup" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the user that signed up.</param>
	/// <returns>The newly created <see cref="T:Roblox.Platform.Marketing.IWin10AppSignup" /></returns>
	/// <exception cref="!:PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	/// <exception cref="!:PlatformArgumentException">Thrown if <paramref name="user" />'s Id field is the default value.</exception>
	IWin10AppSignup Create(IUserIdentifier user);
}
