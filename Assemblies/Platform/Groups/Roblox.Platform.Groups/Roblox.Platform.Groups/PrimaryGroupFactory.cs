using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Groups;

public class PrimaryGroupFactory : IPrimaryGroupFactory
{
	private readonly GroupDomainFactories _DomainFactories;

	public PrimaryGroupFactory(GroupDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public virtual IGroup GetPrimaryGroupByUser(IUserIdentifier user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		Roblox.Group oldGroupEntity = GroupManagement.GetPrimaryGroup(user.Id);
		if (oldGroupEntity == null)
		{
			return null;
		}
		IGroupFeatureEntity clanFeature = _DomainFactories.GroupFeatureEntityFactory.GetGroupFeatureEntityByGroupIdAndFeatureTypeId(oldGroupEntity.ID, GroupFeatureType.ClanID);
		return new Group(new GroupEntity(oldGroupEntity), clanFeature != null, _DomainFactories);
	}
}
