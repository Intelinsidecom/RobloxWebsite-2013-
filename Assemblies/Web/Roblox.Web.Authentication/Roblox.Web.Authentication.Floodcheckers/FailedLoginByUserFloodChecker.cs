using System;
using Roblox.FloodCheckers;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker to flood check failed logins by user
/// </summary>
public class FailedLoginByUserFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Authentication.Floodcheckers.FailedLoginByUserFloodChecker" />
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public FailedLoginByUserFloodChecker(IUser user)
		: base($"FailedLoginByAccountFloodChecker_UserId:{user?.Id}", Settings.Default.FailedLoginByUserFloodCheckLimit, Settings.Default.FailedLoginByUserFloodCheckExpiry)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
	}
}
