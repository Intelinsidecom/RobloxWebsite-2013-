using System;
using System.Collections.Generic;
using Roblox.FloodCheckers;
using Roblox.Locking;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;
using Roblox.Thumbnails.Client;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Thumbs;

public class AvatarThumbnail : DomainObjectBase<ThumbnailDomainFactories>, IAvatarThumbnail
{
	private readonly Guid _LeaseHolder = Guid.NewGuid();

	private readonly Dictionary<AvatarImageType, string> _AvatarImageTypeToThumbnailTypeMap = new Dictionary<AvatarImageType, string>
	{
		{
			AvatarImageType.Normal,
			"Avatar"
		},
		{
			AvatarImageType.Bust,
			"AvatarBust"
		},
		{
			AvatarImageType.Headshot,
			"AvatarHeadshot"
		}
	};

	public AvatarThumbnail(ThumbnailDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	public ThumbResult GetUser3DThumbnailUrl(IUser user)
	{
		return GetThumbnailUrl(user, ThumbnailConstants.ObjImageParameters.Width, ThumbnailConstants.ObjImageParameters.Height, ThumbnailConstants.ObjFormat);
	}

	public string GetBuildersClubOverlayUrl(User user, bool useSmall)
	{
		if (user == null)
		{
			return null;
		}
		if (user.IsBuildersClubMember())
		{
			if (useSmall)
			{
				return "~/images/icons/overlay_bc_small.png";
			}
			return "~/images/icons/overlay_bcOnly.png";
		}
		if (user.IsTurboBuildersClubMember())
		{
			if (useSmall)
			{
				return "~/images/icons/overlay_tbc_small.png";
			}
			return "~/images/icons/overlay_tbcOnly.png";
		}
		if (user.IsOutrageousBuildersClubMember())
		{
			if (useSmall)
			{
				return "~/images/icons/overlay_obc_small.png";
			}
			return "~/images/icons/overlay_obcOnly.png";
		}
		return null;
	}

	public string GetBuildersClubOverlayUrl(IUser user, bool useSmall)
	{
		if (user == null)
		{
			return null;
		}
		if (user.IsBuildersClubMember())
		{
			if (useSmall)
			{
				return "~/images/icons/overlay_bc_small.png";
			}
			return "~/images/icons/overlay_bcOnly.png";
		}
		if (user.IsTurboBuildersClubMember())
		{
			if (useSmall)
			{
				return "~/images/icons/overlay_tbc_small.png";
			}
			return "~/images/icons/overlay_tbcOnly.png";
		}
		if (user.IsOutrageousBuildersClubMember())
		{
			if (useSmall)
			{
				return "~/images/icons/overlay_obc_small.png";
			}
			return "~/images/icons/overlay_obcOnly.png";
		}
		return null;
	}

	public bool IsAvatarInvalidationFlooded(long userId)
	{
		return GetAvatarInvalidationFloodchecker(userId).IsFlooded();
	}

	public void InvalidateAvatar(long userId)
	{
		try
		{
			FloodChecker floodchecker = GetAvatarInvalidationFloodchecker(userId);
			if (floodchecker.IsFlooded())
			{
				throw new AvatarInvalidationFloodedException("Avatar regeneration is unavailable at this time");
			}
			IUserAvatar userAvatar = base.DomainFactories.AvatarDomainFactories.UserAvatarFactory.GetOrCreate(userId);
			if (userAvatar.NewAvatarAssetHashID <= 0)
			{
				return;
			}
			using SqlLeasedLock leasedLock = new SqlLeasedLock($"AvatarInvalidation_AssetHashId:{userAvatar.NewAvatarAssetHashID}", _LeaseHolder, TimeSpan.FromSeconds(5.0), base.DomainFactories.Logger.Error);
			if (!leasedLock.IsLockAcquired)
			{
				throw new AvatarInvalidationFloodedException("Avatar regeneration is unavailable at this time");
			}
			if (floodchecker.IsFlooded())
			{
				throw new AvatarInvalidationFloodedException("Avatar regeneration is unavailable at this time");
			}
			long assetHashId = userAvatar.NewAvatarAssetHashID;
			userAvatar.ClearThumbnail();
			base.DomainFactories.ThumbnailInvalidator.InvalidateThumbnailsByAssetHashIds(assetHashId);
			floodchecker.UpdateCount();
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error("Exception in InvalidateAvatar: " + e);
		}
	}

	private IRawContent CreateNewAvatarAssetHash(long userId, IUserAvatar userAvatar)
	{
		IRawContent avatarAssetHash = null;
		LeasedLock leasedLock = LeasedLock.GetOrCreate("CreateNewAvatarAssetHash_UserID:" + userId);
		if (leasedLock.TryAcquire(_LeaseHolder, 5000))
		{
			IAvatar avatar = base.DomainFactories.AvatarDomainFactories.AvatarFactory.GetAvatar(userId);
			if (avatar != null)
			{
				avatarAssetHash = base.DomainFactories.AvatarDomainFactories.AvatarKeyGenerator.GenerateAssetHash(avatar);
				userAvatar.NewAvatarAssetHashID = avatarAssetHash.Id;
				userAvatar.Save();
			}
			leasedLock.TryRelease(_LeaseHolder);
		}
		return avatarAssetHash;
	}

	public ThumbResult GetThumbnailUrl(IUser user, int width, int height, string format, AvatarImageType imageType = AvatarImageType.Normal)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		return GetThumbnailUrl(user.Id, width, height, format, imageType);
	}

