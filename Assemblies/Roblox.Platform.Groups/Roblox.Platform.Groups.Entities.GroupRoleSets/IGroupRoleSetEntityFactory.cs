using System.Collections.Generic;

namespace Roblox.Platform.Groups.Entities.GroupRoleSets;

internal interface IGroupRoleSetEntityFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" /> by the identifier.
	/// ***This should never return null - it defaults to guest roleset.
	/// </summary>
	/// <param name="groupRoleSetId">The group role set identifier.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" /> if present, null otherwise.</returns>
	IGroupRoleSetEntity GetById(long groupRoleSetId);

	/// <summary>
	/// Fetches multiple group rolesets by their ids.
	/// </summary>
	/// <param name="groupRoleSetIds">The group roleset ids.</param>
	/// <returns>A collection of <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" /></returns>
	IReadOnlyCollection<IGroupRoleSetEntity> MultiGet(ICollection<long> groupRoleSetIds);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" />s by group identifier.
	/// </summary>
	/// <param name="groupId">The group identifier.</param>
	/// <returns>A collection of <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" />.</returns>
	IEnumerable<IGroupRoleSetEntity> GetAllByGroupId(long groupId);

	/// <summary> 
	/// Gets the by group identifier and user identifier.
	/// *** This should never return null - it defaults to guest roleset.
	/// </summary>
	/// <param name="groupId">The group identifier.</param>
	/// <param name="userId">The user identifier.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" /> if existing, null otherwise.</returns>
	IGroupRoleSetEntity GetByGroupIdAndUserId(long groupId, long? userId);

	/// <summary>
	/// Creates the a new <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" />.
	/// </summary>
	/// <param name="groupId">The group identifier.</param>
	/// <param name="name">The name.</param>
	/// <param name="description">The description.</param>
	/// <param name="rank">The rank.</param>
	/// <returns>The newly created <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" />.</returns>
	IGroupRoleSetEntity CreateNew(long groupId, string name, string description, byte rank);
}
