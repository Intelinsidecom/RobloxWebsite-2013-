using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Thumbs;

public interface IAvatarThumbnail
{
	ThumbnailDomainFactories DomainFactories { get; }

	ThumbResult GetUser3DThumbnailUrl(IUser userId);

	[Obsolete("Prefer GetBuildersClubOverlayUrl(IUser user, ...) instead, this will be deleted")]
	string GetBuildersClubOverlayUrl(User user, bool useSmall);

	string GetBuildersClubOverlayUrl(IUser user, bool useSmall);

	bool IsAvatarInvalidationFlooded(long userId);

	void InvalidateAvatar(long userId);

	[Obsolete("Prefer GetThumbnailUrl(long userId, ...) instead, this will be deleted")]
	ThumbResult GetThumbnailUrl(User user, int width, int height, string format, AvatarImageType imageType = AvatarImageType.Normal);

	[Obsolete("Prefer GetThumbnailUrl(long userId, ...) instead, this will be deleted")]
	ThumbResult GetThumbnailUrl(User user, ImageParameters imageParameters, AvatarImageType imageType = AvatarImageType.Normal);

	[Obsolete("Use GetBustThumbnailUrl(IUser user, ...) instead, this will be deleted")]
	ThumbResult GetBustThumbnailUrl(User user, ImageParameters imageParameters);

	[Obsolete("Use GetHeadshotThumbnailUrl(IUser user, ...) instead, this will be deleted")]
	ThumbResult GetHeadshotThumbnailUrl(User user, ImageParameters imageParameters);

	ThumbResult GetThumbnailUrl(long userId, int width, int height, string format, AvatarImageType imageType);

	ThumbResult GetThumbnailUrl(long userId, ImageParameters imageParameters, AvatarImageType imageType = AvatarImageType.Normal);

	ThumbResult GetThumbnailUrl(IUser user, int width, int height, string format, AvatarImageType imageType = AvatarImageType.Normal);

	ThumbResult GetThumbnailUrl(IUser user, ImageParameters imageParameters, AvatarImageType imageType = AvatarImageType.Normal);

	ThumbResult GetBustThumbnailUrl(IUser user, ImageParameters imageParameters);

	ThumbResult GetHeadshotThumbnailUrl(IUser user, ImageParameters imageParameters);

	ThumbResult GetOutfit3DThumbnailUrl(IUserOutfit userOutfit);

	ThumbResult GetOutfitThumbnailUrl(IUserOutfit outfit, ImageParameters imageParameters);

	ThumbResult GetOutfit3DThumbnailUrl(IOutfit outfit);

	ThumbResult GetOutfitThumbnailUrl(IOutfit outfit, ImageParameters imageParameters);
}
