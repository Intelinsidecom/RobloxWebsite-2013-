using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Caching;
using Roblox.DataV2.Core;
using Roblox.EventLog;

namespace Roblox.Users.Client;

public class CachedUsersClient : IUsersClient
{
	private readonly IUsersClient _UsersClient;

	private readonly IUsersClientCache _UsersClientCache;

	private readonly IUsersClientAgentCache _UsersClientAgentCache;

	private readonly ILazyWithRetry<AccountStatusEntity[]> _GetModerationStatusesLazy;

	private readonly ILazyWithRetry<IReadOnlyCollection<GenderTypeEntity>> _GetGenderTypesLazy;

	public static ILogger RequestLogger
	{
		get
		{
			return UsersClientLocalCache.RequestLogger;
		}
		set
		{
			UsersClientLocalCache.RequestLogger = value;
		}
	}

	public CachedUsersClient(IUsersClient uncachedUsersClient, IUsersClientCache usersClientCache, IUsersClientAgentCache usersClientAgentCache)
	{
		_UsersClient = uncachedUsersClient ?? throw new ArgumentNullException("uncachedUsersClient");
		_UsersClientCache = usersClientCache ?? throw new ArgumentNullException("usersClientCache");
		_UsersClientAgentCache = usersClientAgentCache ?? throw new ArgumentNullException("usersClientAgentCache");
		_GetModerationStatusesLazy = (ILazyWithRetry<AccountStatusEntity[]>)(object)new LazyWithRetry<AccountStatusEntity[]>((Func<AccountStatusEntity[]>)uncachedUsersClient.GetModerationStatuses, (Func<DateTime>)null);
		_GetGenderTypesLazy = (ILazyWithRetry<IReadOnlyCollection<GenderTypeEntity>>)(object)new LazyWithRetry<IReadOnlyCollection<GenderTypeEntity>>((Func<IReadOnlyCollection<GenderTypeEntity>>)uncachedUsersClient.GetGenders, (Func<DateTime>)null);
	}

	public bool AcquirePlaceholderUsername(long accountId, string name)
	{
		return _UsersClient.AcquirePlaceholderUsername(accountId, name);
	}

	public Task<bool> AcquirePlaceholderUsernameAsync(long accountId, string name, CancellationToken cancellationToken)
	{
		return _UsersClient.AcquirePlaceholderUsernameAsync(accountId, name, cancellationToken);
	}

	public bool HasActivePlaceholderUsername(long accountId)
	{
		return _UsersClient.HasActivePlaceholderUsername(accountId);
	}

	public Task<bool> HasActivePlaceholderUsernameAsync(long accountId, CancellationToken cancellationToken)
	{
		return _UsersClient.HasActivePlaceholderUsernameAsync(accountId, cancellationToken);
	}

	public bool ReleasePlaceholderUsername(long accountId)
	{
		return _UsersClient.ReleasePlaceholderUsername(accountId);
	}

	public Task<bool> ReleasePlaceholderUsernameAsync(long accountId, CancellationToken cancellationToken)
	{
		return _UsersClient.ReleasePlaceholderUsernameAsync(accountId, cancellationToken);
	}

	public AccountStatusEntity[] GetModerationStatuses()
	{
		return _GetModerationStatusesLazy.Value;
	}

	public Task<AccountStatusEntity[]> GetModerationStatusesAsync(CancellationToken cancellationToken)
	{
		return Task.FromResult(_GetModerationStatusesLazy.Value);
	}

	public IReadOnlyCollection<GenderTypeEntity> GetGenders()
	{
		return _GetGenderTypesLazy.Value;
	}

	public Task<IReadOnlyCollection<GenderTypeEntity>> GetGendersAsync(CancellationToken cancellationToken)
	{
		return Task.FromResult(_GetGenderTypesLazy.Value);
	}

	public AgentData GetAgentByAgentId(long agentId)
	{
		if (_UsersClientAgentCache.TryGetAgentById(agentId, out var agentData))
		{
			return agentData;
		}
		agentData = _UsersClient.GetAgentByAgentId(agentId);
		_UsersClientAgentCache.SaveAgent(agentData);
		return agentData;
	}

