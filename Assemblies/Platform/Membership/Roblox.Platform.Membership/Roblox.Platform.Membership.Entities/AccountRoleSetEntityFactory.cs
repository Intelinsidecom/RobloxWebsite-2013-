using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Roblox.Platform.Membership.Entities;

[ExcludeFromCodeCoverage]
internal class AccountRoleSetEntityFactory : IAccountRoleSetEntityFactory
{
	public IAccountRoleSetEntity GetByAccountIDAndRoleSetId(long accountId, int roleSetId)
	{
		return new AccountRoleSetEntity(AccountRoleSet.GetByAccountIDAndRoleSetID(accountId, roleSetId));
	}

	public ICollection<IAccountRoleSetEntity> GetAccountRoleSetsByAccountId(long accountId, int maximumRows)
	{
		return ConvertSCLToEntity(AccountRoleSet.GetAccountRoleSetsByAccountIDPaged(accountId, 0, maximumRows)).ToList();
	}

	public ICollection<IAccountRoleSetEntity> GetAccountRoleSetsByAccountIdPaged(long accountId, int startRowIndex, int maximumRows)
	{
		return ConvertSCLToEntity(AccountRoleSet.GetAccountRoleSetsByAccountIDPaged(accountId, startRowIndex, maximumRows)).ToList();
	}

	public ICollection<IAccountRoleSetEntity> GetAllAccountRoleSetsByRoleSetId(int roleSetId, int maximumTotalRows)
	{
		return ConvertSCLToEntity(AccountRoleSet.GetAllAccountRoleSetsByRoleSetID(roleSetId, maximumTotalRows)).ToList();
	}

	private IEnumerable<IAccountRoleSetEntity> ConvertSCLToEntity(IEnumerable<AccountRoleSet> rolesets)
	{
		return rolesets.Select((AccountRoleSet roleset) => new AccountRoleSetEntity(roleset));
	}
}
