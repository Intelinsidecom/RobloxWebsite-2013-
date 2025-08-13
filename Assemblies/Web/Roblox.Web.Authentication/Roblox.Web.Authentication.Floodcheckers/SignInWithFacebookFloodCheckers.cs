using System;
using Roblox.FloodCheckers.Core;
using Roblox.Web.Authentication.Interfaces;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A class to group facebook sign in flood checkers.
/// </summary>
internal class SignInWithFacebookFloodCheckers : ISignInWithFacebookFloodCheckers
{
	/// <inheritdoc />
	public IFloodChecker SignInWithFacebookByFacebookIdFloodChecker { get; }

	/// <inheritdoc />
	public IFloodChecker SignInWithFacebookByIpAndFacebookIdFloodChecker { get; }

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.Floodcheckers.SignInWithFacebookFloodCheckers" />.
	/// </summary>
	/// <param name="ipAddress">The user's ipAddress</param>
	/// <param name="facebookId">The facebookId used for login.</param>
	public SignInWithFacebookFloodCheckers(string ipAddress, ulong facebookId)
	{
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new ArgumentException("Ip address can not be null or whitespace", "ipAddress");
		}
		if (facebookId == 0L)
		{
			throw new ArgumentException("FacebookId cannot be default", "facebookId");
		}
		SignInWithFacebookByFacebookIdFloodChecker = new SignInWithFacebookByFacebookIdFloodChecker(facebookId);
		SignInWithFacebookByIpAndFacebookIdFloodChecker = new SignInWithFacebookByIpAndFacebookIdFloodChecker(ipAddress, facebookId);
	}
}
