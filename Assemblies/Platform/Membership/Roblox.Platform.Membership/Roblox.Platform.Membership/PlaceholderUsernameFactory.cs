using System;
using Roblox.Users.Client;

namespace Roblox.Platform.Membership;

public class PlaceholderUsernameFactory : IPlaceholderUsernameFactory
{
	private readonly IUsersClient _UsersClient;

	/// <summary>
	/// Default constructor
	/// </summary>
	/// <param name="usersClient"><see cref="T:Roblox.Users.Client.IUsersClient" /></param>
	public PlaceholderUsernameFactory(IUsersClient usersClient)
	{
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
	}

	/// <inheritdoc />
	public bool HasActivePlaceholderUsername(long accountId)
	{
		return _UsersClient.HasActivePlaceholderUsername(accountId);
	}
}
