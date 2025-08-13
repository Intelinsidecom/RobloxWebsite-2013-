using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Entities;
using Roblox.Platform.Membership.Properties;
using Roblox.Users.Client;
using Roblox.Users.Properties;

namespace Roblox.Platform.Membership;

public class UserFactory : IUserFactory
{
	private const string _UsersServiceCounterCategory = "Roblox.Users.Service.Migration";

	private const string _RequestsCounterName = "Requests/second";

	private const string _FailuresCounterName = "Failures/second";

	private const string _GetUserByIdInstanceName = "UserFactoryGetUserById";

	private const string _GetUserByAccountIdInstanceName = "UserFactoryGetUserByAccountId";

	private const string _GetUserByNameInstanceName = "UserFactoryGetUserByName";

	private const string _GetUsersInstanceName = "UserFactoryGetUsers";

	private IUser RobloxSystemUser;

	private readonly MembershipDomainFactories _DomainFactories;

	private readonly IUsersClient _UsersClient;

	private readonly ISettings _Settings;

	private readonly ICounterRegistry _CounterRegistry;

	private static readonly ILogger _Logger;

	private static readonly Lazy<MembershipDomainFactories> _DomainFactoriesSingletonForStaticFunctions;

	private long RobloxSystemUserId => Roblox.Users.Properties.Settings.Default.RobloxUserId;

	[Obsolete("Use (new MembershipDomainFactories(new TextFilterFactory().GetTextFilter()).UserFactory instead")]
	public UserFactory()
		: this(_DomainFactoriesSingletonForStaticFunctions.Value)
	{
	}

	internal UserFactory(MembershipDomainFactories factories)
		: this(factories, factories.UsersClient, factories.Settings, factories.CounterRegistry)
	{
	}

	internal UserFactory(MembershipDomainFactories factories, IUsersClient usersClient, ISettings settings, ICounterRegistry counterRegistry)
	{
		_DomainFactories = factories ?? throw new ArgumentNullException("factories");
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	static UserFactory()
	{
		_Logger = StaticLoggerRegistry.Instance;
		_DomainFactoriesSingletonForStaticFunctions = new Lazy<MembershipDomainFactories>(() => new MembershipDomainFactories(_Logger, StaticCounterRegistry.Instance));
	}

	public IUser CreateNewUser(string username, string password)
	{
		UserData serviceUser = _UsersClient.CreateUser(username);
		AccountPasswordHash.CreateNew(serviceUser.AccountId, password);
		return Translate(serviceUser, shouldReturnForgottenUser: true);
	}

	private IUser GetUserByPreviousName(string name, bool shouldReturnForgottenUser)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		UserData serviceUser = _UsersClient.GetUserByName(name, includeUsernameHistory: true);
		return Translate(serviceUser, shouldReturnForgottenUser);
	}

