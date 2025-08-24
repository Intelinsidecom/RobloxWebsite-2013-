using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Marketing;

/// <summary>
/// An occurance of a Windows 10 App signup
/// </summary>
public interface IWin10AppSignup
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the user than signed up via the Windows 10 App.
	/// </summary>
	IUserIdentifier User { get; }

	/// <summary>
	/// The time that <see cref="P:Roblox.Platform.Marketing.IWin10AppSignup.User" /> signed up.
	/// </summary>
	DateTime Created { get; }
}
