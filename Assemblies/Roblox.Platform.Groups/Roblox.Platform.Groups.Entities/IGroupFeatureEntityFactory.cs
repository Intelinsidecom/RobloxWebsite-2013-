namespace Roblox.Platform.Groups.Entities;

internal interface IGroupFeatureEntityFactory
{
	IGroupFeatureEntity GetGroupFeatureEntityByGroupIdAndFeatureTypeId(long groupId, byte groupFeatureTypeId);
}
