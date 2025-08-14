using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Users.Client;

namespace Roblox.Platform.Membership.Entities;

[ExcludeFromCodeCoverage]
public class AccountEntity : IAccountEntity
{
	private readonly Account _ServerClassLibraryEntity;

	private readonly IUsersClient _UsersClient;

	public long Id => _ServerClassLibraryEntity.ID;

	public string Name => _ServerClassLibraryEntity.Name;

	public AccountStatus AccountStatus
	{
		get
		{
			return AccountStatusExtensions.TranslateAccountStatus(_ServerClassLibraryEntity.AccountStatusID);
		}
		private set
		{
			_ServerClassLibraryEntity.AccountStatusID = value.GetId();
		}
	}

	public string Description => _ServerClassLibraryEntity.Description;

	public DateTime Created => _ServerClassLibraryEntity.Created;

	public DateTime Updated => _ServerClassLibraryEntity.Updated;

	public AccountEntity(Account sclEntity)
		: this(sclEntity, Roblox.User.UsersClient)
	{
	}

	public AccountEntity(Account sclEntity, IUsersClient usersClient)
	{
		_ServerClassLibraryEntity = sclEntity;
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
	}

	public void InvalidateCacheOnUsernameChange(string newUsername)
	{
		_ServerClassLibraryEntity.InvalidateCacheOnUsernameChange(newUsername);
	}

	public void SetAccountStatus(IUser user, AccountStatus accountStatus)
	{
		if (user?.AccountId != Id)
		{
			throw new ArgumentException($"User does not match account ({user?.AccountId} != {Id})", "user");
		}
		AccountStatus = accountStatus;
		_UsersClient.SetUserModerationStatus(user.Id, Roblox.User.TranslateAccountStatusId(_ServerClassLibraryEntity.AccountStatusID));
		CacheManager.ProcessEntityChange(_ServerClassLibraryEntity, StateChangeEventType.Modification);
	}

	public bool IsInRole(IRoleSetEntity roleSet)
	{
		return _ServerClassLibraryEntity.IsInRole(roleSet.Id);
	}

	public IReadOnlyCollection<int> GetRoleSetIds()
	{
		return _ServerClassLibraryEntity.GetRoleSetIds();
	}

	public IRoleSetEntity GetHighestRoleSetEntity()
	{
		return new RoleSetEntity(_ServerClassLibraryEntity.GetHighestRoleSet());
	}
}
