using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Entities;
using Roblox.Platform.Membership.Properties;

namespace Roblox.Platform.Membership;

internal class RoleSetValidator : IRoleSetValidator
{
	private readonly ISettings _Settings;

	private readonly IAccountRoleSetEntityFactory _AccountRoleSetEntityFactory;

	private readonly IAccountEntityFactory _AccountEntityFactory;

	private readonly IRoleSetEntityFactory _RoleSetEntityFactory;

	public RoleSetValidator(ISettings settings, IAccountEntityFactory accountEntityFactory, IRoleSetEntityFactory roleSetEntityFactory, IAccountRoleSetEntityFactory accountRoleSetEntityFactory)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_AccountEntityFactory = accountEntityFactory ?? throw new ArgumentNullException("accountEntityFactory");
		_RoleSetEntityFactory = roleSetEntityFactory ?? throw new ArgumentNullException("roleSetEntityFactory");
		_AccountRoleSetEntityFactory = accountRoleSetEntityFactory ?? throw new ArgumentNullException("accountRoleSetEntityFactory");
	}

	/// <summary>
	/// Basic helper to avoid lots of boilerplate code.
	/// </summary>
	/// <param name="user"></param>
	/// <param name="rolesetLoader"></param>
	/// <returns></returns>
	private bool CheckRole(IUser user, Func<IRoleSetEntity> rolesetLoader)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		long accountId = user.AccountId;
		IRoleSetEntity roleset = rolesetLoader();
		return _AccountEntityFactory.GetAccount(accountId).IsInRole(roleset);
	}

	public bool IsProtectedUser(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetProtectedUser());
	}

	public bool IsSoothsayer(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetSoothsayer());
	}

	/// <inheritdoc />
	public bool IsBetaTester(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetBetaTester());
	}

	public bool IsTrustedContributor(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetTrustedContributor());
	}

	public bool IsContentCreator(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetContentCreator());
	}

	/// <inheritdoc />
	public bool IsDeveloperRelations(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetDeveloperRelations());
	}

	public bool IsCommunityManager(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetCommunityManager());
	}

	public bool IsCustomerService(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetCustomerService());
	}

	public bool IsCSAgentAdmin(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetCSAgentAdmin());
	}

	public bool IsFastTrackMember(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetFastTrackMember());
	}

	public bool IsFastTrackModerator(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetFastTrackModerator());
	}

	public bool IsFastTrackAdmin(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetFastTrackAdmin());
	}

	public bool IsThumbnailAdmin(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetThumbnailAdmin());
	}

	public bool IsMatchmakingAdmin(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetMatchmakingAdmin());
	}

	public bool IsRccReleaseTester(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetRccReleaseTester());
	}

	public bool IsRccReleaseTesterManager(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetRccReleaseTesterManager());
	}

	public bool IsChinaLicenseUser(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetChinaLicenseUser());
	}

	public bool IsChinaBetaUser(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetChinaBetaUser());
	}

	public bool IsInfluencer(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetInfluencer());
	}

	public bool IsDataAdministrator(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetDataAdministrator());
	}

	public bool IsAdOps(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetAdOps());
	}

	public bool IsCLBGameDeveloper(IUser user)
	{
		return CheckRole(user, () => _RoleSetEntityFactory.GetCLBGameDeveloper());
	}

	public bool IsPrivilegedUser(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		long accountId = user.AccountId;
		return _AccountEntityFactory.MustGetAccount(accountId).GetHighestRoleSetEntity().Rank >= _Settings.PrivilegedUserRolesetRankThreshold;
	}

	public bool IsInRole(IUser user, int roleSetId)
	{
		return (from roleSet in GetRoleSets(user)
			select roleSet.Id).Contains(roleSetId);
	}

	public ICollection<IRoleset> GetRoleSets(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		long accountId = user.AccountId;
		if (_AccountEntityFactory.GetAccount(accountId) == null)
		{
			throw new PlatformDataIntegrityException($"Account {accountId} is not active");
		}
		return (from accountRoleSetEntity in _AccountRoleSetEntityFactory.GetAccountRoleSetsByAccountId(accountId, 1000)
			select new Roleset(new RoleSetEntity(RoleSet.Get(accountRoleSetEntity.RoleSetId)))).ToArray();
	}

	public IReadOnlyCollection<int> GetRoleSetIds(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		long accountId = user.AccountId;
		return _AccountEntityFactory.GetAccount(accountId).GetRoleSetIds();
	}

	public IRoleset GetHighestRoleSet(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		return GetHighestRoleSetForAccountId(user.AccountId);
	}

	public IRoleset GetHighestRoleSetForAccountId(long accountId)
	{
		return new Roleset((_AccountEntityFactory.GetAccount(accountId) ?? throw new PlatformDataIntegrityException($"Account {accountId} is not active")).GetHighestRoleSetEntity() ?? throw new PlatformDataIntegrityException($"Account {accountId} does not have any rolesets"));
	}
}
