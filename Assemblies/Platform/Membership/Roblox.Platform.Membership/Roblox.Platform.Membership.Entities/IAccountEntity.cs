using System;
using System.Collections.Generic;

namespace Roblox.Platform.Membership.Entities;

public interface IAccountEntity
{
	long Id { get; }

	string Name { get; }

	AccountStatus AccountStatus { get; }

	string Description { get; }

	DateTime Updated { get; }

	DateTime Created { get; }

	void InvalidateCacheOnUsernameChange(string newUsername);

	void SetAccountStatus(IUser user, AccountStatus accountStatus);

	IReadOnlyCollection<int> GetRoleSetIds();

	bool IsInRole(IRoleSetEntity roleSet);

	IRoleSetEntity GetHighestRoleSetEntity();
}
