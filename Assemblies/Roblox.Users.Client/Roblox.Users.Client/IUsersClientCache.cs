using Roblox.DataV2.Core;

namespace Roblox.Users.Client;

public interface IUsersClientCache
{
	void SaveUser(UserData userData);

	void RemoveUser(long userId);

	bool TryGetUserById(long userId, out UserData userData);

	bool TryGetUserByName(string username, bool includeUsernameHistory, out UserData userData);

	bool TryGetUserByAccountId(long accountId, out UserData userData);

	void SaveUsername(string username, long userId);

	void RemoveUsername(string username);

	void ClearUsernameHistory(long userId);

	bool TryGetUsernameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, out HistoricalUsername[] historicalNames);

	void SaveUsernameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, HistoricalUsername[] historicalNames);

	bool TryGetDisplayNameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, out HistoricalDisplayName[] historicalDisplayNames);

	void SaveDisplayNameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, HistoricalDisplayName[] historicalDisplayNames);

	void ClearDisplayNameHistory(long userId);
}
