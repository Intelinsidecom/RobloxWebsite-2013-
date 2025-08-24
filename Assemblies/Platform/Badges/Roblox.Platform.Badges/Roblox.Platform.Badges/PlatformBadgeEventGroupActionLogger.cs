using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Groups;
using Roblox.Platform.Groups.Audits;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IPlatformBadgeEventGroupActionLogger" />
public class PlatformBadgeEventGroupActionLogger : IPlatformBadgeEventGroupActionLogger
{
	private readonly ILogger _Logger;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly Func<IUser> _AuthenticatedUserGetter;

	/// <summary>
	///
	/// </summary>
	/// <param name="authenticatedUserGetter"></param>
	/// <param name="placeFactory"></param>
	/// <param name="logger"></param>
	public PlatformBadgeEventGroupActionLogger(Func<IUser> authenticatedUserGetter, IPlaceFactory placeFactory, ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		_AuthenticatedUserGetter = authenticatedUserGetter ?? throw new ArgumentNullException("authenticatedUserGetter");
	}

	/// <inheritdoc />
	public void OnBadgeUpdated(Badge badge, BadgeUpdateType badgeUpdateType)
	{
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		try
		{
			if (badgeUpdateType == BadgeUpdateType.SetEnabled && TryGetGroupOwnerIdForBadge(badge, out var groupId))
			{
				OnBadgeIsEnabledUpdated(badge, groupId);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	/// <inheritdoc />
	public void OnBadgeCreated(Badge badge)
	{
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		try
		{
			if (TryGetGroupOwnerIdForBadge(badge, out var groupId))
			{
				OnBadgeCreated(badge, groupId);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual void OnBadgeCreated(Badge badge, long groupId)
	{
		IUser obj = _AuthenticatedUserGetter() ?? throw new Exception($"PlatformBadgeEventGroupActionLogger cannot obtain authenticated user on BadgeCreated. Badge ID: {badge.Id}");
		GroupManagement.LogGroupAction(json: new GroupBadgeAudit
		{
			BadgeId = badge.Id
		}, userId: obj.Id, groupId: groupId, actionTypeId: GroupActionType.CreateBadge.ID);
	}

	[ExcludeFromCodeCoverage]
	internal virtual void OnBadgeIsEnabledUpdated(Badge badge, long groupId)
	{
		IUser obj = _AuthenticatedUserGetter() ?? throw new Exception($"PlatformBadgeEventGroupActionLogger cannot obtain authenticated user on OnBadgeIsEnabledUpdated. Badge ID: {badge.Id}");
		GroupManagement.LogGroupAction(json: new GroupBadgeAudit
		{
			BadgeId = badge.Id,
			Type = ((!badge.IsEnabled) ? GroupBadgeAuditType.DisabledBadge : GroupBadgeAuditType.EnabledBadge)
		}, userId: obj.Id, groupId: groupId, actionTypeId: GroupActionType.ConfigureBadge.ID);
	}

	[ExcludeFromCodeCoverage]
	internal virtual bool TryGetGroupOwnerIdForBadge(Badge badge, out long groupId)
	{
		groupId = 0L;
		if (badge.Awarder.Type != BadgeAwarderType.Place)
		{
			throw new ArgumentException($"Unsupported awarder type. Awarder Type: {badge.Awarder.Type}.", string.Format("{0}.{1}", "badge", "Awarder"));
		}
		IPlace place = _PlaceFactory.Get(badge.Awarder.Id);
		if (place.CreatorType != Roblox.Platform.Assets.CreatorType.Group)
		{
			return false;
		}
		groupId = place.CreatorTargetId;
		return true;
	}
}
