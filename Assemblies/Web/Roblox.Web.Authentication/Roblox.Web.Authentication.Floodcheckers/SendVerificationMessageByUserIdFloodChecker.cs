using System;
using Roblox.FloodCheckers;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker to flood check sending verification messaages by user id
/// </summary>
public class SendVerificationMessageByUserIdFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Authentication.Floodcheckers.SendVerificationMessageByUserIdFloodChecker" />
	/// </summary>
	/// <param name="userId">The user id.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="userId" /> not positive.</exception>
	public SendVerificationMessageByUserIdFloodChecker(long userId)
		: base($"SendVerificationMessageFloodChecker_UserId:{userId}", Settings.Default.SendVerificationMessageByUserIdFloodCheckLimit, Settings.Default.SendVerificationMessageByUserIdFloodCheckExpiry)
	{
		if (userId <= 0)
		{
			throw new ArgumentException(string.Format("{0} must be positive.", "userId"));
		}
	}
}