	public async Task<AgentData> GetAgentByAgentIdAsync(long agentId, CancellationToken cancellationToken)
	{
		if (_UsersClientAgentCache.TryGetAgentById(agentId, out var agentData))
		{
			return agentData;
		}
		agentData = await _UsersClient.GetAgentByAgentIdAsync(agentId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientAgentCache.SaveAgent(agentData);
		return agentData;
	}

	public long? GetAgentIdByTypeAndTargetId(AssociatedEntityType type, long targetId)
	{
		if (_UsersClientAgentCache.TryGetAgentByTypeAndTarget(type, targetId, out var agentData))
		{
			return agentData?.Id;
		}
		long? agentIdByTypeAndTargetId = _UsersClient.GetAgentIdByTypeAndTargetId(type, targetId);
		if (agentIdByTypeAndTargetId.HasValue)
		{
			agentData = new AgentData
			{
				Id = agentIdByTypeAndTargetId.Value,
				Type = type,
				TargetId = targetId
			};
			_UsersClientAgentCache.SaveAgent(agentData);
		}
		return agentIdByTypeAndTargetId;
	}

	public async Task<long?> GetAgentIdByTypeAndTargetIdAsync(AssociatedEntityType type, long targetId, CancellationToken cancellationToken)
	{
		if (_UsersClientAgentCache.TryGetAgentByTypeAndTarget(type, targetId, out var agentData))
		{
			return agentData?.Id;
		}
		long? result = await _UsersClient.GetAgentIdByTypeAndTargetIdAsync(type, targetId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (result.HasValue)
		{
			agentData = new AgentData
			{
				Id = result.Value,
				Type = type,
				TargetId = targetId
			};
			_UsersClientAgentCache.SaveAgent(agentData);
		}
		return result;
	}

	public ChangeUsernameResult ChangeUsername(long userId, string currentName, string newName, bool recordHistory)
	{
		ChangeUsernameResult result = _UsersClient.ChangeUsername(userId, currentName, newName, recordHistory);
		_UsersClientCache.ClearUsernameHistory(userId);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<ChangeUsernameResult> ChangeUsernameAsync(long userId, string currentName, string newName, bool recordHistory, CancellationToken cancellationToken)
	{
		ChangeUsernameResult result = await _UsersClient.ChangeUsernameAsync(userId, currentName, newName, recordHistory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.ClearUsernameHistory(userId);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public ChangeDisplayNameResult ChangeDisplayName(long userId, string currentDisplayName, string newDisplayName, bool recordHistory)
	{
		ChangeDisplayNameResult result = _UsersClient.ChangeDisplayName(userId, currentDisplayName, newDisplayName, recordHistory);
		_UsersClientCache.ClearDisplayNameHistory(userId);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<ChangeDisplayNameResult> ChangeDisplayNameAsync(long userId, string currentDisplayName, string newDisplayName, bool recordHistory, CancellationToken cancellationToken)
	{
		ChangeDisplayNameResult result = await _UsersClient.ChangeDisplayNameAsync(userId, currentDisplayName, newDisplayName, recordHistory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.ClearDisplayNameHistory(userId);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public HistoricalDisplayName[] GetDisplayNameHistoryByUserId(long userId, int count, SortOrder sortOrder, long? exclusiveStartId)
	{
		if (_UsersClientCache.TryGetDisplayNameHistory(userId, count, sortOrder, exclusiveStartId, out var historicalDisplayNames))
		{
			return historicalDisplayNames;
		}
		historicalDisplayNames = _UsersClient.GetDisplayNameHistoryByUserId(userId, count, sortOrder, exclusiveStartId);
		_UsersClientCache.SaveDisplayNameHistory(userId, count, sortOrder, exclusiveStartId, historicalDisplayNames);
		return historicalDisplayNames;
	}

	public async Task<HistoricalDisplayName[]> GetDisplayNameHistoryByUserIdAsync(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, CancellationToken cancellationToken)
	{
		if (_UsersClientCache.TryGetDisplayNameHistory(userId, count, sortOrder, exclusiveStartId, out var historicalDisplayNames))
		{
			return historicalDisplayNames;
		}
		historicalDisplayNames = await _UsersClient.GetDisplayNameHistoryByUserIdAsync(userId, count, sortOrder, exclusiveStartId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.SaveDisplayNameHistory(userId, count, sortOrder, exclusiveStartId, historicalDisplayNames);
		return historicalDisplayNames;
	}

	public int DeleteUsername(long userId, string name)
	{
		int result = _UsersClient.DeleteUsername(userId, name);
		_UsersClientCache.ClearUsernameHistory(userId);
		_UsersClientCache.RemoveUsername(name);
		return result;
	}

	public async Task<int> DeleteUsernameAsync(long userId, string name, CancellationToken cancellationToken)
	{
		int result = await _UsersClient.DeleteUsernameAsync(userId, name, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.ClearUsernameHistory(userId);
		_UsersClientCache.RemoveUsername(name);
		return result;
	}

	public HistoricalUsername[] GetUsernameHistoryByUserId(long userId, int count, SortOrder sortOrder, long? exclusiveStartId)
	{
		if (_UsersClientCache.TryGetUsernameHistory(userId, count, sortOrder, exclusiveStartId, out var historicalNames))
		{
			return historicalNames;
		}
		historicalNames = _UsersClient.GetUsernameHistoryByUserId(userId, count, sortOrder, exclusiveStartId);
		_UsersClientCache.SaveUsernameHistory(userId, count, sortOrder, exclusiveStartId, historicalNames);
		HistoricalUsername[] array = historicalNames;
		foreach (HistoricalUsername historicalUsername in array)
		{
			_UsersClientCache.SaveUsername(historicalUsername.Name, userId);
		}
		return historicalNames;
	}

	public async Task<HistoricalUsername[]> GetUsernameHistoryByUserIdAsync(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, CancellationToken cancellationToken)
	{
		if (_UsersClientCache.TryGetUsernameHistory(userId, count, sortOrder, exclusiveStartId, out var historicalNames))
		{
			return historicalNames;
		}
		historicalNames = await _UsersClient.GetUsernameHistoryByUserIdAsync(userId, count, sortOrder, exclusiveStartId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.SaveUsernameHistory(userId, count, sortOrder, exclusiveStartId, historicalNames);
		HistoricalUsername[] array = historicalNames;
		foreach (HistoricalUsername historicalUsername in array)
		{
			_UsersClientCache.SaveUsername(historicalUsername.Name, userId);
		}
		return historicalNames;
	}

	public bool IsUsernameAvailable(string username)
	{
		if (_UsersClientCache.TryGetUserByName(username, includeUsernameHistory: true, out var userData) && userData != null)
		{
			return false;
		}
		return _UsersClient.IsUsernameAvailable(username);
	}

	public Task<bool> IsUsernameAvailableAsync(string username, CancellationToken cancellationToken)
	{
		if (_UsersClientCache.TryGetUserByName(username, includeUsernameHistory: true, out var userData) && userData != null)
		{
			return Task.FromResult(result: false);
		}
		return _UsersClient.IsUsernameAvailableAsync(username, cancellationToken);
	}

	public UserData GetUserByName(string name, bool includeUsernameHistory)
	{
		Func<string> methodIdentifier = () => string.Format("{0}.{1}(\"{2}\", {3})", "CachedUsersClient", "GetUserByName", name, includeUsernameHistory);
		if (_UsersClientCache.TryGetUserByName(name, includeUsernameHistory, out var user))
		{
			RequestLogger?.Verbose(() => $"{methodIdentifier()} user found in cache ({user?.Id}/\"{user?.Name}\")");
			return user;
		}
		user = _UsersClient.GetUserByName(name, includeUsernameHistory);
		_UsersClientCache.SaveUser(user);
		if (user == null)
		{
			RequestLogger?.Verbose(() => methodIdentifier() + " returned null");
		}
		else
		{
			RequestLogger?.Verbose(() => $"{methodIdentifier()} returned user ({user.Id}/\"{user.Name}\")");
		}
		return user;
	}

	public async Task<UserData> GetUserByNameAsync(string name, bool includeUsernameHistory, CancellationToken cancellationToken)
	{
		if (_UsersClientCache.TryGetUserByName(name, includeUsernameHistory, out var userData))
		{
			return userData;
		}
		userData = await _UsersClient.GetUserByNameAsync(name, includeUsernameHistory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.SaveUser(userData);
		return userData;
	}

	public IDictionary<string, UserData> MultiGetUsersByNames(ISet<string> names, bool includeUsernameHistory)
	{
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		Dictionary<string, UserData> dictionary = new Dictionary<string, UserData>(StringComparer.OrdinalIgnoreCase);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in names.Where((string n) => !string.IsNullOrWhiteSpace(n)))
		{
			if (_UsersClientCache.TryGetUserByName(item, includeUsernameHistory, out var userData))
			{
				dictionary.Add(item.ToLower(), userData);
			}
			else
			{
				hashSet.Add(item);
			}
		}
		if (hashSet.Any())
		{
			foreach (KeyValuePair<string, UserData> item2 in _UsersClient.MultiGetUsersByNames(hashSet, includeUsernameHistory))
			{
				dictionary[item2.Key.ToLower()] = item2.Value;
				_UsersClientCache.SaveUser(item2.Value);
			}
		}
		return dictionary;
	}

	public async Task<IDictionary<string, UserData>> MultiGetUsersByNamesAsync(ISet<string> names, bool includeUsernameHistory, CancellationToken cancellationToken)
	{
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		Dictionary<string, UserData> users = new Dictionary<string, UserData>(StringComparer.OrdinalIgnoreCase);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in names.Where((string n) => !string.IsNullOrWhiteSpace(n)))
		{
			if (_UsersClientCache.TryGetUserByName(item, includeUsernameHistory, out var userData))
			{
				users.Add(item.ToLower(), userData);
			}
			else
			{
				hashSet.Add(item);
			}
		}
		if (hashSet.Any())
		{
			foreach (KeyValuePair<string, UserData> item2 in await _UsersClient.MultiGetUsersByNamesAsync(hashSet, includeUsernameHistory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
			{
				users[item2.Key] = item2.Value;
				_UsersClientCache.SaveUser(item2.Value);
			}
		}
		return users;
	}

	public UserData GetUserById(long userId)
	{
		if (_UsersClientCache.TryGetUserById(userId, out var userData))
		{
			return userData;
		}
		userData = _UsersClient.GetUserById(userId);
		_UsersClientCache.SaveUser(userData);
		return userData;
	}

	public async Task<UserData> GetUserByIdAsync(long userId, CancellationToken cancellationToken)
	{
		if (_UsersClientCache.TryGetUserById(userId, out var userData))
		{
			return userData;
		}
		userData = await _UsersClient.GetUserByIdAsync(userId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.SaveUser(userData);
		return userData;
	}

	public IDictionary<long, UserData> MultiGetUsersByIds(ISet<long> userIds)
	{
		if (userIds == null)
		{
			throw new ArgumentNullException("userIds");
		}
		Dictionary<long, UserData> dictionary = new Dictionary<long, UserData>();
		HashSet<long> hashSet = new HashSet<long>();
		foreach (long userId in userIds)
		{
			if (_UsersClientCache.TryGetUserById(userId, out var userData))
			{
				if (userData != null)
				{
					dictionary.Add(userId, userData);
				}
			}
			else
			{
				hashSet.Add(userId);
			}
		}
		if (hashSet.Any())
		{
			foreach (KeyValuePair<long, UserData> item in _UsersClient.MultiGetUsersByIds(hashSet))
			{
				dictionary[item.Key] = item.Value;
				_UsersClientCache.SaveUser(item.Value);
			}
		}
		return dictionary;
	}

	public async Task<IDictionary<long, UserData>> MultiGetUsersByIdsAsync(ISet<long> userIds, CancellationToken cancellationToken)
	{
		if (userIds == null)
		{
			throw new ArgumentNullException("userIds");
		}
		Dictionary<long, UserData> users = new Dictionary<long, UserData>();
		HashSet<long> hashSet = new HashSet<long>();
		foreach (long item in hashSet)
		{
			if (_UsersClientCache.TryGetUserById(item, out var userData))
			{
				if (userData != null)
				{
					users.Add(item, userData);
				}
			}
			else
			{
				hashSet.Add(item);
			}
		}
		if (hashSet.Any())
		{
			foreach (KeyValuePair<long, UserData> item2 in await _UsersClient.MultiGetUsersByIdsAsync(hashSet, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
			{
				users[item2.Key] = item2.Value;
				_UsersClientCache.SaveUser(item2.Value);
			}
		}
		return users;
	}

	public UserData GetUserByAccountId(long accountId)
	{
		if (_UsersClientCache.TryGetUserByAccountId(accountId, out var userData))
		{
			return userData;
		}
		userData = _UsersClient.GetUserByAccountId(accountId);
		_UsersClientCache.SaveUser(userData);
		return userData;
	}

	public async Task<UserData> GetUserByAccountIdAsync(long accountId, CancellationToken cancellationToken)
	{
		if (_UsersClientCache.TryGetUserByAccountId(accountId, out var userData))
		{
			return userData;
		}
		userData = await _UsersClient.GetUserByAccountIdAsync(accountId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.SaveUser(userData);
		return userData;
	}

	public IDictionary<long, UserData> MultiGetUsersByAccountIds(ISet<long> accountIds)
	{
		if (accountIds == null)
		{
			throw new ArgumentNullException("accountIds");
		}
		Dictionary<long, UserData> dictionary = new Dictionary<long, UserData>();
		HashSet<long> hashSet = new HashSet<long>();
		foreach (long accountId in accountIds)
		{
			if (_UsersClientCache.TryGetUserByAccountId(accountId, out var userData))
			{
				if (userData != null)
				{
					dictionary.Add(accountId, userData);
				}
			}
			else if (accountId > 0)
			{
				hashSet.Add(accountId);
			}
		}
		if (hashSet.Any())
		{
			foreach (KeyValuePair<long, UserData> item in _UsersClient.MultiGetUsersByAccountIds(hashSet))
			{
				dictionary[item.Key] = item.Value;
				_UsersClientCache.SaveUser(item.Value);
			}
		}
		return dictionary;
	}

	public async Task<IDictionary<long, UserData>> MultiGetUsersByAccountIdsAsync(ISet<long> accountIds, CancellationToken cancellationToken)
	{
		if (accountIds == null)
		{
			throw new ArgumentNullException("accountIds");
		}
		Dictionary<long, UserData> accounts = new Dictionary<long, UserData>();
		HashSet<long> hashSet = new HashSet<long>();
		foreach (long accountId in accountIds)
		{
			if (_UsersClientCache.TryGetUserByAccountId(accountId, out var userData))
			{
				if (userData != null)
				{
					accounts.Add(accountId, userData);
				}
			}
			else
			{
				hashSet.Add(accountId);
			}
		}
		if (hashSet.Any())
		{
			foreach (KeyValuePair<long, UserData> item in await _UsersClient.MultiGetUsersByAccountIdsAsync(hashSet, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
			{
				accounts[item.Key] = item.Value;
				_UsersClientCache.SaveUser(item.Value);
			}
		}
		return accounts;
	}

	public SetUserModerationStatusResult SetUserModerationStatus(long userId, UserModerationStatus moderationStatus)
	{
		SetUserModerationStatusResult result = _UsersClient.SetUserModerationStatus(userId, moderationStatus);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<SetUserModerationStatusResult> SetUserModerationStatusAsync(long userId, UserModerationStatus moderationStatus, CancellationToken cancellationToken)
	{
		SetUserModerationStatusResult result = await _UsersClient.SetUserModerationStatusAsync(userId, moderationStatus, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public SetUserDescriptionResult SetUserDescription(long userId, string description)
	{
		SetUserDescriptionResult result = _UsersClient.SetUserDescription(userId, description);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<SetUserDescriptionResult> SetUserDescriptionAsync(long userId, string description, CancellationToken cancellationToken)
	{
		SetUserDescriptionResult result = await _UsersClient.SetUserDescriptionAsync(userId, description, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public SetUserBirthdateResult SetUserBirthdate(long userId, DateTime? birthdate)
	{
		SetUserBirthdateResult result = _UsersClient.SetUserBirthdate(userId, birthdate);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<SetUserBirthdateResult> SetUserBirthdateAsync(long userId, DateTime? birthdate, CancellationToken cancellationToken)
	{
		SetUserBirthdateResult result = await _UsersClient.SetUserBirthdateAsync(userId, birthdate, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public SetUserGenderResult SetUserGender(long userId, UserGender gender)
	{
		SetUserGenderResult result = _UsersClient.SetUserGender(userId, gender);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<SetUserGenderResult> SetUserGenderAsync(long userId, UserGender gender, CancellationToken cancellationToken)
	{
		SetUserGenderResult result = await _UsersClient.SetUserGenderAsync(userId, gender, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public SetUserAgeBracketResult SetUserAgeBracket(long userId, UserAgeBracket ageBracket)
	{
		SetUserAgeBracketResult result = _UsersClient.SetUserAgeBracket(userId, ageBracket);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<SetUserAgeBracketResult> SetUserAgeBracketAsync(long userId, UserAgeBracket ageBracket, CancellationToken cancellationToken)
	{
		SetUserAgeBracketResult result = await _UsersClient.SetUserAgeBracketAsync(userId, ageBracket, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public ICollection<long> GetRecentlyUpdatedUsers(DateTime? updatedAfterDate)
	{
		return _UsersClient.GetRecentlyUpdatedUsers(updatedAfterDate);
	}

	public Task<ICollection<long>> GetRecentlyUpdatedUsersAsync(DateTime? updatedAfterDate, CancellationToken cancellationToken)
	{
		return _UsersClient.GetRecentlyUpdatedUsersAsync(updatedAfterDate, cancellationToken);
	}

	public ReindexUserResult ReindexUser(long userId, bool flushCache)
	{
		ReindexUserResult result = _UsersClient.ReindexUser(userId, flushCache);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public async Task<ReindexUserResult> ReindexUserAsync(long userId, bool flushCache, CancellationToken cancellationToken)
	{
		ReindexUserResult result = await _UsersClient.ReindexUserAsync(userId, flushCache, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.RemoveUser(userId);
		return result;
	}

	public long GetOrCreateGroupAgentId(long groupId)
	{
		if (_UsersClientAgentCache.TryGetAgentByTypeAndTarget(AssociatedEntityType.Group, groupId, out var agentData))
		{
			return agentData.Id;
		}
		long orCreateGroupAgentId = _UsersClient.GetOrCreateGroupAgentId(groupId);
		agentData = new AgentData
		{
			Id = orCreateGroupAgentId,
			Type = AssociatedEntityType.Group,
			TargetId = groupId
		};
		_UsersClientAgentCache.SaveAgent(agentData);
		return orCreateGroupAgentId;
	}

	public async Task<long> GetOrCreateGroupAgentIdAsync(long groupId, CancellationToken cancellationToken)
	{
		if (_UsersClientAgentCache.TryGetAgentByTypeAndTarget(AssociatedEntityType.Group, groupId, out var agentData))
		{
			return agentData.Id;
		}
		long num = await _UsersClient.GetOrCreateGroupAgentIdAsync(groupId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		agentData = new AgentData
		{
			Id = num,
			Type = AssociatedEntityType.Group,
			TargetId = groupId
		};
		_UsersClientAgentCache.SaveAgent(agentData);
		return num;
	}

	public UserData CreateUser(string name, UserGender? gender, DateTime? birthdate, UserAgeBracket? ageBracket)
	{
		UserData userData = _UsersClient.CreateUser(name, gender, birthdate, ageBracket);
		_UsersClientCache.SaveUser(userData);
		return userData;
	}

	public async Task<UserData> CreateUserAsync(string name, UserGender? gender, DateTime? birthdate, UserAgeBracket? ageBracket, CancellationToken cancellationToken)
	{
		UserData userData = await _UsersClient.CreateUserAsync(name, gender, birthdate, ageBracket, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_UsersClientCache.SaveUser(userData);
		return userData;
	}
}
