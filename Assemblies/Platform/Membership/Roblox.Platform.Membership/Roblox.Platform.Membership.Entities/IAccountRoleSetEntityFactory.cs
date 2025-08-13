using System.Collections.Generic;

namespace Roblox.Platform.Membership.Entities;

internal interface IAccountRoleSetEntityFactory
{
	IAccountRoleSetEntity GetByAccountIDAndRoleSetId(long accountId, int roleSetId);

	ICollection<IAccountRoleSetEntity> GetAccountRoleSetsByAccountId(long accountId, int maximumRows);

	ICollection<IAccountRoleSetEntity> GetAccountRoleSetsByAccountIdPaged(long accountId, int startRowIndex, int maximumRows);

	ICollection<IAccountRoleSetEntity> GetAllAccountRoleSetsByRoleSetId(int roleSetId, int maximumTotalRows);
}
