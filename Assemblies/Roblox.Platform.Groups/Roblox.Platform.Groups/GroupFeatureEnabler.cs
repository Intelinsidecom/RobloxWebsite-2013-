namespace Roblox.Platform.Groups;

internal class GroupFeatureEnabler : IGroupFeatureEnabler
{
	public void TurnOnFeature(IGroup group, IGroupMembership groupMembership, byte groupFeatureTypeId)
	{
		VerifyGroupFeaturePermissions(groupMembership, groupFeatureTypeId);
		if (GroupFeature.Get(group.Id, groupFeatureTypeId) == null)
		{
			GroupFeature.CreateNew(group.Id, groupFeatureTypeId);
		}
	}

	public void TurnOffFeature(IGroup group, IGroupMembership groupMembership, byte groupFeatureTypeId)
	{
		VerifyGroupFeaturePermissions(groupMembership, groupFeatureTypeId);
		GroupFeature.Get(group.Id, groupFeatureTypeId)?.Delete();
	}

	public void UpdateFeature(IGroupMembership groupMembership, byte groupFeatureTypeId, bool turnOn)
	{
		VerifyGroupFeaturePermissions(groupMembership, groupFeatureTypeId);
		GroupFeature feature = GroupFeature.Get(groupMembership.Group.Id, groupFeatureTypeId);
		if (turnOn)
		{
			if (feature == null)
			{
				GroupFeature.CreateNew(groupMembership.Group.Id, groupFeatureTypeId);
			}
		}
		else
		{
			feature?.Delete();
		}
	}

	public bool HasFeature(IGroup group, byte groupFeatureTypeId)
	{
		return GroupFeature.Get(group.Id, groupFeatureTypeId) != null;
	}

	private static void VerifyGroupFeaturePermissions(IGroupMembership groupMembership, byte groupFeatureTypeId)
	{
		if (groupMembership == null)
		{
			throw new UnknownGroupMembershipException();
		}
		if ((groupFeatureTypeId == GroupFeatureType.AllowEnemiesID && !groupMembership.HasPermission(GroupRoleSetPermissionType.CanManageRelationships)) || (groupFeatureTypeId == GroupFeatureType.ClanID && !groupMembership.HasPermission(GroupRoleSetPermissionType.CanManageClan)))
		{
			throw new InsufficientPermissionsException();
		}
		if (groupFeatureTypeId != GroupFeatureType.AllowEnemiesID && groupFeatureTypeId != GroupFeatureType.ClanID && !groupMembership.IsGroupOwner())
		{
			throw new InsufficientPermissionsException();
		}
	}
}
