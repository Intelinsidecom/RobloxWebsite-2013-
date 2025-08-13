using System;
using System.IO;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

internal class IsInClanPermissionTest : UserPermissionTest
{
	private readonly IUserFactory _UserFactory;

	internal GroupDomainFactories GroupDomainFactories { get; private set; }

	internal IsInClanPermissionTest(long? authenticatedUserId, long? targetId, GroupDomainFactories groupDomainFactories, IUserFactory userFactory)
		: base(authenticatedUserId, targetId)
	{
		GroupDomainFactories = groupDomainFactories;
		base.PermissionType = PermissionType.IsInClan;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public override bool Test()
	{
		if (!base.AuthenticatedUserId.HasValue)
		{
			base.PermissionType = PermissionType.UserIsAuthenticated;
			return false;
		}
		if (!base.PermissionTargetId.HasValue)
		{
			return false;
		}
		if (base.PermissionTargetId.Value < int.MinValue || base.PermissionTargetId.Value > int.MaxValue)
		{
			throw new InvalidDataException($"Target ID '{base.PermissionTargetId.Value}' is outside valid range of int32");
		}
		IUser iuser = _UserFactory.GetUser(base.AuthenticatedUserId.Value);
		if (iuser == null)
		{
			return false;
		}
		IGroup clan = iuser.GetClan(GroupDomainFactories);
		if (clan == null)
		{
			return false;
		}
		return base.PermissionTargetId.Value == clan.Id;
	}
}
