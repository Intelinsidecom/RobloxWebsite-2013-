using System.Collections.Generic;

namespace Roblox.Platform.Membership;

/// <summary>
/// Validate that the given user has the expected RoleSet.
/// </summary>
public interface IRoleSetValidator
{
	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the ProtectedUser role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsProtectedUser(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the Soothsayer role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsSoothsayer(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the BetaTester role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsBetaTester(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the Priveleged role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsPrivilegedUser(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the TrustedContributor role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsTrustedContributor(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the ContentCreator role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsContentCreator(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the DeveloperRelations role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsDeveloperRelations(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the CommunityManager role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsCommunityManager(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the CustomerService role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsCustomerService(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the CSAgentAdmin role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsCSAgentAdmin(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the FastTrackMember role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsFastTrackMember(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the FastTrackModerator role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsFastTrackModerator(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the FastTrackAdmin role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsFastTrackAdmin(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the ThumbnailAdmin role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsThumbnailAdmin(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the MatchmakingAdmin role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsMatchmakingAdmin(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the RccReleaseTester role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsRccReleaseTester(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the RccReleaseTesterManager role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsRccReleaseTesterManager(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the ChinaLicenseUser role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsChinaLicenseUser(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the ChinaBetaUser role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsChinaBetaUser(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the Influencer role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsInfluencer(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the DataAdministrator role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsDataAdministrator(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the AdOps role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsAdOps(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the CLBGameDeveloper role?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsCLBGameDeveloper(IUser user);

	/// <summary>
	/// Does the given <see cref="T:Roblox.Platform.Membership.IUser" /> have the sepecfied roleid?
	/// </summary>
	/// <param name="user">A non-null <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked.</param>
	/// <param name="roleSetId"></param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsInRole(IUser user, int roleSetId);

	/// <summary>
	/// Get all rolesets for user
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions we want to check.</param>
	/// <returns>The all <see cref="T:Roblox.Platform.Membership.IRoleset" /> assigned to user</returns>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Bad Account or missing Rolesets.</exception>
	ICollection<IRoleset> GetRoleSets(IUser user);

	/// <summary>
	/// Get all role set IDs for user
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose role sets we want to fetch.</param>
	/// <returns>All role set IDs for user</returns>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Bad Account or missing Rolesets.</exception>
	IReadOnlyCollection<int> GetRoleSetIds(IUser user);

	/// <summary>
	/// Load the Highest Rank Roleset currently assigned to the given user.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions we want to check.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.IRoleset" /> with the highest ranking.</returns>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Bad Account or missing Roleset.</exception>
	IRoleset GetHighestRoleSet(IUser user);

	/// <summary>
	/// Load the Highest Rank Roleset currently assigned to the given acciybt.
	/// </summary>
	/// <param name="accountId">The account id of whose permissions we want to check.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.IRoleset" /> with the highest ranking.</returns>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Bad Account or missing Roleset.</exception>
	IRoleset GetHighestRoleSetForAccountId(long accountId);
}
