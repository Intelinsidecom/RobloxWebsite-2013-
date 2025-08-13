using System;
using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

/// <summary>
/// This both does avatar recent items logic, and actually modifies the "recent items" entities.
/// </summary>
public class RecentAvatarItemPublisher : IRecentAvatarItemPublisher
{
	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly IUserFactory _UserFactory;

	private IAvatarOwnershipFactory AvatarOwnershipFactory => _AvatarDomainFactories.AvatarOwnershipFactory;

	public RecentAvatarItemPublisher(AvatarDomainFactories avatarDomainFactories, IUserFactory userFactory)
	{
		_AvatarDomainFactories = avatarDomainFactories;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public void AddUserOutfits(long userId, List<IUserOutfit> userOutfits)
	{
		DateTime date = DateTime.Now;
		RecentAvatarItems recentAvatarItems = new RecentAvatarItems(_UserFactory.GetUser(userId), _AvatarDomainFactories);
		foreach (IUserOutfit userOutfit in userOutfits)
		{
			if (recentAvatarItems.QualifiesAsRecentAvatarItem(userOutfit))
			{
				recentAvatarItems.Add(userOutfit, date);
			}
		}
		recentAvatarItems.Save();
	}

	public void RemoveUserOutfits(long userId, List<IUserOutfit> userOutfits)
	{
		RecentAvatarItems recentAvatarItems = new RecentAvatarItems(_UserFactory.GetUser(userId), _AvatarDomainFactories);
		foreach (IUserOutfit userOutfit in userOutfits)
		{
			if (recentAvatarItems.QualifiesAsRecentAvatarItem(userOutfit))
			{
				recentAvatarItems.Remove(userOutfit);
			}
		}
		recentAvatarItems.Save();
	}

	public void AddAssets(long userId, List<long> assetIds)
	{
		DateTime date = DateTime.Now;
		RecentAvatarItems recentAvatarItems = new RecentAvatarItems(_UserFactory.GetUser(userId), _AvatarDomainFactories);
		foreach (long assetId in assetIds)
		{
			Roblox.Platform.Assets.IAsset asset = _AvatarDomainFactories.AssetFactory.GetAsset(assetId);
			if (asset == null)
			{
				return;
			}
			if (recentAvatarItems.QualifiesAsRecentAvatarItem(asset))
			{
				recentAvatarItems.Add(asset, date);
			}
		}
		recentAvatarItems.Save();
	}

	public void RemoveAssets(long userId, List<long> assetIds)
	{
		RecentAvatarItems recentAvatarItems = new RecentAvatarItems(_UserFactory.GetUser(userId), _AvatarDomainFactories);
		bool modifiedRecentAvatarItems = false;
		foreach (long assetId in assetIds)
		{
			if (!OwnsOtherCopies(userId, assetId))
			{
				Roblox.Platform.Assets.IAsset asset = _AvatarDomainFactories.AssetFactory.GetAsset(assetId);
				if (asset != null && recentAvatarItems.QualifiesAsRecentAvatarItem(asset))
				{
					modifiedRecentAvatarItems = true;
					recentAvatarItems.Remove(asset);
				}
			}
		}
		if (modifiedRecentAvatarItems)
		{
			recentAvatarItems.Save();
		}
	}

	private bool OwnsOtherCopies(long userId, long assetId)
	{
		return AvatarOwnershipFactory.UserOwnsAsset(userId, assetId);
	}
}
