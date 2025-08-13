using Roblox.FloodCheckers.Core;

namespace Roblox.Web.Authentication.Interfaces;

/// <summary>
/// Represents a group of facebook sign in <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" />.
/// </summary>
internal interface ISignInWithFacebookFloodCheckers
{
	/// <summary>
	/// A <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> to flood check on facebookId
	/// </summary>
	IFloodChecker SignInWithFacebookByFacebookIdFloodChecker { get; }

	/// <summary>
	/// A <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> to flood check on IP address and facebookId
	/// </summary>
	IFloodChecker SignInWithFacebookByIpAndFacebookIdFloodChecker { get; }
}
