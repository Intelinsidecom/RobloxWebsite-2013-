using Roblox.FloodCheckers.Core;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents a group of login <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" />.
/// </summary>
internal interface ILoginFloodCheckers
{
	/// <summary>
	/// A <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> to flood check by user on login.
	/// </summary>
	IFloodChecker FailedLoginByUserFloodChecker { get; }

	/// <summary>
	/// A <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> to flood check on failed login.
	/// </summary>
	IFloodChecker FailedLoginFloodCheckerSet { get; }

	/// <summary>
	/// A <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> to flood check on successful login.
	/// </summary>
	IFloodChecker SuccessfulLoginFloodChecker { get; }
}
