using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Avatar.Notifications;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Listens for events that add items to a user's recent avatar items list
/// </summary>
public class RecentAvatarItemListener : IRecentAvatarItemListener
{
	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly AvatarUserNotificationPublisher _AvatarUserNotificationPublisher;

	private IUserOutfitFactory UserOutfitFactory => _AvatarDomainFactories.OutfitDomainFactories.UserOutfitFactory;

	public RecentAvatarItemListener(AvatarDomainFactories avatarDomainFactories, ILogger logger)
	{
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		_AvatarDomainFactories = avatarDomainFactories;
		_AvatarUserNotificationPublisher = new AvatarUserNotificationPublisher(logger);
	}

	public void Unregister()
	{
		UserOutfitFactory.UnregisterUserOutfitCreatedEvent(OnUserOutfitCreated);
		UserOutfitFactory.UnregisterUserOutfitUpdatedEvent(OnUserOutfitUpdated);
		UserOutfitFactory.UnregisterUserOutfitDeletedEvent(OnUserOutfitDeleted);
		Avatar.AssetsChangedEvent -= OnAssetsChanged;
		Avatar.OutfitWornEvent -= OnOutfitWorn;
	}

	public void Register()
	{
		UserOutfitFactory.RegisterUserOutfitCreatedEvent(OnUserOutfitCreated);
		UserOutfitFactory.RegisterUserOutfitUpdatedEvent(OnUserOutfitUpdated);
		UserOutfitFactory.RegisterUserOutfitDeletedEvent(OnUserOutfitDeleted);
		Avatar.AssetsChangedEvent += OnAssetsChanged;
		Avatar.OutfitWornEvent += OnOutfitWorn;
	}

	private void ProcessAction(Action action)
	{
		if (Settings.Default.RecentAvatarItemsDisableListenerFromSpawningThreads)
		{
			try
			{
				action();
				return;
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException($"Failed to update recent items in same thread: {ex.Message}");
				return;
			}
		}
		RobloxThreadPool.QueueUserWorkItem(action);
	}

	private void OnAssetsChanged(IAvatar avatar, List<long> assetIdsBeingWorn, List<long> assetIdsBeingUnworn)
	{
		List<long> assetIdsToBumpToTop = assetIdsBeingWorn.Concat(assetIdsBeingUnworn).ToList();
		ProcessAction(delegate
		{
			_AvatarDomainFactories.RecentAvatarItemPublisher.AddAssets(avatar.UserId, assetIdsToBumpToTop);
		});
	}

	private void OnOutfitWorn(IAvatar avatar, IUserOutfit userOutfit)
	{
		ProcessAction(delegate
		{
			_AvatarDomainFactories.RecentAvatarItemPublisher.AddUserOutfits(userOutfit.UserId, new List<IUserOutfit> { userOutfit });
		});
	}

	private void OnUserOutfitCreated(IUserOutfit userOutfit)
	{
		ProcessAction(delegate
		{
			_AvatarDomainFactories.RecentAvatarItemPublisher.AddUserOutfits(userOutfit.UserId, new List<IUserOutfit> { userOutfit });
		});
		TryPublishOutfitOwnershipChangeNotification(userOutfit.UserId, userOutfit, AvatarOwnershipNotificationType.Grant);
	}

	private void OnUserOutfitUpdated(IUserOutfit userOutfit)
	{
		ProcessAction(delegate
		{
			_AvatarDomainFactories.RecentAvatarItemPublisher.AddUserOutfits(userOutfit.UserId, new List<IUserOutfit> { userOutfit });
		});
		TryPublishOutfitOwnershipChangeNotification(userOutfit.UserId, userOutfit, AvatarOwnershipNotificationType.Update);
	}

	private void OnUserOutfitDeleted(IUserOutfit userOutfit)
	{
		ProcessAction(delegate
		{
			_AvatarDomainFactories.RecentAvatarItemPublisher.RemoveUserOutfits(userOutfit.UserId, new List<IUserOutfit> { userOutfit });
		});
		TryPublishOutfitOwnershipChangeNotification(userOutfit.UserId, userOutfit, AvatarOwnershipNotificationType.Revoke);
	}

	private void TryPublishOutfitOwnershipChangeNotification(long userId, IUserOutfit userOutfit, AvatarOwnershipNotificationType avatarOwnershipNotificationType)
	{
		try
		{
			_AvatarUserNotificationPublisher.PublishOutfitOwnershipChangeNotification(userId, userOutfit, avatarOwnershipNotificationType);
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException($"Error publishing avatar user notification for userId={userId} and userOutfit={userOutfit.Id}: {ex}");
		}
	}
}
