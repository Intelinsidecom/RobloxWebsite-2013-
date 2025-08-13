using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <summary>
/// interface for class that performs write operations on <see cref="T:Roblox.Platform.Groups.GroupRoleSet" /> objects
/// </summary>
public interface IGroupRoleSetWriter
{
	/// <summary>
	/// Updates the name and description for <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />.
	/// </summary>
	/// <param name="name">The name.</param>
	/// <param name="description">The description.</param>
	/// <param name="author">The author.</param>
	/// <param name="groupRoleSet">The <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the <paramref name="name" /> is null or whitespace.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="author" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Groups.PlatformGroupTextFullyModeratedException">Thrown if the groupRoleSet cannot be updated with passed in <paramref name="name" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the text filtering service is unavailable.</exception>
	void UpdateNameAndDescription(IGroupRoleSet groupRoleSet, string name, string description, ITextAuthor author);

	/// <summary>
	/// Updates the rank for the <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />.
	/// </summary>
	/// <param name="groupRoleSet">The <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /></param>
	/// <param name="rank">The rank.</param>
	void UpdateRank(IGroupRoleSet groupRoleSet, byte rank);

	/// <summary>
	/// Updates a permission for the <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />.
	/// </summary>
	/// <param name="groupRoleSet">The <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /></param>
	/// <param name="permission">The permission type</param>
	/// <param name="createPermission">Do we create or delete a permission</param>
	void UpdatePermission(IGroupRoleSet groupRoleSet, GroupRoleSetPermissionType permission, bool createPermission);

	/// <summary>
	/// Deletes this instance.
	/// </summary>
	/// <param name="groupRoleSet">The <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" /></param>
	void Delete(IGroupRoleSet groupRoleSet);
}
