using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Roblox.Agents;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Data;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Economy;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Moderation;
using Roblox.Properties;
using Roblox.UserCacheMigrationSettings.Properties;
using Roblox.Users;
using Roblox.Users.Client;

namespace Roblox;

[DataContract]
[DataObject]
[DebuggerDisplay("User \"{ID}\"")]
public class User : IEquatable<User>, IPunishableUser, ICreator, IRemoteCacheableObject, IRobloxEntity<long, UserDAL>, ICacheableObject<long>, ICacheableObject
{
	public enum LookupFilter
	{
		AccountID,
		ID
	}

	private const string _MigrationGetByIdInstanceName = "GetUserById";

	private const string _MigrationMustGetByIdInstanceName = "MustGetUserById";

	private const string _MigrationMultiGetByIdsInstanceName = "MultiGetUsersByIds";

	private const string _MigrationGetGroupByUserIdInstanceName = "GetGroupByUserId";

	private const string _MigrationGetByAccountIdInstanceName = "GetUserByAccountId";

	private const string _MigrationGetByNameInstanceName = "GetUserByName";

	private static readonly TimeSpan _1Day;

	private static readonly ILogger _Logger;

	private static readonly IMigrationCacheabilitySettings _MigrationCacheabilitySettings;

	private readonly UserData _UserData;

	private UserDAL _EntityDAL;

	public static readonly IUsersClient UsersClient;

	[Obsolete("Use Roblox.User.Properties.Settings.RobloxUserId")]
	internal static readonly long RobloxAccountID;

	public static CacheInfo EntityCacheInfo;

	[DataObjectField(false)]
	public long AccountID => _EntityDAL.AccountID;

	[DataObjectField(false)]
	public AgeBracket AgeBracket
	{
		get
		{
			return (AgeBracket)_EntityDAL.AgeBracket;
		}
		private set
		{
			_EntityDAL.AgeBracket = (byte)value;
			_EntityDAL.UseSuperSafeConversationMode = UseSuperSafeConversationMode;
			_EntityDAL.UseSuperSafePrivacyMode = UseSuperSafePrivacyMode;
		}
	}

	[DataObjectField(false)]
	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	public bool UseSuperSafeConversationMode => AgeBracket == AgeBracket.AgeUnder13;

	[DataObjectField(false)]
	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	public bool UseSuperSafePrivacyMode => AgeBracket == AgeBracket.AgeUnder13;

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	public long? AssociatedEntityID => _EntityDAL.AssociatedEntityID;

	public CreatorType CreatorType => _EntityDAL.AssociatedEntityTypeID;

	public DateTime? BirthDate
	{
		get
		{
			return _EntityDAL.BirthDate;
		}
		private set
		{
			_EntityDAL.BirthDate = value;
			if (value.HasValue && IsOver13(value.Value))
			{
				AgeBracket = AgeBracket.Age13OrOver;
			}
			else
			{
				AgeBracket = AgeBracket.AgeUnder13;
			}
		}
	}

	public byte? GenderTypeId
	{
		get
		{
			return _EntityDAL.GenderTypeId;
		}
		private set
		{
			_EntityDAL.GenderTypeId = value;
		}
	}

	public DateTime? Updated => _EntityDAL.Updated;

	public List<Badge> Badges => Badge.GetUserBadgesByUserID(ID).ToList();

	public int TotalNumberOfMessages => Message.GetTotalNumberOfUserMessagesReceived(ID, Message.MessagesReceivedFilter.ExcludeInvitations);

	public int TotalNumberOfUnreadMessages => Message.GetTotalNumberOfUnreadUnarchivedMessages(ID);

	[Obsolete("Use Roblox.Platform.Membership.GetRobloxSystemUser")]
	public static User RobloxAccount => Get(RobloxAccountID);

	public bool IsNullCacheable => true;

