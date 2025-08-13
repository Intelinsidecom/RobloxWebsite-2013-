using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Users.Client;

namespace Roblox.Platform.Membership.Entities;

[ExcludeFromCodeCoverage]
internal class AccountNameHistoryEntityFactory : IAccountNameHistoryEntityFactory
{
	private readonly IUsersClient _UsersClient;

	public AccountNameHistoryEntityFactory(IUsersClient usersClient)
	{
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
	}

	public bool IsUsernameTaken(string username)
	{
		return _UsersClient.GetUserByName(username, includeUsernameHistory: true) != null;
	}
}
