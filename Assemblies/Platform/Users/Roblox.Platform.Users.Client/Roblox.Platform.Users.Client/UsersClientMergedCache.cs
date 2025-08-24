using System;
using System.Collections.Generic;
using Roblox.DataV2.Core;

namespace Roblox.Users.Client;

public class UsersClientMergedCache : IUsersClientCache
{
	private readonly IReadOnlyCollection<IUsersClientCache> _UsersClientCaches;

	public UsersClientMergedCache(IReadOnlyCollection<IUsersClientCache> usersClientCaches)
	{
		_UsersClientCaches = usersClientCaches ?? throw new ArgumentNullException("usersClientCaches");
	}

	public void SaveUser(UserData userData)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.SaveUser(userData);
		}
	}

	public void RemoveUser(long userId)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.RemoveUser(userId);
		}
	}

	public bool TryGetUserById(long userId, out UserData userData)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			if (usersClientCache.TryGetUserById(userId, out userData))
			{
				return true;
			}
		}
		userData = null;
		return false;
	}

	public bool TryGetUserByName(string username, bool includeUsernameHistory, out UserData userData)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			if (usersClientCache.TryGetUserByName(username, includeUsernameHistory, out userData))
			{
				return true;
			}
		}
		userData = null;
		return false;
	}

	public bool TryGetUserByAccountId(long accountId, out UserData userData)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			if (usersClientCache.TryGetUserByAccountId(accountId, out userData))
			{
				return true;
			}
		}
		userData = null;
		return false;
	}

	public void SaveUsername(string username, long userId)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.SaveUsername(username, userId);
		}
	}

	public void RemoveUsername(string username)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.RemoveUsername(username);
		}
	}

	public void ClearUsernameHistory(long userId)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.ClearUsernameHistory(userId);
		}
	}

	public bool TryGetUsernameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, out HistoricalUsername[] historicalNames)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			if (usersClientCache.TryGetUsernameHistory(userId, count, sortOrder, exclusiveStartId, out historicalNames))
			{
				return true;
			}
		}
		historicalNames = null;
		return false;
	}

	public void SaveUsernameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, HistoricalUsername[] historicalNames)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.SaveUsernameHistory(userId, count, sortOrder, exclusiveStartId, historicalNames);
		}
	}

	public bool TryGetDisplayNameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, out HistoricalDisplayName[] historicalDisplayNames)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			if (usersClientCache.TryGetDisplayNameHistory(userId, count, sortOrder, exclusiveStartId, out historicalDisplayNames))
			{
				return true;
			}
		}
		historicalDisplayNames = null;
		return false;
	}

	public void SaveDisplayNameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, HistoricalDisplayName[] historicalDisplayNames)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.SaveDisplayNameHistory(userId, count, sortOrder, exclusiveStartId, historicalDisplayNames);
		}
	}

	public void ClearDisplayNameHistory(long userId)
	{
		foreach (IUsersClientCache usersClientCache in _UsersClientCaches)
		{
			usersClientCache.ClearDisplayNameHistory(userId);
		}
	}
}
