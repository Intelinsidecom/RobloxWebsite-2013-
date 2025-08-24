using System.Collections.Generic;
using Roblox.Platform.Groups.Implementation;

namespace Roblox.Platform.Groups;

public interface IGroupFactory
{
	/// <param name="groupId">The groupId</param>
	/// <param name="invalidIdThrows">If true, the method throws <see cref="T:Roblox.Platform.Groups.UnknownGroupException" /> when the <paramref name="groupId" /> is less than or equal to zero</param>
	/// <param name="shouldReturnLockedGroups">If false, the method returns null when looking up a locked group.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Groups.IGroup" /> if a group exists with the given groupId</returns>
	/// <exception cref="T:Roblox.Platform.Groups.UnknownGroupException">Thrown when the <paramref name="invalidIdThrows" /> is true and <paramref name="groupId" /> is less than or equal to zero.</exception>
	IGroup GetById(long groupId, bool invalidIdThrows = true, bool shouldReturnLockedGroups = true);

	IGroup CheckedGetById(long groupId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Groups.IGroup" /> by it's name.
	/// </summary>
	/// <param name="name">The name of the group.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Groups.IGroup" /> (or <c>null</c> if it does not exist.)</returns>
	IGroup GetByName(string name);

	IEnumerable<IGroup> GetRelatedGroups(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType, int startRow, int maxRows);

	int GetTotalRelatedGroups(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType);

	IEnumerable<IGroup> GetGroupRelationshipRequests(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType, int startRow, int maxRows);

	int GetTotalGroupRelationshipRequests(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType);
}