	public IUser GetUserByAnyName(string name, bool shouldReturnForgottenUser = false)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		return GetUserByName(name, shouldReturnForgottenUser) ?? GetUserByPreviousName(name, shouldReturnForgottenUser);
	}

	private IUser GetUser(IUserEntity userEntity, bool shouldReturnForgottenUser)
	{
		if (userEntity == null || userEntity.CreatorType != CreatorType.User)
		{
			return null;
		}
		IAccountEntity accountEntity = _DomainFactories.AccountEntityFactory.MustGetAccount(userEntity.AccountID);
		if (accountEntity.AccountStatus == AccountStatus.Forgotten && !shouldReturnForgottenUser && _DomainFactories.Settings.UserFactoryReturnsNullForForgottenUsers)
		{
			return null;
		}
		return new User(userEntity, accountEntity);
	}

	public IUser GetUser(long id, bool shouldReturnForgottenUser = false)
	{
		if (id <= 0)
		{
			return null;
		}
		IncrementCounter("UserFactoryGetUserById", "Requests/second");
		if (id % 10000 < _Settings.UserFactoryReadByIdViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = _UsersClient.GetUserById(id);
				return Translate(userData, shouldReturnForgottenUser);
			}
			catch (Exception e)
			{
				IncrementCounter("UserFactoryGetUserById", "Failures/second");
				_Logger.Error(e);
			}
		}
		IUserEntity userEntity = _DomainFactories.UserEntityFactory.GetUser(id);
		return GetUser(userEntity, shouldReturnForgottenUser);
	}

	/// <inheritdoc />
	public IUser MustGetUser(long id, bool shouldReturnForgottenUser = false)
	{
		IUser user = GetUser(id, shouldReturnForgottenUser);
		user.VerifyIsNotNull();
		return user;
	}

	public IUser GetUserByAccountId(long accountId, bool shouldReturnForgottenUser = false)
	{
		if (accountId <= 0)
		{
			return null;
		}
		IncrementCounter("UserFactoryGetUserByAccountId", "Requests/second");
		if (accountId % 10000 < _Settings.UserFactoryReadByAccountIdViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = _UsersClient.GetUserByAccountId(accountId);
				return Translate(userData, shouldReturnForgottenUser);
			}
			catch (Exception e)
			{
				IncrementCounter("UserFactoryGetUserByAccountId", "Failures/second");
				_Logger.Error(e);
			}
		}
		IUserEntity userEntity = _DomainFactories.UserEntityFactory.GetUserByAccountId(accountId);
		return GetUser(userEntity, shouldReturnForgottenUser);
	}

	public IUser GetUserByName(string name, bool shouldReturnForgottenUser)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		IncrementCounter("UserFactoryGetUserByName", "Requests/second");
		if (Math.Abs(name.GetHashCode()) % 10000 < _Settings.UserFactoryReadByNameViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = _UsersClient.GetUserByName(name, includeUsernameHistory: false);
				return Translate(userData, shouldReturnForgottenUser);
			}
			catch (Exception e)
			{
				IncrementCounter("UserFactoryGetUserByName", "Failures/second");
				_Logger.Error(e);
			}
		}
		IAccountEntity accountEntity = _DomainFactories.AccountEntityFactory.GetAccount(name);
		if (accountEntity == null)
		{
			return null;
		}
		if (accountEntity.AccountStatus == AccountStatus.Forgotten && !shouldReturnForgottenUser && _DomainFactories.Settings.UserFactoryReturnsNullForForgottenUsers)
		{
			return null;
		}
		IUserEntity userEntity = _DomainFactories.UserEntityFactory.GetUserByAccountId(accountEntity.Id);
		if (userEntity != null)
		{
			return new User(userEntity, accountEntity);
		}
		return null;
	}

	public ICollection<IUser> GetUsers(ICollection<long> ids, bool shouldReturnForgottenUser = false)
	{
		if (ids == null)
		{
			throw new PlatformArgumentNullException("ids");
		}
		if (ids.Count == 0)
		{
			return Array.Empty<IUser>();
		}
		IncrementCounter("UserFactoryGetUsers", "Requests/second");
		if (Math.Abs(ids.GetHashCode()) % 10000 < _Settings.UserFactoryReadByMultiGetViaUsersServiceEnabledPermyriad)
		{
			try
			{
				HashSet<long> idSet = new HashSet<long>(ids);
				IDictionary<long, UserData> userDatas = _UsersClient.MultiGetUsersByIds(idSet);
				List<IUser> resultUsers = new List<IUser>();
				foreach (long id in idSet)
				{
					if (userDatas.TryGetValue(id, out var userData) && userData != null)
					{
						resultUsers.Add(Translate(userData, shouldReturnForgottenUser));
					}
				}
				return resultUsers;
			}
			catch (Exception e)
			{
				IncrementCounter("UserFactoryGetUsers", "Failures/second");
				_Logger.Error(e);
			}
		}
		ids = ids.Distinct().ToArray();
		IUserEntity[] userEntities = (from x in _DomainFactories.UserEntityFactory.GetUsers(ids)
			where x != null
			select x).ToArray();
		IEnumerable<IAccountEntity> accountEntities = from x in _DomainFactories.AccountEntityFactory.GetAccounts(userEntities.Select((IUserEntity u) => u.AccountID).ToList())
			where x != null
			select x;
		if (!shouldReturnForgottenUser && _DomainFactories.Settings.UserFactoryReturnsNullForForgottenUsers)
		{
			accountEntities = accountEntities.Where((IAccountEntity x) => x.AccountStatus != AccountStatus.Forgotten);
		}
		return (from u in userEntities
			join a in accountEntities on u.AccountID equals a.Id
			select new User(u, a)).ToArray();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.IUserFactory.MultiGetUsers(System.Collections.Generic.ICollection{System.Int64},System.Boolean)" />
	public IReadOnlyDictionary<long, IUser> MultiGetUsers(ICollection<long> ids, bool shouldReturnForgottenUsers = false)
	{
		long[] distinctUserIds = ids.Distinct().ToArray();
		Dictionary<long, IUser> users = (from u in GetUsers(distinctUserIds, shouldReturnForgottenUsers)
			where u != null
			select u).ToDictionary((IUser u) => u.Id);
		Dictionary<long, IUser> usersDictionary = new Dictionary<long, IUser>(distinctUserIds.Length);
		long[] array = distinctUserIds;
		foreach (long id in array)
		{
			users.TryGetValue(id, out var user);
			usersDictionary.Add(id, user);
		}
		return usersDictionary;
	}

	public IReadOnlyDictionary<string, IUser> MultiGetUsersByNames(ISet<string> names, bool includePreviousUsernames, bool shouldReturnForgottenUsers)
	{
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		IDictionary<string, UserData> userEntities = _UsersClient.MultiGetUsersByNames(names, includePreviousUsernames);
		Dictionary<string, IUser> result = new Dictionary<string, IUser>(StringComparer.OrdinalIgnoreCase);
		foreach (string name in names)
		{
			if (userEntities.TryGetValue(name, out var userData) && userData != null && (userData.ModerationStatus != UserModerationStatus.Forgotten || !shouldReturnForgottenUsers))
			{
				result[name] = new User(userData);
			}
			else
			{
				result[name] = null;
			}
		}
		return result;
	}

	public long GetRobloxSystemUserId()
	{
		return RobloxSystemUserId;
	}

	public IUser GetRobloxSystemUser()
	{
		if (RobloxSystemUser == null)
		{
			RobloxSystemUser = GetUser(RobloxSystemUserId);
		}
		return RobloxSystemUser;
	}

	private IUser Translate(UserData userData, bool shouldReturnForgottenUser)
	{
		if (userData == null)
		{
			return null;
		}
		if (userData.ModerationStatus == UserModerationStatus.Forgotten && !shouldReturnForgottenUser && _DomainFactories.Settings.UserFactoryReturnsNullForForgottenUsers)
		{
			return null;
		}
		return new User(userData);
	}

	private void IncrementCounter(string instanceName, string counterName)
	{
		_CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Users.Service.Migration", counterName, instanceName).Increment();
	}
}
