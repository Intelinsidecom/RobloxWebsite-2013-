using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Entities.Mssql;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Audit;
using Roblox.Platform.Membership.Commands.Audit;
using Roblox.Platform.Membership.Commands.Properties;
using Roblox.Platform.Membership.Entities;
using Roblox.Platform.Membership.Properties;
using Roblox.TextFilter.Client;
using Roblox.Users.Client;

namespace Roblox.Platform.Membership.Commands;

/// <inheritdoc cref="T:Roblox.Platform.Membership.Commands.IUserSetter" />
public class UserSetter : IUserSetter
{
	private readonly IUser _RobloxUser;

	private readonly MembershipCommandsDomainFactories _DomainFactories;

	private readonly ILogger _Logger;

	private readonly Roblox.Platform.Membership.Commands.Properties.ISettings _Settings;

	private readonly IBirthdateChangeValidator _BirthdateChangeValidator;

	private readonly IAgeChecker _AgeChecker;

	private readonly IAccountNameHistoryEntityFactory _AccountNameHistoryEntityFactory;

	private readonly IUsersClient _UsersClient;

	private readonly IUsernameValidator _UsernameValidator;

	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private bool IsUsersTableAuditingEnabled => Roblox.Platform.Membership.Properties.Settings.Default.IsUsersTableAuditingEnabled;

	public UserSetter(MembershipCommandsDomainFactories factories, IUsernameValidator usernameValidator, IAccountNameHistoryEntityFactory accountNameHistoryEntityFactory, IUsersClient usersClient, ITextFilterClientV2 textFilterClientV2)
	{
		_UsernameValidator = usernameValidator ?? throw new ArgumentNullException("usernameValidator");
		_AccountNameHistoryEntityFactory = accountNameHistoryEntityFactory ?? throw new ArgumentNullException("accountNameHistoryEntityFactory");
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
		_DomainFactories = factories ?? throw new ArgumentNullException("factories");
		_TextFilterClientV2 = textFilterClientV2 ?? throw new ArgumentNullException("textFilterClientV2");
		_Logger = factories.Logger;
		_Settings = factories.Settings;
		_BirthdateChangeValidator = factories.BirthdateChangeValidator;
		_AgeChecker = factories.AgeChecker;
		_RobloxUser = factories.UserFactory.GetRobloxSystemUser();
	}

	private DataUpdateResult<IUser, IUsersAuditEntryEntity> CreateUsersAuditEntry(IUserEntity uEntity)
	{
		IUser user = _DomainFactories.UserFactory.GetUser(uEntity.ID);
		IUsersAuditEntryEntity auditEntryEntity = (IsUsersTableAuditingEnabled ? _DomainFactories.UsersAuditEntryEntityFactory.CreateNew(uEntity) : null);
		return new DataUpdateResult<IUser, IUsersAuditEntryEntity>(user, auditEntryEntity);
	}