	[DataMember]
	[DataObjectField(true, true)]
	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		private set
		{
		}
	}

	[DataMember]
	public string Name
	{
		get
		{
			try
			{
				return GetAccount().Name;
			}
			catch (DataIntegrityException ex)
			{
				if (CreatorType == CreatorType.User)
				{
					ExceptionHandler.LogException(ex);
				}
				else
				{
					ExceptionHandler.LogException($"Non-fatal exception: attempt to call User.Name for ID = {ID} and CreatorType {CreatorType}. Stack trace: {new StackTrace()}");
				}
				return "?";
			}
		}
		private set
		{
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event Action<long, byte> AccountStatusChanged;

	static User()
	{
		_1Day = TimeSpan.FromDays(1.0);
		_MigrationCacheabilitySettings = new MigrationCacheabilitySettings(Roblox.UserCacheMigrationSettings.Properties.Settings.Default.ToSingleSetting((Roblox.UserCacheMigrationSettings.Properties.Settings s) => s.UserMigrationGroupName), Roblox.UserCacheMigrationSettings.Properties.Settings.Default.ToSingleSetting((Roblox.UserCacheMigrationSettings.Properties.Settings s) => s.UserMigrationState));
		RobloxAccountID = 1L;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "User", isNullCacheable: true, null, null, _MigrationCacheabilitySettings);
		_Logger = StaticLoggerRegistry.Instance;
		UsersClient = AgentFactory.UsersClient;
	}

	public User(UserDAL dal)
	{
		_EntityDAL = dal;
	}

	public User()
		: this(new UserDAL())
	{
	}

	public User(UserData userData)
	{
		if (userData == null)
		{
			throw new ArgumentNullException("userData");
		}
		DateTime? birthdate = null;
		if (userData.Birthdate.HasValue)
		{
			birthdate = userData.Birthdate.Value.ToLocalTime();
		}
		_UserData = userData;
		_EntityDAL = new UserDAL
		{
			ID = userData.Id,
			AccountID = userData.AccountId,
			AgeBracket = TranslateAgeBracketToByte(userData.AgeBracket),
			BirthDate = birthdate,
			GenderTypeId = TranslateGenderToByte(userData.Gender),
			Created = userData.Created.ToLocalTime(),
			Updated = userData.Updated.ToLocalTime(),
			AssociatedEntityTypeID = CreatorType.User,
			AssociatedEntityID = userData.Id,
			AgeBracketIsLocked = false,
			ConversationSafetyModeIsLocked = false,
			PrivacySafetyModeIsLocked = false,
			UseSuperSafeConversationMode = (userData.AgeBracket == UserAgeBracket.AgeUnder13),
			UseSuperSafePrivacyMode = (userData.AgeBracket == UserAgeBracket.AgeUnder13)
		};
	}

	public Account GetAccount()
	{
		if (_UserData != null && Roblox.Properties.Settings.Default.UserGetAccountCacheEnabled)
		{
			return new Account(_UserData);
		}
		return Account.MustGet(AccountID);
	}

	public bool HasMinimumBCLevelToObtain(Product product)
	{
		if (!Roblox.Properties.Settings.Default.IsBCOnlyRequirementEnabled || product == null || CreatorType == CreatorType.Group)
		{
			return true;
		}
		return HasMinimumBCLevelToObtain(product.ProductOptions);
	}

	public bool HasMinimumBCLevelToObtain(ProductOption productOption)
	{
		if (productOption.MinMembershipType == ProductOption.MembershipTypeMinLevel.All)
		{
			return true;
		}
		if (IsOutrageousBuildersClubMember())
		{
			return true;
		}
		if (IsTurboBuildersClubMember() && productOption.MinMembershipType <= ProductOption.MembershipTypeMinLevel.TurboBuildersClub)
		{
			return true;
		}
		if (IsBuildersClubMember() && productOption.MinMembershipType <= ProductOption.MembershipTypeMinLevel.BuildersClub)
		{
			return true;
		}
		return false;
	}

	public bool IsOwnerOf(AssetSet set)
	{
		return set?.Creator.Equals(this) ?? false;
	}

	public bool IsAnyBuildersClubMember()
	{
		return PremiumFeatureHelper.IsAnyBuildersClubMember(AccountID);
	}

	public bool IsBuildersClubMember()
	{
		return PremiumFeatureHelper.IsBuildersClubMember(AccountID);
	}

	public bool IsTurboBuildersClubMember()
	{
		return PremiumFeatureHelper.IsTurboBuildersClubMember(AccountID);
	}

	public bool IsOutrageousBuildersClubMember()
	{
		return PremiumFeatureHelper.IsOutrageousBuildersClubMember(AccountID);
	}

	public bool IsExBuildersClubMember()
	{
		return PremiumFeatureHelper.IsExBuildersClubMember(AccountID);
	}

	public string GetExBuildersClubMembership()
	{
		return PremiumFeatureHelper.GetExBuildersClubMembership(AccountID);
	}

	public long GetCurrentOrFormerBuildersClubStipend()
	{
		return PremiumFeatureHelper.GetCurrentOrFormerBuildersClubStipend(AccountID);
	}

	public bool TestIsSuperAdministrator()
	{
		return GetAccount().TestIsSuperAdministrator();
	}

	public bool TestIsCustomerService()
	{
		return GetAccount().TestIsCustomerService();
	}

	public bool TestIsModerator()
	{
		return GetAccount().TestIsModerator();
	}

	public bool TestIsSuperModerator()
	{
		return GetAccount().TestIsSuperModerator();
	}

	public bool TestIsTrustedContributor()
	{
		return GetAccount().TestIsTrustedContributor();
	}

	public bool TestIsSoothsayer()
	{
		return GetAccount().TestIsSoothsayer();
	}

	public bool TestIsContentCreator()
	{
		return GetAccount().TestIsContentCreator();
	}

	public bool TestIsDeveloper()
	{
		return GetAccount().TestIsDeveloper();
	}

	public bool TestIsRegularUser()
	{
		return GetAccount().TestIsRegularUser();
	}

	public bool TestIsCommunityManager()
	{
		return GetAccount().TestIsCommunityManager();
	}

	public bool TestIsEconomyManager()
	{
		return GetAccount().TestIsEconomyManager();
	}

	public bool TestIsMarketing()
	{
		return GetAccount().TestIsMarketing();
	}

	public bool TestIsMarketingManager()
	{
		return GetAccount().TestIsMarketingManager();
	}

	public bool TestIsAdOps()
	{
		return GetAccount().TestIsAdOps();
	}

	public bool TestIsAdOpsManager()
	{
		return GetAccount().TestIsAdOpsManager();
	}

	public bool TestIsModeratorManager()
	{
		return GetAccount().TestIsModeratorManager();
	}

	public bool TestIsCommunityRepresentative()
	{
		return GetAccount().TestIsCommunityRepresentative();
	}

	public bool TestIsBursar()
	{
		return GetAccount().TestIsBursar();
	}

	public bool TestIsFinance()
	{
		return GetAccount().TestIsFinance();
	}

	public bool TestIsBetaTester()
	{
		return GetAccount().TestIsBetaTester();
	}

	public bool TestIsProtectedUser()
	{
		return GetAccount().TestIsProtectedUser();
	}

	public bool TestIsReleaseEngineer()
	{
		return GetAccount().TestIsReleaseEngineer();
	}

	public bool TestIsViewer()
	{
		return GetAccount().TestIsViewer();
	}

	public bool TestIsCommunityChampion()
	{
		return GetAccount().TestIsCommunityChampion();
	}

	public bool TestIsDevRelManager()
	{
		return GetAccount().TestIsDevRelManager();
	}

	public bool TestIsDataAdministrator()
	{
		return GetAccount().TestIsDataAdministrator();
	}

	public bool TestIsEventStreamCreator()
	{
		return GetAccount().TestIsEventStreamCreator();
	}

	public bool TestIsTranslationManager()
	{
		return GetAccount().TestIsTranslationManager();
	}

	public bool TestIsTranslationContributor()
	{
		return GetAccount().TestIsTranslationContributor();
	}

	public bool TestIsPIIManager()
	{
		return GetAccount().TestIsPIIManager();
	}

	public bool TestIsIT()
	{
		return GetAccount().TestIsIT();
	}

	public bool TestIsCSAgentAdmin()
	{
		return GetAccount().TestIsCSAgentAdmin();
	}

	public bool TestIsFastTrackMember()
	{
		return GetAccount().TestIsFastTrackMember();
	}

	public bool TestIsFastTrackModerator()
	{
		return GetAccount().TestIsFastTrackModerator();
	}

	public bool TestIsFastTrackAdmin()
	{
		return GetAccount().TestIsFastTrackAdmin();
	}

	public bool TestIsItemManager()
	{
		return GetAccount().TestIsItemManager();
	}

	public bool TestIsChinaLicenseUser()
	{
		return GetAccount().TestIsChinaLicenseUser();
	}

	public bool TestIsCatalogItemCreator()
	{
		return GetAccount().TestIsCatalogItemCreator();
	}

	public bool TestIsRccReleaseTesterManager()
	{
		return GetAccount().TestIsRccReleaseTesterManager();
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public static User Get(long id)
	{
		if (id <= 0)
		{
			return null;
		}
		IncrementCounter("GetUserById");
		if (id % 10000 < Roblox.Properties.Settings.Default.UserReadByIdViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = UsersClient.GetUserById(id);
				if (userData == null)
				{
					return null;
				}
				return new User(userData);
			}
			catch (Exception e)
			{
				IncrementCounter("GetUserById", "Failures/second");
				_Logger.Error(e);
			}
		}
		User entity = EntityHelper.GetEntity<long, UserDAL, User>(EntityCacheInfo, id, () => UserDAL.Get(id));
		if (entity != null && entity.CreatorType == CreatorType.Group)
		{
			IncrementCounter("GetGroupByUserId");
			DebugInfo.Log($"User entity is incorrectly used for getting a group by ID.\n\tGroup agent id: {id}");
			if (Roblox.Properties.Settings.Default.GetUserByGroupAgentIdReturnsNullEnabled)
			{
				return null;
			}
		}
		return entity;
	}

	public static User Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static User Get(string name)
	{
		IncrementCounter("GetUserByName");
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		if (Math.Abs(name.GetHashCode()) % 10000 < Roblox.Properties.Settings.Default.UserReadByNameViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = UsersClient.GetUserByName(name, includeUsernameHistory: false);
				if (userData == null)
				{
					return null;
				}
				return new User(userData);
			}
			catch (Exception e)
			{
				IncrementCounter("GetUserByName", "Failures/second");
				_Logger.Error(e);
			}
		}
		Account account = Account.Get(name);
		if (account == null)
		{
			return null;
		}
		return GetByAccountID(account.ID);
	}

	public static User GetByAccountID(long accountId)
	{
		IncrementCounter("GetUserByAccountId");
		if (accountId % 10000 < Roblox.Properties.Settings.Default.UserReadByAccountIdViaUsersServiceEnabledPermyriad)
		{
			try
			{
				UserData userData = UsersClient.GetUserByAccountId(accountId);
				if (userData == null)
				{
					return null;
				}
				return new User(userData);
			}
			catch (Exception e)
			{
				IncrementCounter("GetUserByAccountId", "Failures/second");
				_Logger.Error(e);
			}
		}
		User entity = EntityHelper.GetEntityByLookup<long, UserDAL, User>(EntityCacheInfo, "AccountID:" + accountId, () => GetUserDALByAccountID(accountId));
		if (accountId == 0L && entity != null)
		{
			DebugInfo.Log($"User entity is not null when get by accountID {accountId}. Userid is {entity.ID}. CreatorType is {entity.CreatorType}");
		}
		return entity;
	}

	[Obsolete("This just returns agentId (the input).")]
	public static long GetUserIDByAgentID(long agentId)
	{
		return agentId;
	}

	[Obsolete("Use Global.WebAuthenticator.GetAuthenticatedUser() instead")]
	public static User GetCurrent()
	{
		Account currentAccount = Account.GetCurrent();
		if (currentAccount == null)
		{
			return null;
		}
		return GetByAccountID(currentAccount.ID);
	}

	[Obsolete("Use Global.WebAuthenticator.GetAuthenticatedUser() instead")]
	public static User GetCurrent(HttpContext context)
	{
		Account currentAccount = Account.GetCurrent(context);
		if (currentAccount == null)
		{
			return null;
		}
		return GetByAccountID(currentAccount.ID);
	}

	[Obsolete("Use Global.WebAuthenticator.GetAuthenticatedUser() instead")]
	public static long? GetCurrentID()
	{
		return GetCurrent()?.ID;
	}

	[Obsolete("Use Global.WebAuthenticator.GetAuthenticatedUser() instead")]
	public static long? GetCurrentID(HttpContext context)
	{
		return GetCurrent(context)?.ID;
	}

	public static User MustGet(long id)
	{
		IncrementCounter("MustGetUserById");
		return EntityHelper.MustGet(id, Get);
	}

	public bool Equals(User other)
	{
		return ID == other?.ID;
	}

	public void SetAccountStatus(IAccountStatus newStatus, bool overrideProgression)
	{
		Account account = GetAccount();
		byte currentStatusId = account.AccountStatusID;
		if (newStatus.ID > currentStatusId || overrideProgression)
		{
			account.AccountStatusID = newStatus.ID;
			UserModerationStatus userModerationStatus = TranslateAccountStatusId(newStatus.ID);
			UsersClient.SetUserModerationStatus(ID, userModerationStatus);
			CacheManager.ProcessEntityChange(account, StateChangeEventType.Modification);
		}
		User.AccountStatusChanged?.Invoke(ID, account.AccountStatusID);
	}

	public void SetBirthdate(DateTime? newBirthdate)
	{
		BirthDate = newBirthdate;
		UsersClient.SetUserBirthdate(ID, newBirthdate);
		CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
	}

	public void SetAgeBracket(AgeBracket ageBracket)
	{
		AgeBracket = ageBracket;
		UsersClient.SetUserAgeBracket(ID, TranslateAgeBracket(ageBracket));
		CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
	}

	public void SetGender(byte? genderTypeId)
	{
		GenderTypeId = genderTypeId;
		UsersClient.SetUserGender(ID, TranslateGenderTypeId(genderTypeId));
		CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
	}

	[Obsolete("Use ID.ToString() directly.")]
	public string GetIdentifier()
	{
		return ID.ToString();
	}

	[Obsolete("Agent IDs are just User.ID. Use ID directly.")]
	public long GetAgentID()
	{
		return ID;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(UserDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "AccountID:" + AccountID;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	internal static ICollection<User> MultiGet(ICollection<long> ids)
	{
		IncrementCounter("MultiGetUsersByIds");
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		if (!ids.Any())
		{
			return Array.Empty<User>();
		}
		if (Math.Abs(ids.GetHashCode()) % 10000 < Roblox.Properties.Settings.Default.UserReadByMultiGetViaUsersServiceEnabledPermyriad)
		{
			try
			{
				HashSet<long> distinctIds = new HashSet<long>(ids);
				IDictionary<long, UserData> users = UsersClient.MultiGetUsersByIds(distinctIds);
				List<User> returnUsers = new List<User>();
				foreach (long userId in distinctIds)
				{
					users.TryGetValue(userId, out var userData);
					if (userData == null)
					{
						returnUsers.Add(null);
					}
					else
					{
						returnUsers.Add(new User(userData));
					}
				}
				return returnUsers;
			}
			catch (Exception e)
			{
				IncrementCounter("MultiGetUsersByIds", "Failures/second");
				_Logger.Error(e);
			}
		}
		return EntityHelper.GetEntitiesByIds<User, UserDAL, long>(EntityCacheInfo, ids.Distinct().ToList(), UserDAL.MultiGet).ToList();
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

	private static UserDAL GetUserDALByAccountID(long accountId)
	{
		if (!Roblox.Properties.Settings.Default.RemoteCacheForUserByAccountIdLookupEnabled)
		{
			return UserDAL.GetByAccountID(accountId);
		}
		ILookupCache remoteCache = LookupCacheFactory.GetInstance().GetLookupCache(EntityCacheInfo);
		string accountIdToUserIdLookupKey = "AccountIDToUserID:" + accountId;
		var (found, userId) = remoteCache.GetEntityIDFromLookupCache<long>(EntityCacheInfo, accountIdToUserIdLookupKey);
		if (found)
		{
			return Get(userId)?._EntityDAL;
		}
		UserDAL userDal = UserDAL.GetByAccountID(accountId);
		if (userDal != null)
		{
			remoteCache.AddEntityIDToLookupCache(EntityCacheInfo, accountIdToUserIdLookupKey, userDal.ID);
		}
		return userDal;
	}

	internal static UserModerationStatus TranslateAccountStatusId(byte accountStatusId)
	{
		if (accountStatusId == AccountStatus.OkId)
		{
			return UserModerationStatus.Ok;
		}
		if (accountStatusId == AccountStatus.MustValidateEmailId)
		{
			return UserModerationStatus.MustValidateEmail;
		}
		if (accountStatusId == AccountStatus.SuppressedId)
		{
			return UserModerationStatus.Suppressed;
		}
		if (accountStatusId == AccountStatus.DeletedId)
		{
			return UserModerationStatus.Deleted;
		}
		if (accountStatusId == AccountStatus.ForgottenId)
		{
			return UserModerationStatus.Forgotten;
		}
		if (accountStatusId == AccountStatus.PoisonedId)
		{
			return UserModerationStatus.Poisoned;
		}
		throw new NotImplementedException($"Missing accountStatusId ({accountStatusId}) translation.");
	}

	internal static UserAgeBracket TranslateAgeBracket(AgeBracket ageBracket)
	{
		if (ageBracket != AgeBracket.AgeUnder13 && ageBracket == AgeBracket.Age13OrOver)
		{
			return UserAgeBracket.Age13OrOver;
		}
		return UserAgeBracket.AgeUnder13;
	}

	internal static UserGender TranslateGenderTypeId(byte? genderTypeId)
	{
		if (genderTypeId == GenderType.MaleID)
		{
			return UserGender.Male;
		}
		if (genderTypeId == GenderType.FemaleID)
		{
			return UserGender.Female;
		}
		return UserGender.Unknown;
	}

	private bool IsOver13(DateTime birthdate)
	{
		return RoundDownBirthdate(birthdate.AddYears(13)) <= DateTime.Now;
	}

	private DateTime RoundDownBirthdate(DateTime birthdate)
	{
		return birthdate.AddTicks(-(birthdate.Ticks % _1Day.Ticks));
	}

	private byte TranslateAgeBracketToByte(UserAgeBracket userAgeBracket)
	{
		if (userAgeBracket == UserAgeBracket.Age13OrOver)
		{
			return 2;
		}
		return 1;
	}

	private byte TranslateGenderToByte(UserGender userGender)
	{
		return userGender switch
		{
			UserGender.Male => GenderType.MaleID, 
			UserGender.Female => GenderType.FemaleID, 
			_ => GenderType.UnknownID, 
		};
	}
}
