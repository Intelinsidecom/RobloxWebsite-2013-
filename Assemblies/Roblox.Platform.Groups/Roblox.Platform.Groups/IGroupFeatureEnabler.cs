namespace Roblox.Platform.Groups;

public interface IGroupFeatureEnabler
{
	void TurnOnFeature(IGroup group, IGroupMembership groupMembership, byte groupFeatureTypeId);

	void TurnOffFeature(IGroup group, IGroupMembership groupMembership, byte groupFeatureTypeId);

	void UpdateFeature(IGroupMembership groupMembership, byte groupFeatureTypeId, bool turnOn);

	bool HasFeature(IGroup group, byte groupFeatureTypeId);
}