	private void OnPreChange(IUser user)
	{
		try
		{
			BackfillUnauditedPastData(user);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	private void OnBirthdateChanged(IUsersAuditEntryEntity auditEntryEntity, IUser targetUser, IUser actorUser)
	{
		if (auditEntryEntity == null)
		{
			return;
		}
		try
		{
			_DomainFactories.UsersAuditEntriesMetaDataEntityFactory.CreateNew(targetUser, auditEntryEntity.PublicId, UsersAuditEntryMetaDataType.BirthDateSetOrChange, actorUser.Id);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	private void OnGenderTypeChanged(IUsersAuditEntryEntity auditEntryEntity, IUser targetUser, IUser actorUser)
	{
		if (auditEntryEntity == null)
		{
			return;
		}
		try
		{
			_DomainFactories.UsersAuditEntriesMetaDataEntityFactory.CreateNew(targetUser, auditEntryEntity.PublicId, UsersAuditEntryMetaDataType.GenderSetOrChange, actorUser.Id);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	private void CreateAccountAuditLog(IUser targetUser, IAccountEntity accountEntity, AccountsAuditChangeType changeType, IUser actor)
	{
		IAccountsAuditEntryEntity entry = _DomainFactories.AccountsAuditEntryEntityFactory.Create(accountEntity);
		_DomainFactories.AccountsAuditMetadataEntityFactory.Create(targetUser, entry.PublicId, changeType, actor?.Id);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.SetBirthdate(System.DateTime,Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser,System.Boolean)" />
	public void SetBirthdate(DateTime newBirthdate, IUser targetUser, IUser actorUser, bool checkAge = true)
	{
		_ = targetUser.AgeBracket;
		OnPreChange(targetUser);
		IUserEntity uEntity = _DomainFactories.UserEntityFactory.GetUser(targetUser.Id);
		if (!targetUser.Birthdate.HasValue || !targetUser.Birthdate.Equals(newBirthdate))
		{
			_BirthdateChangeValidator.ValidateBirthdateChange(targetUser, _DomainFactories.Now(), newBirthdate, checkAge);
			uEntity.SetBirthdate(newBirthdate);
			DataUpdateResult<IUser, IUsersAuditEntryEntity> result = CreateUsersAuditEntry(uEntity);
			IUser updatedUser = result.DataEntity;
			OnBirthdateChanged(result.AuditEntryEntity, updatedUser, actorUser);
		}
		else
		{
			if (uEntity.BirthDate.HasValue)
			{
				uEntity.SetBirthdate(uEntity.BirthDate.Value);
			}
			IUser updatedUser = CreateUsersAuditEntry(uEntity).DataEntity;
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.SetAgeBracket(Roblox.Platform.Membership.AgeBracket,Roblox.Platform.Membership.IUser)" />
	public void SetAgeBracket(AgeBracket ageBracket, IUser targetUser)
	{
		_ = targetUser.AgeBracket;
		OnPreChange(targetUser);
		if (targetUser.Birthdate.HasValue)
		{
			throw new ExplicitAgeBracketWithBirthdateException(targetUser.Birthdate.Value);
		}
		IUserEntity uEntity = _DomainFactories.UserEntityFactory.GetUser(targetUser.Id);
		uEntity.SetAgeBracket(ageBracket);
		_ = CreateUsersAuditEntry(uEntity).DataEntity;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.SetGenderType(Roblox.Platform.Membership.GenderType,Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser)" />
	public void SetGenderType(GenderType genderType, IUser targetUser, IUser actorUser)
	{
		OnPreChange(targetUser);
		if (genderType != targetUser.GenderType)
		{
			IUserEntity uEntity = _DomainFactories.UserEntityFactory.GetUser(targetUser.Id);
			uEntity.SetGender(genderType);
			DataUpdateResult<IUser, IUsersAuditEntryEntity> result = CreateUsersAuditEntry(uEntity);
			OnGenderTypeChanged(result.AuditEntryEntity, result.DataEntity, actorUser);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.SetBirthdateAndGenderType(System.DateTime,Roblox.Platform.Membership.GenderType,Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser)" />
	public void SetBirthdateAndGenderType(DateTime newBirthdate, GenderType genderType, IUser targetUser, IUser actorUser)
	{
		_ = targetUser.AgeBracket;
		OnPreChange(targetUser);
		IUserEntity uEntity = _DomainFactories.UserEntityFactory.GetUser(targetUser.Id);
		bool isBirthdateChange = false;
		bool isGenderChange = false;
		if (!targetUser.Birthdate.HasValue || !targetUser.Birthdate.Equals(newBirthdate))
		{
			_BirthdateChangeValidator.ValidateBirthdateChange(targetUser, _DomainFactories.Now(), newBirthdate, checkAge: true);
			uEntity.SetBirthdate(newBirthdate);
			isBirthdateChange = true;
		}
		if (genderType != targetUser.GenderType)
		{
			uEntity.SetGender(genderType);
			isGenderChange = true;
		}
		if (!isBirthdateChange && !isGenderChange)
		{
			return;
		}
		DataUpdateResult<IUser, IUsersAuditEntryEntity> result = CreateUsersAuditEntry(uEntity);
		if (result.AuditEntryEntity != null)
		{
			if (isBirthdateChange)
			{
				OnBirthdateChanged(result.AuditEntryEntity, result.DataEntity, actorUser);
			}
			if (isGenderChange)
			{
				OnGenderTypeChanged(result.AuditEntryEntity, result.DataEntity, actorUser);
			}
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.SetAgeBracketAndGenderTypeForNewUser(Roblox.Platform.Membership.AgeBracket,Roblox.Platform.Membership.GenderType,Roblox.Platform.Membership.IUser)" />
	public void SetAgeBracketAndGenderTypeForNewUser(AgeBracket ageBracket, GenderType genderType, IUser user)
	{
		_ = user.AgeBracket;
		OnPreChange(user);
		if (user.Birthdate.HasValue)
		{
			throw new ExplicitAgeBracketWithBirthdateException(user.Birthdate.Value);
		}
		IUserEntity uEntity = _DomainFactories.UserEntityFactory.GetUser(user.Id);
		uEntity.SetAgeBracket(ageBracket);
		uEntity.SetGender(genderType);
		DataUpdateResult<IUser, IUsersAuditEntryEntity> result = CreateUsersAuditEntry(uEntity);
		OnGenderTypeChanged(result.AuditEntryEntity, result.DataEntity, result.DataEntity);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.SetDescription(System.String,Roblox.Platform.Membership.IUser)" />
	public void SetDescription(string description, IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		string newDescription = ((!string.IsNullOrWhiteSpace(description)) ? (_TextFilterClientV2.FilterText(description, (IClientTextAuthor)new TextAuthor
		{
			Id = user.Id,
			Name = user.Name,
			IsUnder13 = user.IsUnder13()
		}, TextFilterUsage.UserDescription, user.Id.ToString(), false) ?? throw new PlatformOperationUnavailableException("TextFilterClientV2 returned a null response.")).FilteredText.TruncateToNVarChar(_Settings.MaxUserDescriptionLength) : string.Empty);
		_UsersClient.SetUserDescription(user.Id, newDescription);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.BackfillUnauditedPastData(Roblox.Platform.Membership.IUser)" />
	public void BackfillUnauditedPastData(IUser user)
	{
		if (!Roblox.Platform.Membership.Properties.Settings.Default.IsUsersTableAuditingEnabled)
		{
			return;
		}
		try
		{
			bool unauditedBirthdate = false;
			bool unauditedGender = false;
			if (user.Birthdate.HasValue)
			{
				ICollection<IUsersAuditCompositeEntry> birthdateHistory = _DomainFactories.UsersAuditCompositeEntryFactory.GetBirthdateHistory(user.Id, 1, 0L);
				if (!birthdateHistory.Any() || birthdateHistory.First().Audit_Birthdate != user.Birthdate.Value)
				{
					unauditedBirthdate = true;
				}
			}
			if (user.GenderType != GenderType.Unknown)
			{
				ICollection<IUsersAuditCompositeEntry> genderHistory = _DomainFactories.UsersAuditCompositeEntryFactory.GetGenderHistory(user.Id, 1, 0L);
				if (!genderHistory.Any() || genderHistory.First().Audit_GenderType != user.GenderType)
				{
					unauditedGender = true;
				}
			}
			if (unauditedBirthdate || unauditedGender)
			{
				IUserEntity uEntity = _DomainFactories.UserEntityFactory.GetUser(user.Id);
				IUsersAuditEntryEntity auditEntryEntity = _DomainFactories.UsersAuditEntryEntityFactory.CreateNew(uEntity);
				if (unauditedBirthdate)
				{
					_DomainFactories.UsersAuditEntriesMetaDataEntityFactory.CreateLegacyEntry(user, auditEntryEntity.PublicId, UsersAuditEntryMetaDataType.BirthDateSetOrChange, 0L);
				}
				if (unauditedGender)
				{
					_DomainFactories.UsersAuditEntriesMetaDataEntityFactory.CreateLegacyEntry(user, auditEntryEntity.PublicId, UsersAuditEntryMetaDataType.GenderSetOrChange, 0L);
				}
			}
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Membership.Commands.IUserSetter.SetName(Roblox.Platform.Membership.IUser,System.String,Roblox.Platform.Membership.IUser)" />
	public IChangeUserResult<UsernameValidatorResultCode> SetName(IUser user, string newName, IUser actor)
	{
		UsernameValidatorResultCode validationResult = ValidateSetName(user, actor, newName);
		if (validationResult != 0)
		{
			return new ChangeUserResult<UsernameValidatorResultCode>(user, validationResult);
		}
		IAccountEntity accountEntity = _DomainFactories.AccountEntityFactory.GetAccount(user.AccountId);
		if (accountEntity == null)
		{
			throw new InvalidOperationException($"Attempted name change on account with invalid id: {user.AccountId}");
		}
		_UsersClient.ChangeUsername(user.Id, user.Name, newName, recordHistory: true);
		accountEntity.InvalidateCacheOnUsernameChange(newName);
		CreateAccountAuditLog(user, accountEntity, AccountsAuditChangeType.Name, actor);
		return new ChangeUserResult<UsernameValidatorResultCode>(_DomainFactories.UserFactory.GetUser(user.Id), UsernameValidatorResultCode.UserNameValid);
	}

	private UsernameValidatorResultCode ValidateSetName(IUser user, IUser actor, string newName)
	{
		if (user == null || actor == null)
		{
			throw new ArgumentNullException("user");
		}
		if (actor.Id == _RobloxUser.Id)
		{
			if (!_UsernameValidator.IsUsernameAvailable(newName, user))
			{
				return UsernameValidatorResultCode.UserNameAlreadyInUseErrorCode;
			}
			return UsernameValidatorResultCode.UserNameValid;
		}
		IUsernameValidationResult response = _UsernameValidator.ValidateUsername(newName, user, mustUsePiiFiltersForU13Usernames: true);
		return (!response.IsValid) ? response.ResultCode : UsernameValidatorResultCode.UserNameValid;
	}

	public IChangeUserResult<AccountStatusChangeResponseCode> SetAccountStatus(IUser user, AccountStatus newStatus, IUser actor)
	{
		if (user == null)
		{
			return new ChangeUserResult<AccountStatusChangeResponseCode>(user, AccountStatusChangeResponseCode.InvalidUser);
		}
		if (actor == null)
		{
			return new ChangeUserResult<AccountStatusChangeResponseCode>(user, AccountStatusChangeResponseCode.InvalidActor);
		}
		IAccountEntity accountEntity = _DomainFactories.AccountEntityFactory.GetAccount(user.AccountId);
		if (accountEntity == null)
		{
			_Logger.Error(new InvalidOperationException($"Attempted status change on account with invalid id: {user.AccountId}"));
			return new ChangeUserResult<AccountStatusChangeResponseCode>(user, AccountStatusChangeResponseCode.Unknown);
		}
		accountEntity.SetAccountStatus(user, newStatus);
		CreateAccountAuditLog(user, accountEntity, AccountsAuditChangeType.Status, actor);
		return new ChangeUserResult<AccountStatusChangeResponseCode>(_DomainFactories.UserFactory.GetUser(user.Id), AccountStatusChangeResponseCode.Ok);
	}
}
