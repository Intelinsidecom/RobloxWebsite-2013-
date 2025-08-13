using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;

namespace Roblox.Users.Client;

public interface IUsersClient
{
	bool AcquirePlaceholderUsername(long accountId, string name);

	Task<bool> AcquirePlaceholderUsernameAsync(long accountId, string name, CancellationToken cancellationToken);

	bool HasActivePlaceholderUsername(long accountId);

	Task<bool> HasActivePlaceholderUsernameAsync(long accountId, CancellationToken cancellationToken);

	bool ReleasePlaceholderUsername(long accountId);

	Task<bool> ReleasePlaceholderUsernameAsync(long accountId, CancellationToken cancellationToken);

	AccountStatusEntity[] GetModerationStatuses();

	Task<AccountStatusEntity[]> GetModerationStatusesAsync(CancellationToken cancellationToken);

	IReadOnlyCollection<GenderTypeEntity> GetGenders();

	Task<IReadOnlyCollection<GenderTypeEntity>> GetGendersAsync(CancellationToken cancellationToken);

	AgentData GetAgentByAgentId(long agentId);

	Task<AgentData> GetAgentByAgentIdAsync(long agentId, CancellationToken cancellationToken);

	long? GetAgentIdByTypeAndTargetId(AssociatedEntityType type, long targetId);

	Task<long?> GetAgentIdByTypeAndTargetIdAsync(AssociatedEntityType type, long targetId, CancellationToken cancellationToken);

	ChangeUsernameResult ChangeUsername(long userId, string currentName, string newName, bool recordHistory);

	Task<ChangeUsernameResult> ChangeUsernameAsync(long userId, string currentName, string newName, bool recordHistory, CancellationToken cancellationToken);

	int DeleteUsername(long userId, string name);

	Task<int> DeleteUsernameAsync(long userId, string name, CancellationToken cancellationToken);

	HistoricalUsername[] GetUsernameHistoryByUserId(long userId, int count, SortOrder sortOrder, long? exclusiveStartId);

	Task<HistoricalUsername[]> GetUsernameHistoryByUserIdAsync(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, CancellationToken cancellationToken);

	bool IsUsernameAvailable(string username);

	Task<bool> IsUsernameAvailableAsync(string username, CancellationToken cancellationToken);

	UserData GetUserByName(string name, bool includeUsernameHistory);

	Task<UserData> GetUserByNameAsync(string name, bool includeUsernameHistory, CancellationToken cancellationToken);

	IDictionary<string, UserData> MultiGetUsersByNames(ISet<string> names, bool includeUsernameHistory);

	Task<IDictionary<string, UserData>> MultiGetUsersByNamesAsync(ISet<string> names, bool includeUsernameHistory, CancellationToken cancellationToken);

	UserData GetUserById(long userId);

	Task<UserData> GetUserByIdAsync(long userId, CancellationToken cancellationToken);

	IDictionary<long, UserData> MultiGetUsersByIds(ISet<long> userIds);

	Task<IDictionary<long, UserData>> MultiGetUsersByIdsAsync(ISet<long> userIds, CancellationToken cancellationToken);

	UserData GetUserByAccountId(long accountId);

	Task<UserData> GetUserByAccountIdAsync(long accountId, CancellationToken cancellationToken);

	IDictionary<long, UserData> MultiGetUsersByAccountIds(ISet<long> accountIds);

	Task<IDictionary<long, UserData>> MultiGetUsersByAccountIdsAsync(ISet<long> accountIds, CancellationToken cancellationToken);

	SetUserModerationStatusResult SetUserModerationStatus(long userId, UserModerationStatus moderationStatus);

	Task<SetUserModerationStatusResult> SetUserModerationStatusAsync(long userId, UserModerationStatus moderationStatus, CancellationToken cancellationToken);

	SetUserDescriptionResult SetUserDescription(long userId, string description);

	Task<SetUserDescriptionResult> SetUserDescriptionAsync(long userId, string description, CancellationToken cancellationToken);

	SetUserBirthdateResult SetUserBirthdate(long userId, DateTime? birthdate);

	Task<SetUserBirthdateResult> SetUserBirthdateAsync(long userId, DateTime? birthdate, CancellationToken cancellationToken);

	SetUserGenderResult SetUserGender(long userId, UserGender gender);

	Task<SetUserGenderResult> SetUserGenderAsync(long userId, UserGender gender, CancellationToken cancellationToken);

	SetUserAgeBracketResult SetUserAgeBracket(long userId, UserAgeBracket ageBracket);

	Task<SetUserAgeBracketResult> SetUserAgeBracketAsync(long userId, UserAgeBracket ageBracket, CancellationToken cancellationToken);

	ICollection<long> GetRecentlyUpdatedUsers(DateTime? updatedAfterDate);

	Task<ICollection<long>> GetRecentlyUpdatedUsersAsync(DateTime? updatedAfterDate, CancellationToken cancellationToken);

	ReindexUserResult ReindexUser(long userId, bool flushCache);

	Task<ReindexUserResult> ReindexUserAsync(long userId, bool flushCache, CancellationToken cancellationToken);

	long GetOrCreateGroupAgentId(long groupId);

	Task<long> GetOrCreateGroupAgentIdAsync(long groupId, CancellationToken cancellationToken);

	UserData CreateUser(string name, UserGender? gender, DateTime? birthdate, UserAgeBracket? ageBracket);

	Task<UserData> CreateUserAsync(string name, UserGender? gender, DateTime? birthdate, UserAgeBracket? ageBracket, CancellationToken cancellationToken);

	ChangeDisplayNameResult ChangeDisplayName(long userId, string currentDisplayName, string newDisplayName, bool recordHistory);

	Task<ChangeDisplayNameResult> ChangeDisplayNameAsync(long userId, string currentDisplayName, string newDisplayName, bool recordHistory, CancellationToken cancellationToken);

	HistoricalDisplayName[] GetDisplayNameHistoryByUserId(long userId, int count, SortOrder sortOrder, long? exclusiveStartId);

	Task<HistoricalDisplayName[]> GetDisplayNameHistoryByUserIdAsync(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, CancellationToken cancellationToken);
}