	[Obsolete("Use GetThumbnailUrl(IUser user, ...) instead")]
	public ThumbResult GetThumbnailUrl(User user, int width, int height, string format, AvatarImageType imageType = AvatarImageType.Normal)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		return GetThumbnailUrl(user.ID, width, height, format, imageType);
	}

	[Obsolete("Use GetThumbnailUrl(IUser user, ...) instead")]
	public ThumbResult GetThumbnailUrl(User user, ImageParameters imageParameters, AvatarImageType imageType = AvatarImageType.Normal)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
		}
		return GetThumbnailUrl(user, imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, imageType);
	}

	[Obsolete("Use GetBustThumbnailUrl(IUser user, ...) instead")]
	public ThumbResult GetBustThumbnailUrl(User user, ImageParameters imageParameters)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
		}
		return GetThumbnailUrl(user.ID, imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, AvatarImageType.Bust);
	}

	[Obsolete("Use GetHeadshotThumbnailUrl(IUser user, ...) instead")]
	public ThumbResult GetHeadshotThumbnailUrl(User user, ImageParameters imageParameters)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
		}
		return GetThumbnailUrl(user.ID, imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, AvatarImageType.Headshot);
	}

	public ThumbResult GetThumbnailUrl(IUser user, ImageParameters imageParameters, AvatarImageType imageType = AvatarImageType.Normal)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
		}
		return GetThumbnailUrl(user.Id, imageParameters, imageType);
	}

	public ThumbResult GetBustThumbnailUrl(IUser user, ImageParameters imageParameters)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
		}
		return GetThumbnailUrl(user.Id, imageParameters, AvatarImageType.Bust);
	}

	public ThumbResult GetHeadshotThumbnailUrl(IUser user, ImageParameters imageParameters)
	{
		if (user == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
		}
		return GetThumbnailUrl(user.Id, imageParameters, AvatarImageType.Headshot);
	}

	public ThumbResult GetThumbnailUrl(long userId, ImageParameters imageParameters, AvatarImageType imageType = AvatarImageType.Normal)
	{
		return GetThumbnailUrl(userId, imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, imageType);
	}

	public ThumbResult GetThumbnailUrl(long userId, int width, int height, string format, AvatarImageType imageType)
	{
		if (userId == 0L)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		IUserAvatar userAvatar = base.DomainFactories.AvatarDomainFactories.UserAvatarFactory.GetOrCreate(userId);
		long newAvatarAssetHashId = userAvatar.NewAvatarAssetHashID;
		if (newAvatarAssetHashId == 0L || AssetHash.Get(newAvatarAssetHashId) == null)
		{
			IRawContent newAssetHash = CreateNewAvatarAssetHash(userId, userAvatar);
			if (newAssetHash == null)
			{
				return base.DomainFactories.StaticImages.GetUnavailableThumbResult(width, height, format);
			}
			newAvatarAssetHashId = newAssetHash.Id;
		}
		try
		{
			ThumbnailHashResult thumbnailHashResult = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(newAvatarAssetHashId, _AvatarImageTypeToThumbnailTypeMap[imageType], width, height, format, (long?)null);
			return ThumbResult.Create(width, height, format, thumbnailHashResult, base.DomainFactories);
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error($"Error getting thumbnail: {e}");
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
	}

	public ThumbResult GetOutfit3DThumbnailUrl(IUserOutfit userOutfit)
	{
		return GetUserOutfitThumbnailUrl(userOutfit, ThumbnailConstants.ObjImageParameters.Width, ThumbnailConstants.ObjImageParameters.Height, ThumbnailConstants.ObjFormat);
	}

	public ThumbResult GetOutfitThumbnailUrl(IUserOutfit userOutfit, ImageParameters imageParameters)
	{
		return GetUserOutfitThumbnailUrl(userOutfit, imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
	}

	private ThumbResult GetUserOutfitThumbnailUrl(IUserOutfit userOutfit, int width, int height, string format)
	{
		if (userOutfit == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		IOutfit outfit = base.DomainFactories.AvatarDomainFactories.OutfitDomainFactories.OutfitFactory.GetOutfit(userOutfit.OutfitId);
		return GetOutfitThumbnailUrl(outfit, width, height, format);
	}

	public ThumbResult GetOutfit3DThumbnailUrl(IOutfit outfit)
	{
		return GetOutfitThumbnailUrl(outfit, ThumbnailConstants.ObjImageParameters.Width, ThumbnailConstants.ObjImageParameters.Height, ThumbnailConstants.ObjFormat);
	}

	public ThumbResult GetOutfitThumbnailUrl(IOutfit outfit, ImageParameters imageParameters)
	{
		return GetOutfitThumbnailUrl(outfit, imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
	}

	private ThumbResult GetOutfitThumbnailUrl(IOutfit outfit, int width, int height, string format)
	{
		if (outfit == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		long newAvatarAssetHashId = outfit.AssetHashID;
		if (AssetHash.Get(newAvatarAssetHashId) == null)
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		try
		{
			ThumbnailHashResult thumbnailHashResult = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(newAvatarAssetHashId, "Avatar", width, height, format, (long?)null);
			return ThumbResult.Create(width, height, format, thumbnailHashResult, base.DomainFactories);
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error($"Error getting ThumbnailHash for outfit Id = {outfit.ID}: {e}");
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
	}

	private FloodChecker GetAvatarInvalidationFloodchecker(long userId)
	{
		IUserAvatar userAvatar = base.DomainFactories.AvatarDomainFactories.UserAvatarFactory.GetOrCreate(userId);
		return new FloodChecker("AvatarInvalidation", $"AvatarInvalidation_AssetHashId:{userAvatar.NewAvatarAssetHashID}", Settings.Default.CharacterThumbnailInvalidationLimit, Settings.Default.CharacterThumbnailInvalidationInterval);
	}
}
