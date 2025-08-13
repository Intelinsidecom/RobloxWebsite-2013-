using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Entities;

[ExcludeFromCodeCoverage]
internal class AccountRoleSetEntity : IAccountRoleSetEntity, IEntity<int>
{
	private readonly AccountRoleSet _ServerClassLibraryEntity;

	public int Id => _ServerClassLibraryEntity.ID;

	public long AccountId => _ServerClassLibraryEntity.AccountID;

	public int RoleSetId => _ServerClassLibraryEntity.RoleSetID;

	public DateTime Created => _ServerClassLibraryEntity.Created;

	public DateTime Updated => _ServerClassLibraryEntity.Updated;

	public AccountRoleSetEntity(AccountRoleSet sclEntity)
	{
		_ServerClassLibraryEntity = sclEntity;
	}

	public void Delete()
	{
		_ServerClassLibraryEntity.Delete();
	}
}
