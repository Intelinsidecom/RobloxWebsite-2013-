using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

/// <summary>
/// This is a platform interface for GroupRoleSets.
/// </summary>
public interface IGroupRoleSet
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	long Id { get; }

	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	/// <value>
	/// The name.
	/// </value>
	string Name { get; set; }

	/// <summary>
	/// Gets or sets the description.
	/// </summary>
	/// <value>
	/// The description.
	/// </value>
	string Description { get; set; }

	/// <summary>
	/// Gets or sets the rank.
	/// </summary>
	/// <value>
	/// The rank.
	/// </value>
	byte Rank { get; set; }

	/// <summary>
	/// Gets the group identifier.
	/// </summary>
	/// <value>
	/// The group identifier.
	/// </value>
	long GroupId { get; }

	/// <summary>
	/// Determines whether the current rank is guest rank.
	/// </summary>
	/// <returns>[True] if the rank is a guest rank, [False] otherwise.</returns>
	bool IsGuest();

	/// <summary>
	/// Determines whether the current rank is owner rank.
	/// </summary>
	/// <returns>[True] if the rank is a owner rank, [False] otherwise.</returns>
	bool IsOwner();

	/// <summary>
	/// Determines whether the roleset has specified permission.
	/// </summary>
	/// <param name="permission">The permission.</param>
	/// <returns>
	/// [True] if this <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /> has the passed in <paramref name="permission" />, [False] otherwise.
	/// </returns>
	bool HasPermission(GroupRoleSetPermissionType permission);

	/// <summary>
	/// Gets all group role set permissions by group role set.
	/// </summary>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:Roblox.Platform.Groups.GroupRoleSetPermissionType" /> for the <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />.
	/// </returns>
	IEnumerable<GroupRoleSetPermissionType> GetAllPermissionTypes();

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Membership.IUser" />s that are in this roleset.
	/// </summary>
	/// <returns><see cref="T:System.Collections.Generic.ICollection`1" /></returns>
	IPlatformPageResponse<long, IUser> GetUsersInRoleSet(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets the user ids that are in this roleset.
	/// </summary>
	/// <returns>Collection of user ids&gt;</returns>
	IPlatformPageResponse<long, long> GetUserIdsInRoleSet(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets total number of users in this roleset.
	/// </summary>
	/// <returns>integer number of users in this roleset</returns>
	int GetTotalNumberOfUsersInRoleSet();
}
