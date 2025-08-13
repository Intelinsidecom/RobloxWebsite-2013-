using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

internal class AuthenticateAsUserCredentials : CredentialsBase, IAuthenticateAsUserCredentials, ICredentials
{
	public IUser User { get; }

	internal AuthenticateAsUserCredentials(IUser user, IUserFactory userFactory)
		: base(userFactory)
	{
		User = user ?? throw new ArgumentNullException("user");
	}

	[Obsolete("Please use the constructor that takes an IUser.")]
	internal AuthenticateAsUserCredentials(string name, IUserFactory userFactory)
		: base(userFactory)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException("name");
		}
		User = userFactory.GetUserByName(name);
	}

	protected override IUser DoAuthentication()
	{
		return User;
	}
}
