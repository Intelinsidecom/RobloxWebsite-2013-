using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Roblox.Collections;
using Roblox.Configuration;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Http.ServiceClient;
using Roblox.Users.Client.Properties;

namespace Roblox.Users.Client;

public class UsersClientLocalCache : IUsersClientCache
{
	internal static ILogger RequestLogger;

	private readonly ISettings _Settings;

	private readonly IUsersClient _UsersClient;

	private readonly IUsersClientAgentCache _UsersClientAgentCache;

	private readonly ILogger _Logger;

	private readonly ExpirableDictionary<long, UserData> _UserCacheById;

	private readonly ExpirableDictionary<long, Payload<long>> _AccountIdToUserIdDictionary;

	private readonly ExpirableDictionary<string, Payload<long>> _NameToUserIdDictionary;

	private readonly ExpirableDictionary<long, ConcurrentDictionary<string, HistoricalUsername[]>> _UsernameHistoryByUserIdCache;

	private readonly ExpirableDictionary<long, ConcurrentDictionary<string, HistoricalDisplayName[]>> _DisplayNameHistoryByUserIdCache;

	private readonly Timer _CachePurgeTimer;

	private bool _PurgeDebounce;

	private int _PurgeCheckFailures;

	private DateTime? _LastPurge;

	[ExcludeFromCodeCoverage]
	public UsersClientLocalCache(IUsersClient usersClient, IUsersClientAgentCache usersClientAgentCache)
		: this(Settings.Default, usersClient, usersClientAgentCache, StaticLoggerRegistry.Instance)
	{
	}

	public UsersClientLocalCache(IUsersClient usersClient, IUsersClientAgentCache usersClientAgentCache, ILogger logger)
		: this(Settings.Default, usersClient, usersClientAgentCache, logger)
	{
	}

