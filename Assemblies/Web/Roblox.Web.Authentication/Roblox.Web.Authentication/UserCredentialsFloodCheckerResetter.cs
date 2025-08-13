using System;
using System.Web;
using Roblox.Common;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Authentication;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication.Floodcheckers;

namespace Roblox.Web.Authentication;

/// <summary>
/// An implementation of <see cref="T:Roblox.Web.Authentication.IUserCredentialsFloodCheckerResetter" />.
/// </summary>
public class UserCredentialsFloodCheckerResetter : IUserCredentialsFloodCheckerResetter
{
	private readonly IAccountEmailAddressFactory _AccountEmailAddressFactory;

	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.UserCredentialsFloodCheckerResetter" />.
	/// </summary>
	/// <param name="accountEmailAddressFactory">The <see cref="T:Roblox.Platform.Email.User.IAccountEmailAddressFactory" />.</param>
	/// <param name="accountPhoneNumberFactory">The <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///     Thrown if <paramref name="accountEmailAddressFactory" /> or <paramref name="accountPhoneNumberFactory" /> is null.
	/// </exception>
	public UserCredentialsFloodCheckerResetter(IAccountEmailAddressFactory accountEmailAddressFactory, IAccountPhoneNumberFactory accountPhoneNumberFactory)
	{
		_AccountEmailAddressFactory = accountEmailAddressFactory ?? throw new ArgumentNullException("accountEmailAddressFactory");
		_AccountPhoneNumberFactory = accountPhoneNumberFactory ?? throw new ArgumentNullException("accountPhoneNumberFactory");
	}

	/// <inheritdoc />
	public void ResetCredentialsFloodChecker(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		ResetUsernameCredentialsFloodChecker(user);
		ResetEmailCredentialsFloodChecker(user);
		ResetPhoneCredentialsFloodChecker(user);
	}

	private void ResetPhoneCredentialsFloodChecker(IUser user)
	{
		IAccountPhoneNumber accountPhoneNumber = _AccountPhoneNumberFactory.GetVerifiedForUser(user);
		if (!string.IsNullOrWhiteSpace(accountPhoneNumber?.FullPhoneNumber))
		{
			GetUserCredentialsFloodChecker(CredentialsType.PhoneNumber, accountPhoneNumber.FullPhoneNumber).Reset();
			if (!string.IsNullOrWhiteSpace(accountPhoneNumber.Prefix) && accountPhoneNumber.FullPhoneNumber.StartsWith(accountPhoneNumber.Prefix))
			{
				string nationalPhoneNumber = accountPhoneNumber.FullPhoneNumber.Substring(accountPhoneNumber.Prefix.Length);
				GetUserCredentialsFloodChecker(CredentialsType.PhoneNumber, nationalPhoneNumber).Reset();
			}
		}
	}

	private void ResetEmailCredentialsFloodChecker(IUser user)
	{
		IAccountEmail accountEmail = _AccountEmailAddressFactory.Get(user);
		if (!string.IsNullOrWhiteSpace(accountEmail?.Email))
		{
			GetUserCredentialsFloodChecker(CredentialsType.Email, accountEmail.Email).Reset();
		}
	}

	private void ResetUsernameCredentialsFloodChecker(IUser user)
	{
		if (!string.IsNullOrWhiteSpace(user.Name))
		{
			GetUserCredentialsFloodChecker(CredentialsType.Username, user.Name).Reset();
		}
	}

	internal virtual IFloodChecker GetUserCredentialsFloodChecker(CredentialsType credentialsType, string credentialsValue)
	{
		return new UserCredentialsFloodChecker(GetOriginIP(), credentialsType, credentialsValue);
	}

	private string GetOriginIP()
	{
		return HttpContext.Current.GetOriginIP();
	}
}
