using System;
using Roblox.Badges.Client;
using Roblox.Platform.Badges.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Badges;

/// <inheritdoc />
public class BadgeUpdater : IBadgeUpdater
{
	private readonly IBadgeConverter _BadgeConverter;

	private readonly IBadgesClient _BadgesClient;

	private readonly IBadgeTextFilter _BadgeTextFilter;

	private readonly ISettings _Settings;

	/// <inheritdoc />
	public event Action<Badge, BadgeUpdateType> BadgeUpdated;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgeUpdater" />
	/// </summary>
	/// <param name="settings"></param>
	/// <param name="badgesClient"></param>
	/// <param name="badgeTextFilter"></param>
	public BadgeUpdater(ISettings settings, IBadgesClient badgesClient, IBadgeTextFilter badgeTextFilter)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_BadgesClient = badgesClient ?? throw new ArgumentNullException("badgesClient");
		_BadgeTextFilter = badgeTextFilter ?? throw new ArgumentNullException("badgeTextFilter");
		_BadgeConverter = new BadgeConverter();
	}

	/// <inheritdoc />
	public void SetNameAndDescription(Badge badge, IClientTextAuthor textAuthor, string newName, string newDescription, IUserIdentifier actorUserIdentity)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (textAuthor == null)
		{
			throw new ArgumentNullException("textAuthor");
		}
		if (!string.IsNullOrEmpty(newDescription) && newDescription.Length > _Settings.MaxBadgeDescriptionLength)
		{
			throw new LongDescriptionException($"The description is {newDescription.Length} characters long but the max is {_Settings.MaxBadgeDescriptionLength}.");
		}
		BadgeTextFilterResult badgeTextFilterResult = _BadgeTextFilter.FilterBadgeText(new BadgeTextFilterRequest
		{
			Description = newDescription,
			Name = newName,
			TextAuthor = textAuthor
		});
		Badge clientBadge = _BadgeConverter.ConvertToClientBadge(badge);
		clientBadge.Name = badgeTextFilterResult.Name;
		clientBadge.Description = badgeTextFilterResult.Description;
		UpdateBadgeResult updateBadgeResult = _BadgesClient.Update(clientBadge);
		if ((int)updateBadgeResult.OperationStatus == 0)
		{
			badge.Name = clientBadge.Name;
			badge.Description = clientBadge.Description;
			badge.Updated = updateBadgeResult.Updated.ToLocalTime();
			this.BadgeUpdated?.Invoke(badge, BadgeUpdateType.SetNameAndDescription);
			return;
		}
		throw new PlatformOperationUnavailableException($"Failed to set badge name and description via service. Operation Status: {updateBadgeResult.OperationStatus}");
	}

	/// <inheritdoc />
	public void SetImage(Badge badge, long imageId)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (imageId <= 0)
		{
			throw new ArgumentException("Has to be a positive number", "imageId");
		}
		Badge clientBadge = _BadgeConverter.ConvertToClientBadge(badge);
		clientBadge.ImageId = imageId;
		UpdateBadgeResult updateBadgeResult = _BadgesClient.Update(clientBadge);
		if ((int)updateBadgeResult.OperationStatus == 0)
		{
			badge.ImageId = clientBadge.ImageId;
			badge.Updated = updateBadgeResult.Updated.ToLocalTime();
			this.BadgeUpdated?.Invoke(badge, BadgeUpdateType.SetImage);
			return;
		}
		throw new PlatformOperationUnavailableException($"Failed to set badge image via service. Operation Status: {updateBadgeResult.OperationStatus}");
	}

	/// <summary>
	/// Enable/Disable badge.
	/// </summary>
	/// <param name="badge"><see cref="T:Roblox.Platform.Badges.Badge" /></param>
	/// <param name="isEnabled"></param>
	/// <exception cref="T:System.ArgumentNullException">
	/// badge
	/// </exception>
	/// <exception cref="T:System.ArgumentException"></exception>
	public void SetEnabled(Badge badge, bool isEnabled)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (badge.IsEnabled != isEnabled)
		{
			Badge clientBadge = _BadgeConverter.ConvertToClientBadge(badge);
			clientBadge.IsActive = isEnabled;
			UpdateBadgeResult updateBadgeResult = _BadgesClient.Update(clientBadge);
			if ((int)updateBadgeResult.OperationStatus != 0)
			{
				throw new PlatformOperationUnavailableException($"Failed to set badge Enabled via service. Operation Status: {updateBadgeResult.OperationStatus}");
			}
			badge.IsEnabled = isEnabled;
			badge.Updated = updateBadgeResult.Updated.ToLocalTime();
			this.BadgeUpdated?.Invoke(badge, BadgeUpdateType.SetEnabled);
		}
	}
}
