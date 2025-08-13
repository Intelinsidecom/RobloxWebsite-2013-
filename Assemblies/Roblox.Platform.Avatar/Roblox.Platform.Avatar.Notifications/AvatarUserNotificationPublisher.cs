using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Outfits;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Avatar.Notifications;

public class AvatarUserNotificationPublisher
{
	private readonly UserNotificationPublisher<AssetOwnershipNotificationMessage> _PublisherForAssetOwnership;

	private readonly UserNotificationPublisher<OutfitOwnershipNotificationMessage> _PublisherForCostumeOwnership;

	public AvatarUserNotificationPublisher(ILogger logger)
	{
		_PublisherForAssetOwnership = new UserNotificationPublisher<AssetOwnershipNotificationMessage>(logger, "AvatarAssetOwnershipNotifications");
		_PublisherForCostumeOwnership = new UserNotificationPublisher<OutfitOwnershipNotificationMessage>(logger, "AvatarOutfitOwnershipNotifications");
	}

	public void PublishAssetOwnershipChangeNotification(long userId, Roblox.Platform.Assets.IAsset asset, AvatarOwnershipNotificationType avatarOwnershipNotificationType)
	{
		AssetOwnershipNotificationMessage notification = new AssetOwnershipNotificationMessage
		{
			AssetId = asset.Id,
			AssetTypeId = asset.TypeId,
			Type = avatarOwnershipNotificationType.ToString()
		};
		_PublisherForAssetOwnership.Publish(userId, notification);
	}

	public void PublishOutfitOwnershipChangeNotification(long userId, IUserOutfit userOutfit, AvatarOwnershipNotificationType avatarOwnershipNotificationType)
	{
		OutfitOwnershipNotificationMessage notification = new OutfitOwnershipNotificationMessage
		{
			UserOutfitId = userOutfit.Id,
			Type = avatarOwnershipNotificationType.ToString()
		};
		_PublisherForCostumeOwnership.Publish(userId, notification);
	}
}
