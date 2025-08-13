using System;
using System.Text;
using Roblox.Locking;
using Roblox.Platform.Authentication;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Commands;
using Roblox.Platform.XboxLive.Entities;
using Roblox.Platform.XboxLive.Properties;
using Roblox.Users.Client;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.XboxLive.IXboxLiveUserManager" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.XboxLive.IXboxLiveUserManager" />
public class XboxLiveUserManager : IXboxLiveUserManager
{
	private readonly IXboxLiveAccountDataAccessor _XboxLiveAccountDataAccessor;

	private readonly IPasswordValidatorFactory _PasswordValidatorFactory;

	private readonly IUserFactory _UserFactory;

	private readonly IUsernameValidator _UsernameValidator;

	private readonly IUsersClient _UsersClient;

	private readonly IXboxLiveSettings _XboxLiveSettings;

	public event Action<IXboxLiveAccount> OnXboxLiveAccountDisconnected;

	internal virtual ILeasedLock GetLeasedLock(long accountId)
	{
		return new SqlLeasedLock($"ManagingXboxLiveAccount_UnlinkRobloxAccount:{accountId}", ParallelTaskWorker.ID, _XboxLiveSettings.XboxLiveAccountManagementLockTimeout);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.XboxLive.XboxLiveUserManager" /> class.
	/// </summary>
	/// <param name="xboxLiveAccountDataAccessor">The <see cref="T:Roblox.Platform.Authentication.IXboxLiveAccountDataAccessor" />r.</param>
	/// <param name="passwordValidatorFactory">The <see cref="T:Roblox.Platform.Membership.IPasswordValidatorFactory" />y.</param>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="usernameValidator">The <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="xboxLiveAccountDataAccessor" />
	/// - <paramref name="passwordValidatorFactory" />
	/// - <paramref name="userFactory" />
	/// - <paramref name="usernameValidator" />
	/// </exception>
	public XboxLiveUserManager(IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IPasswordValidatorFactory passwordValidatorFactory, IUserFactory userFactory, IUsernameValidator usernameValidator)
		: this(xboxLiveAccountDataAccessor, passwordValidatorFactory, userFactory, usernameValidator, User.UsersClient, Roblox.Platform.XboxLive.Properties.Settings.Default)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.XboxLive.XboxLiveUserManager" />.
	/// </summary>
	/// <param name="xboxLiveAccountDataAccessor">An <see cref="T:Roblox.Platform.Authentication.IXboxLiveAccountDataAccessor" />r.</param>
	/// <param name="passwordValidatorFactory">An <see cref="T:Roblox.Platform.Membership.IPasswordValidatorFactory" />y.</param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="usernameValidator">An <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidator" />.</param>
	/// <param name="usersClient">An <see cref="T:Roblox.Users.Client.IUsersClient" />.</param>
	/// <param name="xboxLiveSettings">An <see cref="T:Roblox.Platform.XboxLive.Properties.IXboxLiveSettings" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="xboxLiveAccountDataAccessor" />
	/// - <paramref name="passwordValidatorFactory" />
	/// - <paramref name="userFactory" />
	/// - <paramref name="usernameValidator" />
	/// - <paramref name="xboxLiveSettings" />
	/// </exception>
	internal XboxLiveUserManager(IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IPasswordValidatorFactory passwordValidatorFactory, IUserFactory userFactory, IUsernameValidator usernameValidator, IUsersClient usersClient, IXboxLiveSettings xboxLiveSettings)
	{
		_XboxLiveAccountDataAccessor = xboxLiveAccountDataAccessor ?? throw new ArgumentNullException("xboxLiveAccountDataAccessor");
		_PasswordValidatorFactory = passwordValidatorFactory ?? throw new ArgumentNullException("passwordValidatorFactory");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_UsernameValidator = usernameValidator ?? throw new ArgumentNullException("usernameValidator");
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
		_XboxLiveSettings = xboxLiveSettings ?? throw new ArgumentNullException("xboxLiveSettings");
	}

	public virtual ILeasedLock GetLeasedLock(string pairwiseId)
	{
		return new SqlLeasedLock("ManagingXboxLiveAccount:" + pairwiseId, ParallelTaskWorker.ID, Roblox.Platform.XboxLive.Properties.Settings.Default.XboxLiveAccountManagementLockTimeout);
	}

	public void LinkExistingUser(IUser user, string pairwiseId, string gamerTag, string ageGroup)
	{
		if (!_XboxLiveSettings.XboxLiveSignupEnabled)
		{
			throw new PlatformOperationUnavailableException("SignUpDisabled");
		}
		if (!_XboxLiveSettings.XboxLiveAccountLinkingEnabled)
		{
			throw new PlatformOperationUnavailableException("AccountLinkingDisabled");
		}
		using ILeasedLock leasedLock = GetLeasedLock(pairwiseId);
		if (!leasedLock.IsLockAcquired)
		{
			throw new PlatformOperationUnavailableException("LeaseLocked");
		}
		if (user == null)
		{
			throw new PlatformArgumentException("InvalidRobloxUser");
		}
		if (IsXboxLiveUser(user))
		{
			throw new PlatformInvalidOperationException("RobloxUserAlreadyLinked");
		}
		IXboxLiveAccount xboxLiveAccountEntity = _XboxLiveAccountDataAccessor.GetByXboxLivePairwiseId(pairwiseId);
		if (xboxLiveAccountEntity != null)
		{
			throw new PlatformInvalidOperationException("XboxUserAlreadyLinked");
		}
		if (Enum.TryParse<XboxLiveAgeGroup>(ageGroup, out var xboxLiveAgeGroup) && xboxLiveAgeGroup == XboxLiveAgeGroup.Child && user.AgeBracket == Roblox.Platform.Membership.AgeBracket.Age13OrOver)
		{
			throw new PlatformInvalidOperationException("IllegalChildAccountLinking");
		}
		xboxLiveAccountEntity = _XboxLiveAccountDataAccessor.CreateNew(pairwiseId, gamerTag, user.AccountId);
		if (xboxLiveAccountEntity == null)
		{
			throw new PlatformException("Error");
		}
		_XboxLiveAccountDataAccessor.LogXboxLiveAccountAction(user.AccountId, XboxLiveAccountActionType.LinkAccount, xboxLiveAccountEntity.XboxLivePairwiseId, xboxLiveAccountEntity.XboxLiveGamerTagHash);
	}

	[Obsolete]
	public void SetRobloxUsernameAndPassword(string pairwiseId, string username, string password, bool mustUsePiiFiltersForU13Usernames)
	{
		if (!_XboxLiveSettings.XboxLiveAccountLinkingEnabled)
		{
			throw new PlatformOperationUnavailableException("AccountLinkingDisabled");
		}
		using ILeasedLock leasedLock = GetLeasedLock(pairwiseId);
		if (!leasedLock.IsLockAcquired)
		{
			throw new PlatformOperationUnavailableException("LeaseLocked");
		}
		IXboxLiveAccount xboxLiveAccountEntity = _XboxLiveAccountDataAccessor.GetByXboxLivePairwiseId(pairwiseId);
		if (xboxLiveAccountEntity == null)
		{
			throw new PlatformArgumentException("InvalidXboxUser");
		}
		Account account = Account.Get(xboxLiveAccountEntity.AccountId);
		if (account == null)
		{
			throw new PlatformArgumentException("InvalidRobloxUser");
		}
		if (_XboxLiveAccountDataAccessor.HasSetUsernamePassword(xboxLiveAccountEntity.AccountId))
		{
			throw new PlatformInvalidOperationException("AlreadySet");
		}
		IUser user = _UserFactory.GetUserByName(username);
		IUsernameValidationResult usernameValidationResult = _UsernameValidator.ValidateUsername(username, user, mustUsePiiFiltersForU13Usernames);
		if (!usernameValidationResult.IsValid)
		{
			throw new PlatformArgumentException(usernameValidationResult.ErrorMessage);
		}
		if (!_PasswordValidatorFactory.CheckPasswordRules(username, password))
		{
			throw new PlatformArgumentException("InvalidPassword");
		}
		_UsersClient.ChangeUsername(user.Id, account.Name, username, recordHistory: false);
		account.SetPassword(password);
		_XboxLiveAccountDataAccessor.LogXboxLiveAccountAction(account.ID, XboxLiveAccountActionType.SetUsernamePassword, xboxLiveAccountEntity.XboxLivePairwiseId, xboxLiveAccountEntity.XboxLiveGamerTagHash);
	}

	public void UnlinkXboxLiveAccountFromRobloxAccount(string pairwiseId)
	{
		if (!_XboxLiveSettings.XboxLiveAccountLinkingEnabled)
		{
			throw new PlatformOperationUnavailableException("AccountLinkingDisabled");
		}
		using ILeasedLock leasedLock = GetLeasedLock(pairwiseId);
		if (!leasedLock.IsLockAcquired)
		{
			throw new PlatformOperationUnavailableException("LeaseLocked");
		}
		IXboxLiveAccount xboxLiveAccountEntity = _XboxLiveAccountDataAccessor.GetByXboxLivePairwiseId(pairwiseId);
		if (xboxLiveAccountEntity == null)
		{
			throw new PlatformArgumentException("InvalidXboxUser");
		}
		IUser user = _UserFactory.GetUserByAccountId(xboxLiveAccountEntity.AccountId);
		if (user == null)
		{
			throw new PlatformArgumentException("InvalidRobloxUser");
		}
		string pairwiseIdToLog = xboxLiveAccountEntity.XboxLivePairwiseId;
		string gameTagHashToLog = xboxLiveAccountEntity.XboxLiveGamerTagHash;
		_XboxLiveAccountDataAccessor.Delete(xboxLiveAccountEntity);
		_XboxLiveAccountDataAccessor.LogXboxLiveAccountAction(user.AccountId, XboxLiveAccountActionType.UnlinkAccount, pairwiseIdToLog, gameTagHashToLog);
		this.OnXboxLiveAccountDisconnected?.Invoke(xboxLiveAccountEntity);
	}

	public void UnlinkRobloxAccountFromXboxLiveAccount(long accountId)
	{
		if (!_XboxLiveSettings.XboxLiveAccountLinkingEnabled)
		{
			throw new PlatformOperationUnavailableException("AccountLinkingDisabled");
		}
		using ILeasedLock leasedLock = GetLeasedLock(accountId);
		if (!leasedLock.IsLockAcquired)
		{
			throw new PlatformOperationUnavailableException("LeasedLocked");
		}
		IXboxLiveAccount xboxLiveAccountEntity = _XboxLiveAccountDataAccessor.GetByAccountId(accountId);
		if (xboxLiveAccountEntity == null)
		{
			throw new PlatformInvalidOperationException("NoLinkedAccount");
		}
		_XboxLiveAccountDataAccessor.Delete(xboxLiveAccountEntity);
		_XboxLiveAccountDataAccessor.LogXboxLiveAccountAction(accountId, XboxLiveAccountActionType.UnlinkAccount, xboxLiveAccountEntity.XboxLivePairwiseId, xboxLiveAccountEntity.XboxLiveGamerTagHash);
		this.OnXboxLiveAccountDisconnected?.Invoke(xboxLiveAccountEntity);
	}

	public bool SynchronizeGamerTagHash(string pairwiseId, string gamerTag)
	{
		IXboxLiveAccount xboxLiveAccount = _XboxLiveAccountDataAccessor.GetByXboxLivePairwiseId(pairwiseId);
		if (xboxLiveAccount == null)
		{
			throw new PlatformArgumentException("Xbox Live Account does not exist");
		}
		string gamerTagAndSalt = gamerTag + Roblox.Platform.Authentication.Properties.Settings.Default.XboxLiveGamerTagSecretSalt;
		string xboxLiveGamerTagHash = HashFunctions.ComputeHashString(Encoding.UTF8.GetBytes(gamerTagAndSalt));
		if (!string.Equals(xboxLiveAccount.XboxLiveGamerTagHash, xboxLiveGamerTagHash))
		{
			string oldGamerTagHash = xboxLiveAccount.XboxLiveGamerTagHash;
			xboxLiveAccount.XboxLiveGamerTagHash = xboxLiveGamerTagHash;
			_XboxLiveAccountDataAccessor.Save(xboxLiveAccount);
			_XboxLiveAccountDataAccessor.LogXboxLiveAccountAction(xboxLiveAccount.AccountId, XboxLiveAccountActionType.GamerTagHashChanged, xboxLiveAccount.XboxLivePairwiseId, oldGamerTagHash);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Xbox Login Consecutive Days for Achievments
	/// </summary>
	/// <param name="user"></param>
	/// <param name="clientLastSeen">TimeStamp from the client. Not from server</param>
	/// <returns>true: if incremented or changed, false: no change (login within the same day)</returns>
	public bool TryIncrementXboxUserLoginConsecutiveDayCount(IUser user, DateTime clientLastSeen)
	{
		if (!Roblox.Platform.XboxLive.Properties.Settings.Default.XboxUserLoginConsecutiveDayCountEnabled)
		{
			return false;
		}
		if (user == null)
		{
			return false;
		}
		XboxUserLoginConsecutiveDayCount xboxUserLoginConsecutiveDayCount = XboxUserLoginConsecutiveDayCount.GetOrCreate(user.Id);
		if (xboxUserLoginConsecutiveDayCount.ClientLastSeen.HasValue)
		{
			double calendarDaysSinceLastLogin = clientLastSeen.Date.Subtract(xboxUserLoginConsecutiveDayCount.ClientLastSeen.Value.Date).TotalDays;
			if (calendarDaysSinceLastLogin >= 1.0 && calendarDaysSinceLastLogin < 2.0)
			{
				xboxUserLoginConsecutiveDayCount.Increment();
				xboxUserLoginConsecutiveDayCount.ClientLastSeen = clientLastSeen;
				xboxUserLoginConsecutiveDayCount.Save();
				return true;
			}
			if (calendarDaysSinceLastLogin < 1.0)
			{
				return false;
			}
		}
		xboxUserLoginConsecutiveDayCount.Count = 1;
		xboxUserLoginConsecutiveDayCount.ClientLastSeen = clientLastSeen;
		xboxUserLoginConsecutiveDayCount.Save();
		return true;
	}

	public int GetLoginConsecutiveDayCount(IUser user)
	{
		if (!user.IsXboxLiveUser(this))
		{
			throw new PlatformArgumentException("Invalid Xbox User");
		}
		return XboxUserLoginConsecutiveDayCount.GetOrCreate(user.Id).Count;
	}

	public bool IsXboxLiveUser(IUser user)
	{
		if (user == null)
		{
			return false;
		}
		return _XboxLiveAccountDataAccessor.GetByAccountId(user.AccountId) != null;
	}

	public bool IsXboxGamerTagValid(IUser user, string gamerTag)
	{
		if (user == null)
		{
			return false;
		}
		IXboxLiveAccount account = _XboxLiveAccountDataAccessor.GetByXboxLiveGamerTag(gamerTag);
		if (account != null)
		{
			return account.AccountId == user.AccountId;
		}
		return false;
	}
}
