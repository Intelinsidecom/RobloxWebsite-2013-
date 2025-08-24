using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Entities.GroupRoleSets;
using Roblox.Platform.Groups.Events;
using Roblox.Platform.Groups.Interfaces;
using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

/// <summary>
/// The <seealso cref="T:Roblox.Platform.Core.DomainFactoriesBase">DomainFactories</seealso> object for Roblox.Platform.Groups.
/// </summary>
[ExcludeFromCodeCoverage]
public class GroupDomainFactories : DomainFactoriesBase
{
	internal virtual IUserFactory UserFactory { get; }

	internal virtual IGroupRoleSetPermissionTypeConverter GroupRoleSetPermissionTypeConverter { get; }

	internal virtual IGroupRoleSetPermissionEntityFactory GroupRoleSetPermissionEntityFactory { get; }

	internal virtual IGroupRoleSetEntityFactory GroupRoleSetEntityFactory { get; }

	internal virtual IGroupRoleSetPermissionTypeEntityFactory GroupRoleSetPermissionTypeEntityFactory { get; }

	internal virtual IGroupEntityFactory GroupEntityFactory { get; }

	internal virtual IGroupFeatureEntityFactory GroupFeatureEntityFactory { get; }

	internal virtual IGroupRoleSetAccessorInternal GroupRoleSetAccessor_Internal { get; }

	internal virtual ClanInvitationFactory ClanInvitationFactory { get; }

	public virtual IGroupEventPublisher GroupEventPublisher { get; }

	public virtual IGroupFactory GroupFactory { get; }

	public virtual GroupMembershipFactory GroupMembershipFactory { get; }

	public virtual IGroupRoleSetAccessor GroupRoleSetAccessor => GroupRoleSetAccessor_Internal;

	public virtual ClanMemberFactory ClanMemberFactory { get; }

	public virtual ISettings Settings { get; }

	public virtual IGroupJoinRequestFactory GroupJoinRequestFactory { get; }

	public virtual IPrimaryGroupFactory PrimaryGroupFactory { get; }

	public virtual IGroupSettingsProvider GroupSettingsProvider { get; }

	public virtual IGroupFeatureEnabler GroupFeatureEnabler { get; }

	public GroupDomainFactories(IGroupEventPublisher groupEventPublisher, IUserFactory userFactory)
	{
		Settings = Roblox.Platform.Groups.Properties.Settings.Default;
		GroupEventPublisher = groupEventPublisher ?? throw new PlatformArgumentNullException("groupEventPublisher");
		UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		GroupEntityFactory = new GroupEntityFactory();
		GroupFeatureEntityFactory = new GroupFeatureEntityFactory();
		GroupRoleSetEntityFactory = new GroupRoleSetEntityFactory();
		GroupRoleSetPermissionEntityFactory = new GroupRoleSetPermissionEntityFactory();
		GroupJoinRequestFactory = new GroupJoinRequestFactory();
		GroupRoleSetPermissionTypeConverter = new GroupRoleSetPermissionTypeConverter(GroupRoleSetPermissionTypeEntityFactory = new GroupRoleSetPermissionTypeEntityFactory());
		GroupFactory = new GroupFactory(this);
		GroupMembershipFactory = new GroupMembershipFactory(this, userFactory);
		PrimaryGroupFactory = new PrimaryGroupFactory(this);
		GroupRoleSetAccessor_Internal = new GroupRoleSetAccessor(this);
		ClanInvitationFactory = new ClanInvitationFactory(this);
		ClanMemberFactory = new ClanMemberFactory(this, userFactory);
		GroupSettingsProvider = new GroupSettingsProvider(GroupFeatureEnabler = new GroupFeatureEnabler());
	}
}
