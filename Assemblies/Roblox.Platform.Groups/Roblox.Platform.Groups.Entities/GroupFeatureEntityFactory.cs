using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class GroupFeatureEntityFactory : IGroupFeatureEntityFactory
{
	public IGroupFeatureEntity GetGroupFeatureEntityByGroupIdAndFeatureTypeId(long groupId, byte groupFeatureTypeId)
	{
		GroupFeature dbOject = GroupFeature.Get(groupId, groupFeatureTypeId);
		if (dbOject != null)
		{
			return new GroupFeatureEntity(dbOject);
		}
		return null;
	}
}
