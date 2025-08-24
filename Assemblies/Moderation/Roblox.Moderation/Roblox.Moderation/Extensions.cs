using System;
using Roblox.Agents;
using Roblox.Moderation;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Moderation;

public static class Extensions
{
	private static AssetModerationStatus GetAssetModerationStatus(this ItemStatus itemStatusEntity)
	{
		if (itemStatusEntity == null)
		{
			return AssetModerationStatus.Green;
		}
		if (itemStatusEntity.ItemTypeID != ItemType.Asset.ID)
		{
			throw new ArgumentException($"ItemStatus {itemStatusEntity.ID} does not pertain to an Asset.");
		}
		if (itemStatusEntity.StatusTypeID == StatusType.Green.ID)
		{
			return AssetModerationStatus.Green;
		}
		if (itemStatusEntity.StatusTypeID == StatusType.Yellow.ID)
		{
			return AssetModerationStatus.Yellow;
		}
		if (itemStatusEntity.StatusTypeID == StatusType.Orange.ID)
		{
			return AssetModerationStatus.Orange;
		}
		if (itemStatusEntity.StatusTypeID == StatusType.Red.ID)
		{
			return AssetModerationStatus.Red;
		}
		throw new ArgumentException($"Unknown ItemStatus. ID: {itemStatusEntity.ID}, StatusTypeID: {itemStatusEntity.StatusTypeID}");
	}

	[Obsolete("use AssetModerationStatusChecker instead.")]
	public static AssetModerationStatus GetModerationStatus(this IAsset asset)
	{
		if (asset == null)
		{
			return ((ItemStatus)null).GetAssetModerationStatus();
		}
		return ItemStatus.GetByItemTypeIDAndItemTargetID(ItemType.Asset.ID, asset.Id).GetAssetModerationStatus();
	}

	public static bool CanSell(this IUserIdentifier user)
	{
		if (user == null)
		{
			return false;
		}
		SellBan sellBanEntity = SellBan.GetByUserID(user.Id);
		if (sellBanEntity == null)
		{
			return true;
		}
		return sellBanEntity.Expiration <= DateTime.Now;
	}

	/// <summary>
	/// Check if a agent has sell ban. Agent could be user or group.
	/// </summary>
	/// <param name="agent">The agent</param>
	/// <returns>Whether the agent can sell or not</returns>
	public static bool CanSell(this IAgent agent)
	{
		if (agent == null)
		{
			return false;
		}
		SellBan sellBanEntity = SellBan.GetByUserID(agent.Id);
		if (sellBanEntity == null)
		{
			return true;
		}
		return sellBanEntity.Expiration <= DateTime.Now;
	}

	public static void AddToWhitelist(this IUser user)
	{
		user.VerifyIsNotNull();
		if (WatchDogWhitelistedPlaceCreator.GetByCreatorID(user.Id) == null)
		{
			WatchDogWhitelistedPlaceCreator.CreateNew(user.Id);
		}
	}

	public static void RemoveFromWhitelist(this IUser user)
	{
		user.VerifyIsNotNull();
		WatchDogWhitelistedPlaceCreator.GetByCreatorID(user.Id)?.Delete();
	}

	public static bool IsInWhitelist(this IUser user)
	{
		user.VerifyIsNotNull();
		return WatchDogWhitelistedPlaceCreator.GetByCreatorID(user.Id) != null;
	}

	public static string GetValue(this PunishmentType punishmentType)
	{
		Roblox.Moderation.PunishmentType punishmentTypeEntity = Roblox.Moderation.PunishmentType.Get((byte)punishmentType);
		if (punishmentTypeEntity == null)
		{
			return string.Empty;
		}
		return punishmentTypeEntity.Value;
	}
}
