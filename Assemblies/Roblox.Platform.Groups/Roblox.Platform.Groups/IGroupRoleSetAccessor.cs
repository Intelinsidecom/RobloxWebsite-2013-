using System.Collections.Generic;

namespace Roblox.Platform.Groups;

/// <summary>
/// A public interface for accessing GroupRoleSets.
/// </summary>
public interface IGroupRoleSetAccessor
{
	/// <summary>
	/// Gets the maximum length of the roleset name.
	/// </summary>
	/// <value>
	/// The maximum length of the roleset name.
	/// </value>
	int RolesetNameMaxLength { get; }

	/// <summary>
	/// Gets the maximum length of the roleset description.
	/// </summary>
	/// <value>
	/// The maximum length of the roleset description.
	/// </value>
	int RolesetDescriptionMaxLength { get; }

	/// <summary>
	/// Gets the maximum number of the roleset rank.
	/// </summary>
	byte RolesetMaxRank { get; }

	/// <summary>
	/// Gets the minimum number of the roleset rank.
	/// </summary>
	byte RolesetMinRank { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /> by identifier.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="invalidIdThrows">If true, the method throws <see cref="T:Roblox.Platform.Core.PlatformArgumentException" /> when the <paramref name="id" /> is less than or equal to zero</param>
	/// <returns>A <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /> if found, null otherwise.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="id" /> is a non-positive integer.</exception>
	IGroupRoleSet GetById(long id, bool invalidIdThrows = true);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />s for the group.
	/// </summary>
	/// <param name="group">The <see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /> for the passed in group.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="group" /> is null.</exception>
	IEnumerable<IGroupRoleSet> GetAllForGroup(IGroup group);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />s for the given group ID.
	/// </summary>
	/// <param name="groupId">The ID of the group the roleset is a part of.</param>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /> for the passed in group ID.
	/// </returns>
	IEnumerable<IGroupRoleSet> GetAllByGroupId(long groupId);
}
