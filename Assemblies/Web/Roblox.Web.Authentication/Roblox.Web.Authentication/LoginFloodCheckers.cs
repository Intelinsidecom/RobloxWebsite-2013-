using System;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Floodcheckers;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication.Floodcheckers;

namespace Roblox.Web.Authentication;

/// <summary>
/// A class to group login flood checkers.
/// </summary>
internal class LoginFloodCheckers : ILoginFloodCheckers
{
	/// <inheritdoc />
	public IFloodChecker FailedLoginByUserFloodChecker { get; }

	/// <inheritdoc />
	public IFloodChecker FailedLoginFloodCheckerSet { get; }

	/// <inheritdoc />
	public IFloodChecker SuccessfulLoginFloodChecker { get; }

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.LoginFloodCheckers" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="ipAddress">The user's ipAddress</param>
	/// <param name="browserTrackerId">The browser tracker's id passed to the login action.</param>
	public LoginFloodCheckers(IUser user, string ipAddress, ulong browserTrackerId)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new ArgumentException("Ip address can not be null or whitespace", "ipAddress");
		}
		SuccessfulLoginFloodChecker = new LoginFloodChecker(ipAddress, user.Name);
		FailedLoginByUserFloodChecker = new FailedLoginByUserFloodChecker(user);
		FailedLoginByIpFloodChecker failedLoginIpFloodChecker = new FailedLoginByIpFloodChecker(ipAddress);
		FailedLoginFloodCheckerSet = new FloodCheckerList { failedLoginIpFloodChecker, FailedLoginByUserFloodChecker };
	}
}