	internal UsersClientLocalCache(ISettings settings, IUsersClient usersClient, IUsersClientAgentCache usersClientAgentCache, ILogger logger)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
		_UsersClientAgentCache = usersClientAgentCache ?? throw new ArgumentNullException("usersClientAgentCache");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_UserCacheById = new ExpirableDictionary<long, UserData>(GetUserLocalCacheExpiry, ExpirationPolicy.NeverRenew);
		_AccountIdToUserIdDictionary = new ExpirableDictionary<long, Payload<long>>(GetUserLocalCacheExpiry, ExpirationPolicy.RenewOnRead);
		_NameToUserIdDictionary = new ExpirableDictionary<string, Payload<long>>(GetUserLocalCacheExpiry, ExpirationPolicy.NeverRenew);
		_UsernameHistoryByUserIdCache = new ExpirableDictionary<long, ConcurrentDictionary<string, HistoricalUsername[]>>(GetUsernameHistoryCacheExpiry, ExpirationPolicy.NeverRenew);
		_DisplayNameHistoryByUserIdCache = new ExpirableDictionary<long, ConcurrentDictionary<string, HistoricalDisplayName[]>>(GetDisplayNameHistoryCacheExpiry, ExpirationPolicy.NeverRenew);
		_CachePurgeTimer = new Timer(PurgeUpdatedUsers, null, settings.GetRecentlyUpdatedUsersInterval, settings.GetRecentlyUpdatedUsersInterval);
		settings.MonitorChanges((ISettings s) => s.GetRecentlyUpdatedUsersInterval, UpdatePurgeTimerInterval);
	}

	public void SaveUser(UserData userData)
	{
		string text = "UsersClientLocalCache.SaveUser(" + ((userData == null) ? "null" : ("\"" + userData.Name + "\"")) + ")";
		if (userData == null || !_Settings.UsersClientLocalCacheEnabled)
		{
			if (userData != null)
			{
				RequestLogger?.Verbose(text + " skipped (UsersClientLocalCacheEnabled disabled)");
			}
			else
			{
				RequestLogger?.Verbose(text + " skipped (user null)");
			}
			return;
		}
		Payload<long> value = new Payload<long>
		{
			Data = userData.Id
		};
		AgentData agentData = new AgentData
		{
			Id = userData.Id,
			TargetId = userData.Id,
			Type = AssociatedEntityType.User
		};
		if (_Settings.UserCreatedCacheThreshold <= TimeSpan.Zero || userData.Created + _Settings.UserCreatedCacheThreshold < DateTime.UtcNow)
		{
			_UserCacheById.Set(userData.Id, userData);
			RequestLogger?.Verbose(text + " saved to cache");
		}
		else
		{
			RequestLogger?.Verbose(text + " skipped (user created too recently)");
		}
		_AccountIdToUserIdDictionary.Set(userData.AccountId, value);
		SaveUsername(userData.Name, userData.Id);
		_UsersClientAgentCache.SaveAgent(agentData);
	}

	public void RemoveUser(long userId)
	{
		_UserCacheById.Remove(userId);
	}

	public bool TryGetUserById(long userId, out UserData userData)
	{
		if (!_Settings.UsersClientLocalCacheEnabled)
		{
			userData = null;
			return false;
		}
		if (userId <= 0)
		{
			userData = null;
			return true;
		}
		userData = _UserCacheById.Get(userId);
		return userData != null;
	}

	public bool TryGetUserByName(string username, bool includeUsernameHistory, out UserData userData)
	{
		Func<string> methodIdentifier = () => string.Format("{0}.{1}(\"{2}\", {3})", "UsersClientLocalCache", "TryGetUserByName", username, includeUsernameHistory);
		if (!_Settings.UsersClientLocalCacheEnabled)
		{
			RequestLogger?.Verbose(() => methodIdentifier() + " returned null/false (UsersClientLocalCacheEnabled disabled)");
			userData = null;
			return false;
		}
		if (string.IsNullOrWhiteSpace(username))
		{
			RequestLogger?.Verbose(() => methodIdentifier() + " returned null/true (whitespace username)");
			userData = null;
			return true;
		}
		if (username.Length > _Settings.DatabaseMaxUsernameLength)
		{
			RequestLogger?.Verbose(() => $"{methodIdentifier()} returned null/true (username too long {username.Length})");
			userData = null;
			return true;
		}
		Payload<long> userId = _NameToUserIdDictionary.Get(username.ToLower());
		if (userId != null)
		{
			if (TryGetUserById(userId.Data, out userData))
			{
				UserData userDataCopy = userData;
				if (!includeUsernameHistory && !string.Equals(username, userData.Name, StringComparison.OrdinalIgnoreCase))
				{
					RequestLogger?.Verbose(() => $"{methodIdentifier()} returned null/true (user in cache {userDataCopy.Id}/\"{userDataCopy.Name}\", but name did not match requested username)");
					userData = null;
				}
				else
				{
					RequestLogger?.Verbose(() => $"{methodIdentifier()} returned user/true (user found in cache: {userDataCopy.Id}/{userDataCopy.Name})");
				}
				return true;
			}
			RequestLogger?.Verbose(() => $"{methodIdentifier()} returned null/false (username map in cache, no user {userId})");
		}
		else
		{
			RequestLogger?.Verbose(() => methodIdentifier() + " returned null/false (username not in cache)");
		}
		userData = null;
		return false;
	}

	public bool TryGetUserByAccountId(long accountId, out UserData userData)
	{
		if (!_Settings.UsersClientLocalCacheEnabled)
		{
			userData = null;
			return false;
		}
		if (accountId <= 0)
		{
			userData = null;
			return true;
		}
		Payload<long> payload = _AccountIdToUserIdDictionary.Get(accountId);
		if (payload != null)
		{
			return TryGetUserById(payload.Data, out userData);
		}
		userData = null;
		return false;
	}

	public void SaveUsername(string username, long userId)
	{
		if (!string.IsNullOrWhiteSpace(username) && userId > 0 && _Settings.UsersClientLocalCacheEnabled)
		{
			Payload<long> value = new Payload<long>
			{
				Data = userId
			};
			_NameToUserIdDictionary.Set(username.ToLower(), value);
		}
	}

	public void RemoveUsername(string username)
	{
		if (!string.IsNullOrWhiteSpace(username))
		{
			_NameToUserIdDictionary.Remove(username.ToLower());
		}
	}

	public void ClearUsernameHistory(long userId)
	{
		_UsernameHistoryByUserIdCache.Remove(userId);
	}

	public bool TryGetUsernameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, out HistoricalUsername[] historicalNames)
	{
		if (!_Settings.UsersClientLocalCacheEnabled)
		{
			historicalNames = null;
			return false;
		}
		if (userId <= 0)
		{
			historicalNames = Array.Empty<HistoricalUsername>();
			return true;
		}
		ConcurrentDictionary<string, HistoricalUsername[]> usernameHistoryCache = GetUsernameHistoryCache(userId);
		string key = BuildUsernameHistoryCacheKey(count, sortOrder, exclusiveStartId);
		return usernameHistoryCache.TryGetValue(key, out historicalNames);
	}

	public void SaveUsernameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, HistoricalUsername[] historicalNames)
	{
		if (_Settings.UsersClientLocalCacheEnabled)
		{
			ConcurrentDictionary<string, HistoricalUsername[]> usernameHistoryCache = GetUsernameHistoryCache(userId);
			string key = BuildUsernameHistoryCacheKey(count, sortOrder, exclusiveStartId);
			usernameHistoryCache[key] = historicalNames;
		}
	}

	public bool TryGetDisplayNameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, out HistoricalDisplayName[] historicalDisplayNames)
	{
		if (!_Settings.UsersClientLocalCacheEnabled)
		{
			historicalDisplayNames = null;
			return false;
		}
		if (userId <= 0)
		{
			historicalDisplayNames = Array.Empty<HistoricalDisplayName>();
			return true;
		}
		ConcurrentDictionary<string, HistoricalDisplayName[]> displayNameHistoryCache = GetDisplayNameHistoryCache(userId);
		string key = BuildDisplayNameHistoryCacheKey(count, sortOrder, exclusiveStartId);
		return displayNameHistoryCache.TryGetValue(key, out historicalDisplayNames);
	}

	public void SaveDisplayNameHistory(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, HistoricalDisplayName[] historicalDisplayNames)
	{
		if (_Settings.UsersClientLocalCacheEnabled)
		{
			ConcurrentDictionary<string, HistoricalDisplayName[]> displayNameHistoryCache = GetDisplayNameHistoryCache(userId);
			string key = BuildDisplayNameHistoryCacheKey(count, sortOrder, exclusiveStartId);
			displayNameHistoryCache[key] = historicalDisplayNames;
		}
	}

	public void ClearDisplayNameHistory(long userId)
	{
		_DisplayNameHistoryByUserIdCache.Remove(userId);
	}

	internal void UpdatePurgeTimerInterval(TimeSpan newInterval)
	{
		_CachePurgeTimer.Change(newInterval, newInterval);
	}

	internal void PurgeUpdatedUsers(object state)
	{
		if (_PurgeDebounce || !_Settings.UsersClientLocalCacheEnabled)
		{
			return;
		}
		_PurgeDebounce = true;
		try
		{
			DateTime utcNow = DateTime.UtcNow;
			DateTime? updatedAfterDate = _LastPurge?.Subtract(_Settings.UserLocalCachePurgeLeeway);
			foreach (long recentlyUpdatedUser in _UsersClient.GetRecentlyUpdatedUsers(updatedAfterDate))
			{
				RemoveUser(recentlyUpdatedUser);
				ClearUsernameHistory(recentlyUpdatedUser);
			}
			_LastPurge = utcNow;
			_PurgeCheckFailures = 0;
		}
		catch (Exception arg)
		{
			int num = ++_PurgeCheckFailures;
			if (num >= _Settings.MaxCheckFailuresBeforeClearLocalCache)
			{
				ClearCache();
				_Logger.Warning($"Failed to check recently updated users, this will be retried ({num}/{_Settings.MaxCheckFailuresBeforeClearLocalCache}). Purging the local cache because the threshold has been exceeded.\n{arg}");
			}
			else
			{
				_Logger.Warning($"Failed to check recently updated users, this will be retried ({num}/{_Settings.MaxCheckFailuresBeforeClearLocalCache}).\n{arg}");
			}
		}
		finally
		{
			_PurgeDebounce = false;
		}
	}

	private string BuildUsernameHistoryCacheKey(int count, SortOrder sortOrder, long? exclusiveStartId)
	{
		return $"count:{count}_sortOrder:{sortOrder}_exclusiveStartId:{exclusiveStartId}";
	}

	private ConcurrentDictionary<string, HistoricalUsername[]> GetUsernameHistoryCache(long userId)
	{
		return _UsernameHistoryByUserIdCache.GetOrAdd(userId, (long key) => new ConcurrentDictionary<string, HistoricalUsername[]>());
	}

	private void ClearCache()
	{
		_UserCacheById.Clear();
		_UsernameHistoryByUserIdCache.Clear();
	}

	private TimeSpan GetUserLocalCacheExpiry()
	{
		return _Settings.UserLocalCacheExpiry;
	}

	private TimeSpan GetUsernameHistoryCacheExpiry()
	{
		return _Settings.UsernameHistoryCacheExpiry;
	}

	private ConcurrentDictionary<string, HistoricalDisplayName[]> GetDisplayNameHistoryCache(long userId)
	{
		return _DisplayNameHistoryByUserIdCache.GetOrAdd(userId, (long key) => new ConcurrentDictionary<string, HistoricalDisplayName[]>());
	}

	private string BuildDisplayNameHistoryCacheKey(int count, SortOrder sortOrder, long? exclusiveStartId)
	{
		return $"count:{count}_sortOrder:{sortOrder}_exclusiveStartId:{exclusiveStartId}";
	}

	private TimeSpan GetDisplayNameHistoryCacheExpiry()
	{
		return _Settings.DisplayNameHistoryCacheExpiry;
	}
}
