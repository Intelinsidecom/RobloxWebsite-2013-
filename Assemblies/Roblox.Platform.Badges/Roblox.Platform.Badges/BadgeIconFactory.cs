using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using Roblox.Drawing;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Assets.Interface;
using Roblox.Platform.Badges.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeIconFactory" />
public class BadgeIconFactory : IBadgeIconFactory
{
	private const int _BadgeImageSize = 150;

	private readonly Size _BadgeSize = new Size(150, 150);

	private readonly IList<Tuple<Point, byte>> _AntiAliasedTransparentPixels;

	private readonly ISettings _Settings;

	private readonly IAssetFactoryBase<IImage> _ImageFactory;

	private readonly IUploadFloodcheckerFactory _UploadFloodcheckerFactory;

	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgeIconFactory" />
	/// </summary>
	/// <param name="settings">The badge <see cref="T:Roblox.Platform.Badges.Properties.ISettings" />.</param>
	/// <param name="imageFactory">The <see cref="T:Roblox.Platform.Assets.IAssetFactoryBase`1" /> for <see cref="T:Roblox.Platform.Assets.IImage" />s.</param>
	/// <param name="uploadFloodcheckerFactory">An <see cref="T:Roblox.Platform.Assets.Interface.IUploadFloodcheckerFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public BadgeIconFactory(ISettings settings, IAssetFactoryBase<IImage> imageFactory, IAssetOwnershipAuthority assetOwnershipAuthority, IUploadFloodcheckerFactory uploadFloodcheckerFactory)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ImageFactory = imageFactory ?? throw new ArgumentNullException("imageFactory");
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new ArgumentNullException("assetOwnershipAuthority");
		_UploadFloodcheckerFactory = uploadFloodcheckerFactory ?? throw new ArgumentNullException("uploadFloodcheckerFactory");
		_AntiAliasedTransparentPixels = ImageUtil.GetTransparentPixelsForCircularCutout(150).ToList();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeIconFactory.CreateBadgeIcon(Roblox.Platform.Membership.IUser,System.String,System.IO.Stream,System.Net.DecompressionMethods)" />
	public IImage CreateBadgeIcon(IUser creator, string name, Stream imageFile, DecompressionMethods imageFileDecompressionMethods)
	{
		if (creator == null)
		{
			throw new ArgumentNullException("creator");
		}
		if (imageFile == null)
		{
			throw new ArgumentNullException("imageFile");
		}
		if (string.IsNullOrWhiteSpace(name) || name.Length > _Settings.MaxBadgeIconNameLength)
		{
			throw new ArgumentException(string.Format("{0} must not be null or whitespace, and less than {1} characters.", "name", _Settings.MaxBadgeIconNameLength + 1), "name");
		}
		IRetryAfterFloodChecker floodChecker = _UploadFloodcheckerFactory.GetImageUploadFloodchecker(creator);
		if (floodChecker.IsFlooded())
		{
			throw new PlatformFloodedException();
		}
		try
		{
			using Stream imageStream = DrawBadgeImage(imageFile);
			AssetNameAndDescription assetNameAndDescription = new AssetNameAndDescription(creator, name, string.Empty);
			StreamCreatorInfo assetStream = new StreamCreatorInfo(imageStream, imageFileDecompressionMethods);
			AssetCreatorInfo imageAssetCreatorInfo = new AssetCreatorInfo(Roblox.Platform.Assets.CreatorType.User, creator.Id);
			IImage image = _ImageFactory.Create(assetNameAndDescription, imageAssetCreatorInfo, assetStream, creator);
			AwardImage(creator, image);
			floodChecker.UpdateCount();
			return image;
		}
		catch (PlatformAssetTextFullyModeratedException)
		{
			throw;
		}
		catch (Exception e)
		{
			throw new PlatformOperationUnavailableException("Failed to create image asset: Service unavailable.", e);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual Stream DrawBadgeImage(Stream imageStream)
	{
		return ImageUtil.ReshapeToCircularImage(imageStream, _AntiAliasedTransparentPixels, _BadgeSize);
	}

	[ExcludeFromCodeCoverage]
	internal virtual void AwardImage(IUser user, IImage image)
	{
		_AssetOwnershipAuthority.AwardAsset(image.Id, user.Id);
	}
}
