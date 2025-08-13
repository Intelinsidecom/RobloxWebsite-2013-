using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Properties;
using Roblox.UserCacheMigrationSettings.Properties;
using Roblox.Users.Client;

namespace Roblox;

[DebuggerDisplay("Account \"{ID}\"")]
public class Account : MembershipUser, IRobloxEntity<long, AccountDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private class RoleSetSummary
	{
		public RoleSet HighestRoleSet;

		public HashSet<int> RoleSetIds;

		public string[] RoleSetNames;
	}

	internal const string MigrationPerformanceCounterCategory = "Roblox.Users.Service.Migration";

	internal const string MigrationPerformanceCounterCounterName = "Requests/second";

	internal const string MigrationFailurePerformanceCounterCounterName = "Failures/second";

	private const string _MigrationGetByIdInstanceName = "GetAccountById";

	private const string _MigrationMustGetByIdInstanceName = "MustGetAccountById";

	private const string _MigrationGetByNameInstanceName = "GetAccountByName";

	private const string _MigrationMultiGetByIdsInstanceName = "MultiGetAccountsByIds";

	private static readonly ILogger _Logger;

	private static readonly string[] _EmptyRoleSetNames;

	private const int _MaximumRoleSetsPerAccount = 1000;

	private AccountDAL _EntityDAL;

	private static readonly IMigrationCacheabilitySettings _MigrationCacheabilitySettings;

	private static DateTime _RefreshAheadLastUpdated;

	private static int _LastAllAccountRoleSetsListSize;

	private static readonly LazyWithRetry<RefreshAhead<Dictionary<long, RoleSetSummary>>> _AccountIdToRoleSetSummariesLazy;

	public static CacheInfo EntityCacheInfo;

	private static RefreshAhead<Dictionary<long, RoleSetSummary>> _AccountIdToRoleSetSummaries => _AccountIdToRoleSetSummariesLazy.Value;

	public long ID => _EntityDAL.ID;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		private set
		{
			_EntityDAL.Name = value;
		}
	}

	/// <summary>
	/// Marked as internal, should only be used by Platform.Membership
	/// </summary>
	internal string Description => _EntityDAL.Description;

	public byte AccountStatusID
	{
		get
		{
			return _EntityDAL.AccountStatusID;
		}
		internal set
		{
			_EntityDAL.AccountStatusID = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public IEnumerable<string> PreviousUsernames
	{
		get
		{
			User user = User.GetByAccountID(ID);
			if (user == null)
			{
				return new string[0];
			}
			return (from u in User.UsersClient.GetUsernameHistoryByUserId(user.ID, int.MaxValue, SortOrder.Asc, null)
				select u.Name).ToArray();
		}
	}

	[Obsolete("Please use Created.")]
	public override DateTime CreationDate => Created;

	[Obsolete("Please use AccountEmailAddress.GetCurrent instead.")]
	public override string Email
	{
		get
		{
			EmailAddress currentEmailAddress = null;
			AccountEmailAddress currentAccountEmailAddress = AccountEmailAddress.GetCurrent(ID);
			if (currentAccountEmailAddress != null)
			{
				currentEmailAddress = currentAccountEmailAddress.GetEmailAddress();
			}
			if (currentEmailAddress == null)
			{
				return string.Empty;
			}
			return currentEmailAddress.Address;
		}
	}

	public override bool IsApproved => AccountStatusID == AccountStatus.OkId;

	[Obsolete("This only points to Updated.")]
	public override DateTime LastActivityDate => Updated;

	[Obsolete("What is this?")]
	public override string ProviderName => "Roblox";

	[Obsolete("What is this?")]
	public override object ProviderUserKey => ID;

	[Obsolete("Use Name instead.")]
	public override string UserName => Name;

	public CacheInfo CacheInfo => EntityCacheInfo;

	static Account()
	{
		_EmptyRoleSetNames = new string[0];
		_MigrationCacheabilitySettings = new MigrationCacheabilitySettings(Roblox.UserCacheMigrationSettings.Properties.Settings.Default.ToSingleSetting((Roblox.UserCacheMigrationSettings.Properties.Settings s) => s.UserMigrationGroupName), Roblox.UserCacheMigrationSettings.Properties.Settings.Default.ToSingleSetting((Roblox.UserCacheMigrationSettings.Properties.Settings s) => s.UserMigrationState));
		_RefreshAheadLastUpdated = DateTime.MinValue;
		_AccountIdToRoleSetSummariesLazy = new LazyWithRetry<RefreshAhead<Dictionary<long, RoleSetSummary>>>(() => RefreshAhead<Dictionary<long, RoleSetSummary>>.ConstructAndPopulate(Roblox.Properties.Settings.Default.AccountRoleSetSummariesRefreshAheadInterval, delegate(Dictionary<long, RoleSetSummary> oldValue)
		{
			List<AccountRoleSet> list = AccountRoleSet.GetAllAccountRoleSets().ToList();
			DateTime dateTime = list.Max((AccountRoleSet ars) => ars.Updated);
			if (oldValue != null && Roblox.Properties.Settings.Default.SkipRoleSetUpdateIfNoRoleSetUpdated && (dateTime == _RefreshAheadLastUpdated || _LastAllAccountRoleSetsListSize == list.Count || !list.Any()))
			{
				if (Roblox.Properties.Settings.Default.LogAccountRoleSetInfoWhenNoChangeDetected)
				{
					ExceptionHandler.LogException(new Exception($"oldValue.Count(map):{oldValue.Count} LastAllAccountRoleSetsListSize:{_LastAllAccountRoleSetsListSize} allAccountRoleSets.Count:{list.Count}. arsLastUpdated:{dateTime} RefreshAheadLastUpdated:{_RefreshAheadLastUpdated}"), LogLevel.Warning);
				}
				return oldValue;
			}
			_LastAllAccountRoleSetsListSize = list.Count;
			Dictionary<long, RoleSetSummary> dictionary = new Dictionary<long, RoleSetSummary>();
			_RefreshAheadLastUpdated = dateTime;
			foreach (IGrouping<long, AccountRoleSet> current in from g in list
				group g by g.AccountID)
			{
				RoleSet[] source = (from rs in current.Select((AccountRoleSet ars) => ars.RoleSetID).Select(RoleSet.Get)
					where rs != null
					select rs).ToArray();
				IOrderedEnumerable<RoleSet> source2 = source.OrderByDescending((RoleSet r) => r.Rank);
				RoleSetSummary value = new RoleSetSummary
				{
					HighestRoleSet = source2.First(),
					RoleSetIds = new HashSet<int>(source.Select((RoleSet r) => r.ID)),
					RoleSetNames = source2.Select((RoleSet r) => r.Name).ToArray()
				};
				dictionary[current.Key] = value;
			}
			return dictionary;
		}));
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Account", isNullCacheable: true, null, null, _MigrationCacheabilitySettings);
		_Logger = StaticLoggerRegistry.Instance;
		Roblox.Properties.Settings.Default.MonitorChanges((Roblox.Properties.Settings s) => s.AccountRoleSetSummariesRefreshAheadInterval, delegate(TimeSpan interval)
		{
			_AccountIdToRoleSetSummaries.SetRefreshInterval(interval);
		});
	}

	public Account()
	{
		_EntityDAL = new AccountDAL();
	}

	public Account(AccountDAL dal)
	{
		_EntityDAL = dal;
	}

	public Account(UserData userData)
	{
		if (userData == null)
		{
			throw new ArgumentNullException("userData");
		}
		_EntityDAL = new AccountDAL
		{
			ID = userData.AccountId,
			Name = userData.Name,
			Description = userData.Description,
			AccountStatusID = GetAccountStatusId(userData.ModerationStatus),
			Created = userData.Created.ToLocalTime(),
			Updated = userData.Updated.ToLocalTime()
		};
	}

	public bool IsInRole(int roleSetId)
	{
		if (_AccountIdToRoleSetSummaries.Value.TryGetValue(ID, out var rs))
		{
			return rs.RoleSetIds.Contains(roleSetId);
		}
		return false;
	}

	public AccountStatus GetAccountStatus()
	{
		return AccountStatus.MustGet(AccountStatusID);
	}

	internal void InvalidateCacheOnUsernameChange(string newUsername)
	{
		if (!(Name == newUsername))
		{
			Name = newUsername;
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	[Obsolete("Please use AccountPasswordHash.CreateNew directly.")]
	public void SetPassword(string newPassword)
	{
		AccountPasswordHash.CreateNew(ID, newPassword);
	}

	public RoleSet GetHighestRoleSet()
	{
		if (_AccountIdToRoleSetSummaries.Value.TryGetValue(ID, out var rs))
		{
			return rs.HighestRoleSet;
		}
		return RoleSet.Member;
	}

	public ICollection<AccountRoleSet> GetAccountRoleSets()
	{
		return AccountRoleSet.GetAccountRoleSetsByAccountIDPaged(ID, 0, 1000);
	}

	public string[] GetRoleSetNames()
	{
		if (_AccountIdToRoleSetSummaries.Value.TryGetValue(ID, out var rs))
		{
			return rs.RoleSetNames;
		}
		return _EmptyRoleSetNames;
	}

	public IReadOnlyCollection<int> GetRoleSetIds()
	{
		if (_AccountIdToRoleSetSummaries.Value.TryGetValue(ID, out var rs))
		{
			return rs.RoleSetIds;
		}
		return null;
	}

	public bool TestIsSuperAdministrator()
	{
		return IsInRole(RoleSet.SuperAdministrator.ID);
	}

	public bool TestIsCustomerService()
	{
		return IsInRole(RoleSet.CustomerService.ID);
	}

	public bool TestIsModerator()
	{
		return IsInRole(RoleSet.Moderator.ID);
	}

	public bool TestIsSuperModerator()
	{
		return IsInRole(RoleSet.SuperModerator.ID);
	}

	public bool TestIsTrustedContributor()
	{
		return IsInRole(RoleSet.TrustedContributor.ID);
	}

	public bool TestIsReleaseEngineer()
	{
		return IsInRole(RoleSet.ReleaseEngineer.ID);
	}

	public bool TestIsSoothsayer()
	{
		return IsInRole(RoleSet.Soothsayer.ID);
	}

	public bool TestIsContentCreator()
	{
		return IsInRole(RoleSet.ContentCreator.ID);
	}

	public bool TestIsDeveloper()
	{
		return IsInRole(RoleSet.Developer.ID);
	}

	public bool TestIsRegularUser()
	{
		return GetHighestRoleSet().Rank == RoleSet.Member.Rank;
	}

	public bool TestIsCommunityManager()
	{
		return IsInRole(RoleSet.CommunityManager.ID);
	}

	public bool TestIsEconomyManager()
	{
		return IsInRole(RoleSet.EconomyManager.ID);
	}

	public bool TestIsMarketing()
	{
		return IsInRole(RoleSet.Marketing.ID);
	}

	public bool TestIsMarketingManager()
	{
		return IsInRole(RoleSet.MarketingManager.ID);
	}

	public bool TestIsAdOps()
	{
		return IsInRole(RoleSet.AdOps.ID);
	}

	public bool TestIsAdOpsManager()
	{
		return IsInRole(RoleSet.AdOpsManager.ID);
	}

	public bool TestIsModeratorManager()
	{
		return IsInRole(RoleSet.ModeratorManager.ID);
	}

	public bool TestIsCommunityRepresentative()
	{
		return IsInRole(RoleSet.CommunityRepresentative.ID);
	}

	public bool TestIsBursar()
	{
		return IsInRole(RoleSet.Bursar.ID);
	}

	public bool TestIsFinance()
	{
		return IsInRole(RoleSet.Finance.ID);
	}

	public bool TestIsBetaTester()
	{
		return IsInRole(RoleSet.BetaTester.ID);
	}

	public bool TestIsProtectedUser()
	{
		return IsInRole(RoleSet.ProtectedUser.ID);
	}

	public bool TestIsViewer()
	{
		return IsInRole(RoleSet.Viewer.ID);
	}

	public bool TestIsCommunityChampion()
	{
		return IsInRole(RoleSet.CommunityChampion.ID);
	}

	public bool TestIsDevRelManager()
	{
		return IsInRole(RoleSet.DevRelManager.ID);
	}

	public bool TestIsDataAdministrator()
	{
		return IsInRole(RoleSet.DataAdministrator.ID);
	}

	public bool TestIsEventStreamCreator()
	{
		return IsInRole(RoleSet.EventStreamCreator.ID);
	}

	public bool TestIsTranslationManager()
	{
		return IsInRole(RoleSet.TranslationManager.ID);
	}

	public bool TestIsTranslationContributor()
	{
		return IsInRole(RoleSet.TranslationContributor.ID);
	}

	public bool TestIsPIIManager()
	{
		return IsInRole(RoleSet.PIIManager.ID);
	}

	public bool TestIsIT()
	{
		return IsInRole(RoleSet.IT.ID);
	}

	public bool TestIsCSAgentAdmin()
	{
		return IsInRole(RoleSet.CSAgentAdmin.ID);
	}

	public bool TestIsFastTrackMember()
	{
		return IsInRole(RoleSet.FastTrackMember.ID);
	}

	public bool TestIsFastTrackModerator()
	{
		return IsInRole(RoleSet.FastTrackModerator.ID);
	}

	public bool TestIsFastTrackAdmin()
	{
		return IsInRole(RoleSet.FastTrackAdmin.ID);
	}

	public bool TestIsChinaLicenseUser()
	{
		return IsInRole(RoleSet.ChinaLicenseUser.ID);
	}

	public bool TestIsItemManager()
	{
		return IsInRole(RoleSet.ItemManager.ID);
	}

	public bool TestIsCatalogItemCreator()
	{
		return IsInRole(RoleSet.CatalogItemCreator.ID);
	}

	public bool TestIsRccReleaseTesterManager()
	{
		return IsInRole(RoleSet.RccReleaseTesterManager.ID);
	}

	public static Account Get(long id)
	{
		IncrementCounter("GetAccountById");
		if (id % 10000 < Roblox.Properties.Settings.Default.AccountReadByIdViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = User.UsersClient.GetUserByAccountId(id);
				if (userData == null)
				{
					return null;
				}
				return new Account(userData);
			}
			catch (Exception e)
			{
				IncrementCounter("GetAccountById", "Failures/second");
				_Logger.Error(e);
			}
		}
		return EntityHelper.GetEntity<long, AccountDAL, Account>(EntityCacheInfo, id, () => AccountDAL.Get(id));
	}

	public static Account Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static Account Get(string name)
	{
		IncrementCounter("GetAccountByName");
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		if (name.Length > Roblox.Properties.Settings.Default.DatabaseMaxUsernameLength)
		{
			return null;
		}
		if (Math.Abs(name.GetHashCode()) % 10000 < Roblox.Properties.Settings.Default.AccountReadByNameViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = User.UsersClient.GetUserByName(name, includeUsernameHistory: false);
				if (userData == null)
				{
					return null;
				}
				return new Account(userData);
			}
			catch (Exception e)
			{
				IncrementCounter("GetAccountByName", "Failures/second");
				_Logger.Error(e);
			}
		}
		string idLookup = BuildNameLookup(name);
		return EntityHelper.GetEntityByLookup<long, AccountDAL, Account>(EntityCacheInfo, idLookup, () => GetAccountDALByName(name));
	}

	private static AccountDAL GetAccountDALByName(string name)
	{
		if (Roblox.Properties.Settings.Default.RemoteCacheForAccountLookupByNameEnabled)
		{
			string idLookup = BuildNameLookup(name);
			ILookupCache remoteCache = LookupCacheFactory.GetInstance().GetLookupCache(EntityCacheInfo);
			var (found, entityId) = remoteCache.GetEntityIDFromLookupCache<long?>(EntityCacheInfo, idLookup);
			if (found)
			{
				if (!entityId.HasValue)
				{
					return null;
				}
				return Get(entityId)._EntityDAL;
			}
			AccountDAL byName = AccountDAL.GetByName(name);
			remoteCache.AddEntityIDToLookupCache(id: byName?.ID, cacheInfo: EntityCacheInfo, lookup: idLookup);
			return byName;
		}
		return AccountDAL.GetByName(name);
	}

	public static ICollection<Account> MultiGet(ICollection<long> ids)
	{
		IncrementCounter("MultiGetAccountsByIds");
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		if (!ids.Any())
		{
			return Array.Empty<Account>();
		}
		if (Math.Abs(ids.GetHashCode()) % 10000 < Roblox.Properties.Settings.Default.AccountReadByMultiGetViaUsersServiceEnabledPermyriad)
		{
			try
			{
				HashSet<long> distinctIds = new HashSet<long>(ids);
				IDictionary<long, UserData> users = User.UsersClient.MultiGetUsersByAccountIds(distinctIds);
				List<Account> returnAccounts = new List<Account>();
				foreach (long accountId in distinctIds)
				{
					users.TryGetValue(accountId, out var userData);
					if (userData == null)
					{
						returnAccounts.Add(null);
					}
					else
					{
						returnAccounts.Add(new Account(userData));
					}
				}
				return returnAccounts;
			}
			catch (Exception e)
			{
				IncrementCounter("MultiGetAccountsByIds", "Failures/second");
				_Logger.Error(e);
			}
		}
		return EntityHelper.GetEntitiesByIds<Account, AccountDAL, long>(EntityCacheInfo, ids.Distinct().ToList(), AccountDAL.MultiGet).ToList();
	}

	[Obsolete("Please use AccountEmailAddress.GetValidAccountEmailAddresses instead.")]
	public static ICollection<Account> GetAccountsByEmailAddress(string emailAddress)
	{
		ICollection<Account> entities = new List<Account>();
		EmailAddress ea = EmailAddress.Get(emailAddress);
		if (ea != null)
		{
			foreach (AccountEmailAddress validAccountEmailAddress in AccountEmailAddress.GetValidAccountEmailAddresses(ea.ID))
			{
				Account account = validAccountEmailAddress.GetAccount();
				entities.Add(account);
			}
		}
		return entities;
	}

	/// <summary>
	/// Gets the accounts using an email address paged. The list is paged on the AccountEmailAddressId returned, 
	/// to get the next batch pass in the last returned EmailAddressId as the exclusiveStartAccountEmailAddressId.
	/// </summary>
	/// <param name="emailAddress">The email address.</param>
	/// <param name="count">Number of items to get from the starting point ID.</param>
	/// <param name="exclusiveStartAccountEmailAddressId">The starting ID in the sorted list of IDs.</param>
	/// <param name="lastAccountEmailAddressId">The last account email address identifier.</param>
	/// <param name="totalResult">The total result.</param>
	/// <returns>Accounts associated with the given email address within the page constraints</returns>
	[Obsolete("Please use AccountEmailAddress.GetAccountEmailAddressesByEmailAddressID instead.")]
	public static ICollection<Account> GetAccountsByEmailAddressPaged(string emailAddress, int count, int exclusiveStartAccountEmailAddressId, out int lastAccountEmailAddressId, out long totalResult)
	{
		ICollection<Account> entities = new List<Account>();
		lastAccountEmailAddressId = 0;
		totalResult = 0L;
		EmailAddress ea = EmailAddress.Get(emailAddress);
		if (ea != null)
		{
			totalResult = AccountEmailAddress.GetTotalNumberOfAccountEmailAddressesByEmailAddressId(ea.ID);
			foreach (AccountEmailAddress aea in AccountEmailAddress.GetAccountEmailAddressesByEmailAddressID(ea.ID, count, exclusiveStartAccountEmailAddressId))
			{
				Account account = aea.GetAccount();
				entities.Add(account);
				lastAccountEmailAddressId = aea.ID;
			}
		}
		return entities;
	}

	[Obsolete("Use Global.WebAuthenticator.GetAuthenticatedUser() instead")]
	public static Account GetCurrent()
	{
		return GetCurrent(HttpContext.Current);
	}

	[Obsolete("Use Global.WebAuthenticator.GetAuthenticatedUser() instead")]
	public static Account GetCurrent(HttpContext context)
	{
		if (context == null)
		{
			return null;
		}
		IPrincipal user = context.User;
		if (user == null)
		{
			return null;
		}
		IIdentity identity = user.Identity;
		if (identity == null)
		{
			return null;
		}
		string accountName = identity.Name;
		if (accountName.Length == 0)
		{
			return null;
		}
		return Get(accountName);
	}

	[Obsolete("Use Global.WebAuthenticator.GetAuthenticatedUser() instead")]
	public static long? GetCurrentID(HttpContext context)
	{
		return GetCurrent(context)?.ID;
	}

	[Obsolete("Please get the user with WebAuthenticator and check roles with IsInRole.")]
	public static bool IsCurrentAccountInRole(string roleSetName)
	{
		return IsCurrentAccountInRole(HttpContext.Current, roleSetName);
	}

	private static bool IsCurrentAccountInRole(HttpContext context, string roleSetName)
	{
		Account account = GetCurrent(context);
		if (account == null)
		{
			return false;
		}
		RoleSet roleSet = RoleSet.GetByName(roleSetName);
		if (roleSet == null)
		{
			return false;
		}
		return account.IsInRole(roleSet.ID);
	}

	public static Account MustGet(long id)
	{
		IncrementCounter("MustGetAccountById");
		return EntityHelper.MustGet(id, Get);
	}

	public void Construct(AccountDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return BuildNameLookup(Name);
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static void IncrementCounter(string instanceName, string counterName = "Requests/second")
	{
		if (!Roblox.Properties.Settings.Default.TrackUserReadsRequestsPerSecond)
		{
			return;
		}
		try
		{
			StaticCounterRegistry.Instance.GetRateOfCountsPerSecondCounter("Roblox.Users.Service.Migration", counterName, instanceName).Increment();
		}
		catch (Exception)
		{
		}
	}

	private static string BuildNameLookup(string name)
	{
		return string.Format("Name:{0}", name.Replace(" ", "_RBXSPC_"));
	}

	private byte GetAccountStatusId(UserModerationStatus userModerationStatus)
	{
		return userModerationStatus switch
		{
			UserModerationStatus.Suppressed => AccountStatus.SuppressedId, 
			UserModerationStatus.Deleted => AccountStatus.DeletedId, 
			UserModerationStatus.Poisoned => AccountStatus.PoisonedId, 
			UserModerationStatus.MustValidateEmail => AccountStatus.MustValidateEmailId, 
			UserModerationStatus.Forgotten => AccountStatus.ForgottenId, 
			_ => AccountStatus.OkId, 
		};
	}
}
