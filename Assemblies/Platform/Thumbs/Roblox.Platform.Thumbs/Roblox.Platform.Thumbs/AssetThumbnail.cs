using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using Roblox.AssetMedia;
using Roblox.AssetMedia.Properties;
using Roblox.Configuration;
using Roblox.Platform.Assets;
using Roblox.Platform.Badges;
using Roblox.Platform.Core;
using Roblox.Platform.Universes;
using Roblox.Thumbnails.Client;
using Roblox.Thumbs.Properties;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Thumbs;

public class AssetThumbnail : DomainObjectBase<ThumbnailDomainFactories>, IAssetThumbnail
{
	private readonly IBadgeReader _BadgeReader;

	private readonly IAssetFactoryBase<IImage> _ImageFactory;

	private readonly Dictionary<string, string> _AssetTypeValueToThumbnailTypeValueMap = new Dictionary<string, string>
	{
		{ "Torso", "BodyPart_Torso" },
		{ "Left Leg", "BodyPart_LeftLeg" },
		{ "Right Leg", "BodyPart_RightLeg" },
		{ "Left Arm", "BodyPart_LeftArm" },
		{ "Right Arm", "BodyPart_RightArm" },
		{ "T-Shirt", "TeeShirt" },
		{ "Badge", "Image" },
		{ "Game Pass", "Image" },
		{ "Hat", "Hat" },
		{ "Hair Accessory", "Hat" },
		{ "Face Accessory", "Hat" },
		{ "Neck Accessory", "Hat" },
		{ "Shoulder Accessory", "Hat" },
		{ "Front Accessory", "Hat" },
		{ "Back Accessory", "Hat" },
		{ "Waist Accessory", "Hat" },
		{ "Climb Animation", "AvatarAnimation" },
		{ "Death Animation", "AvatarAnimation" },
		{ "Fall Animation", "AvatarAnimation" },
		{ "Idle Animation", "AvatarAnimation" },
		{ "Jump Animation", "AvatarAnimation" },
		{ "Run Animation", "AvatarAnimation" },
		{ "Swim Animation", "AvatarAnimation" },
		{ "Walk Animation", "AvatarAnimation" },
		{ "Pose Animation", "AvatarAnimation" },
		{ "Emote Animation", "EmoteAnimation" }
	};

	private readonly Dictionary<string, string> _AssetTypeValueToModerationAgnosticThumbnailTypeValueMap = new Dictionary<string, string> { { "Mesh", "ModerationAgnosticMesh" } };

	private readonly HashSet<int> _UnsupportedAssetTypes = new HashSet<int>
	{
		AssetType.YouTubeVideoID,
		AssetType.TextID,
		AssetType.ArmsID,
		AssetType.LegsID,
		AssetType.HtmlID,
		AssetType.SolidModelID,
		AssetType.LocalizationTableManifestID,
		AssetType.LocalizationTableTranslationID
	};

	private HashSet<int> _Supported3DAssetTypeIds;

	private HashSet<int> _SupportedAnimatedAssetTypeIds;

	public AssetThumbnail(ThumbnailDomainFactories domainFactories, IBadgeReader badgeReader, IAssetFactoryBase<IImage> imageFactory)
		: base(domainFactories)
	{
		_BadgeReader = badgeReader ?? throw new ArgumentNullException("badgeReader");
		_ImageFactory = imageFactory ?? throw new ArgumentNullException("imageFactory");
		Roblox.Thumbs.Properties.Settings.Default.ReadValueAndMonitorChanges((Roblox.Thumbs.Properties.Settings s) => s.ThreeDeeThumbsSupportedAssetTypeValuesCSV, delegate(string value)
		{
			try
			{
				HashSet<string> assetTypeValues2 = MultiValueSettingParser.ParseCommaDelimitedListString(value);
				_Supported3DAssetTypeIds = GetAssetTypeIdsFromAssetTypeValues(assetTypeValues2);
			}
			catch
			{
				_Supported3DAssetTypeIds = new HashSet<int>();
			}
		});
		Roblox.Thumbs.Properties.Settings.Default.ReadValueAndMonitorChanges((Roblox.Thumbs.Properties.Settings s) => s.AnimatedAvatarAnimationSupportedAssetTypeValuesCSV, delegate(string value)
		{
			try
			{
				HashSet<string> assetTypeValues = MultiValueSettingParser.ParseCommaDelimitedListString(value);
				_SupportedAnimatedAssetTypeIds = GetAssetTypeIdsFromAssetTypeValues(assetTypeValues);
			}
			catch
			{
				_SupportedAnimatedAssetTypeIds = new HashSet<int>();
			}
		});
		Roblox.Thumbs.Properties.Settings.Default.ReadValueAndMonitorChanges((Roblox.Thumbs.Properties.Settings s) => s.IsFaceAssetThumbnailedAsFaceInsteadOfDecal, delegate(bool value)
		{
			if (value && !_AssetTypeValueToThumbnailTypeValueMap.ContainsKey("Face"))
			{
				_AssetTypeValueToThumbnailTypeValueMap.Add("Face", "Face");
			}
			else if (!value && _AssetTypeValueToThumbnailTypeValueMap.ContainsKey("Face"))
			{
				_AssetTypeValueToThumbnailTypeValueMap.Remove("Face");
			}
		});
	}

	private HashSet<int> GetAssetTypeIdsFromAssetTypeValues(IEnumerable<string> assetTypeValues)
	{
		HashSet<int> assetTypeIds = new HashSet<int>();
		foreach (string assetTypeValue in assetTypeValues)
		{
			AssetType assetType = AssetType.Get(assetTypeValue.Trim());
			if (assetType != null)
			{
				assetTypeIds.Add(assetType.ID);
			}
		}
		return assetTypeIds;
	}

	public bool IsSupported3DAssetType(int assetTypeId)
	{
		return _Supported3DAssetTypeIds.Contains(assetTypeId);
	}

	public bool IsSupportedAnimatedAssetType(int assetTypeId)
	{
		return _SupportedAnimatedAssetTypeIds.Contains(assetTypeId);
	}

	private ThumbResult GetInvalid3DThumbResult(bool final)
	{
		return new ThumbResult
		{
			final = final,
			GetUrl = (bool secureConnection) => null
		};
	}

	private ThumbResult GetInvalidAnimatedThumbResult(bool final)
	{
		return new ThumbResult
		{
			final = final,
			GetUrl = (bool secureConnection) => null
		};
	}

	/// <summary>
	/// Returns Thumb Result for 3D thumbnail request for moderation purposes (moderation agnostic)
	/// </summary>
	/// <param name="assetHashId">asset hash id</param>
	/// <returns>A <see cref="T:Roblox.Thumbs.ThumbResult" /> for specified assetHashId</returns>
	public ThumbResult GetModerationAgnostic3DThumbnailUrlForAssetHash(long assetHashId)
	{
		int width = ThumbnailConstants.ObjImageParameters.Width;
		int height = ThumbnailConstants.ObjImageParameters.Height;
		string format = ThumbnailConstants.ObjFormat;
		AssetHash assetHash = AssetHash.Get(assetHashId);
		ThumbResult thumbResult;
		try
		{
			AssetType assetType = assetHash.GetAssetType();
			if (!_AssetTypeValueToModerationAgnosticThumbnailTypeValueMap.TryGetValue(assetType.Value, out var thumbnailType))
			{
				throw new ArgumentException($"Thumbnail for {assetType.Value} asset type can't be requested as moderation agnostic");
			}
			ThumbnailHashResult thumbnailHashResult = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(assetHash.ID, thumbnailType, width, height, format, (long?)null);
			thumbResult = ThumbResult.Create(width, height, format, thumbnailHashResult, base.DomainFactories);
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error($"ERROR in Thumbnail service for AssetHashId {assetHashId}: {e}");
			thumbResult = base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		return thumbResult ?? GetInvalid3DThumbResult(final: false);
	}

	/// <summary>
	/// Returns Thumb Result for 2D thumbnail request for moderation purposes (moderation agnostic)
	/// </summary>
	/// <param name="assetHashId">asset hash id</param>
	/// <param name="imageParameters">A <see cref="T:Roblox.Thumbs.ImageParameters" /> (contains format, width, height, etc.)</param>
	/// <returns>A <see cref="T:Roblox.Thumbs.ThumbResult" /> for specified assetHashId and imageParameters</returns>
	public ThumbResult GetModerationAgnosticThumbnailUrlForAssetHash(long assetHashId, ImageParameters imageParameters)
	{
		int width = imageParameters.Width;
		int height = imageParameters.Height;
		string format = imageParameters.Format.ToString();
		try
		{
			AssetType assetType = AssetType.Get(AssetHash.Get(assetHashId).AssetTypeID);
			if (!_AssetTypeValueToModerationAgnosticThumbnailTypeValueMap.TryGetValue(assetType.Value, out var thumbnailType))
			{
				throw new ArgumentException($"Thumbnail for {assetType.Value} asset type can't be requested as moderation agnostic");
			}
			ThumbnailHashResult thumbnailHashResult = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(assetHashId, thumbnailType, width, height, format, (long?)null);
			return ThumbResult.Create(width, height, format, thumbnailHashResult, base.DomainFactories);
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error($"ERROR in Thumbnail service (Moderated action) for  AssetHashId: {assetHashId}");
			base.DomainFactories.Logger.Error(e);
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
	}

	private ThumbResult GetInvalidResult(string imageFormat, bool final)
	{
		if (imageFormat == ThumbnailConstants.ObjFormat)
		{
			return GetInvalid3DThumbResult(final);
		}
		if (imageFormat == ThumbnailConstants.AnimationManifestFormat)
		{
			return GetInvalidAnimatedThumbResult(final);
		}
		throw new Exception($"Invalid thumbFormat {imageFormat} ");
	}

	private bool IsSupportedAssetType(IAsset asset, string thumbFormat)
	{
		if (thumbFormat == ThumbnailConstants.ObjFormat)
		{
			return IsSupported3DAssetType(asset.Type.ID);
		}
		if (thumbFormat == ThumbnailConstants.AnimationManifestFormat)
		{
			return IsSupportedAnimatedAssetType(asset.Type.ID);
		}
		throw new Exception($"Invalid thumbnailFormat {thumbFormat}");
	}

	public ThumbResult GetAsset3DThumbnailUrl(long assetId, string imageFormat = "Obj")
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		IAsset asset = Roblox.Asset.Get(assetId);
		ThumbResult invalidThumbResult = GetUnapprovedOrUnreviewedOrBrokenThumbnail(asset, ThumbnailConstants.ObjImageParameters.Width, ThumbnailConstants.ObjImageParameters.Height, imageFormat, overrideModeration: false);
		if (invalidThumbResult != null)
		{
			bool final = invalidThumbResult.final;
			return GetInvalidResult(imageFormat, final);
		}
		if (!IsSupportedAssetType(asset, imageFormat))
		{
			return GetInvalidResult(imageFormat, final: false);
		}
		ThumbResult thumbResult = GetThumbnailFromThumbnailsService(asset, ThumbnailConstants.ObjImageParameters.Width, ThumbnailConstants.ObjImageParameters.Height, imageFormat, null);
		if (thumbResult == null)
		{
			return GetInvalidResult(imageFormat, final: false);
		}
		if ((int)thumbResult.SubstitutionType == 2 || (int)thumbResult.SubstitutionType == 1)
		{
			return GetInvalidResult(imageFormat, final: true);
		}
		return thumbResult;
	}

	public ThumbResult GetAssetAnimatedThumbnailUrl(long assetId)
	{
		return GetAsset3DThumbnailUrl(assetId, ThumbnailConstants.AnimationManifestFormat);
	}

	private ThumbResult GetUnapprovedOrUnreviewedOrBrokenThumbnail(IAsset asset, int width, int height, string format, bool overrideModeration)
	{
		if (!IsAssetValidToThumbnail(asset, overrideModeration))
		{
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
		AssetType assetType = asset.Type;
		if (_UnsupportedAssetTypes.Contains(assetType.ID))
		{
			return base.DomainFactories.StaticImages.GetUnknownThumbResult(width, height, format);
		}
		bool isApproved = asset.IsApproved;
		bool isReviewed = asset.IsReviewed;
		if (!overrideModeration)
		{
			if (!isApproved && (isReviewed || !assetType.RequiresReview))
			{
				return base.DomainFactories.StaticImages.GetUnapprovedThumbResult(width, height, format);
			}
			if (!isReviewed && assetType.RequiresReview)
			{
				return base.DomainFactories.StaticImages.GetUnreviewedThumbResult(width, height, format);
			}
		}
		return null;
	}

	public ThumbResult GetThumbnailUrl(IAsset asset, ImageParameters imageParameters)
	{
		return GetThumbnailUrl(asset, imageParameters, overrideModeration: false);
	}

	public ThumbResult GetGameIconThumbnailUrl(IAsset asset, ImageParameters imageParameters)
	{
		return GetThumbnailUrl(asset, imageParameters, overrideModeration: false, ignoreAssetMediaItems: false, returnAutoGenerated: false, returnGameIcon: true);
	}

	/// <summary>
	/// Returns a substitute <see cref="T:Roblox.Thumbs.ThumbResult" /> if the auto-generated thumbnail should not be used for some reason.
	/// For example: If the thumbnail has been moderated, if the thumbnail is awaiting moderation, if the asset is a place
	/// and we now default to canned images, if the user has uploaded a replacement icon, etc.
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="thumbResult">If this thumbnail should be substituted, the substitution is returned here.</param>
	/// <param name="substituteAsset"></param>
	/// <param name="imageParameters">The image parameters.</param>
	/// <param name="overrideModeration">Whether to override moderation.</param>
	/// <param name="ignoreAssetMediaItems">Whether to ignore place media items. If set to True, use default thumbnail.</param>
	/// <param name="returnAutoGenerated">Whether to return auto generated thumbnail when there is no media items. When set to true, return camera generated thumbanil. Only applied to place.</param>
	/// <param name="returnGameIcon">Whether to return a default game icon when there is no media items and returnAutoGenerated is not set to true.</param>
	/// <returns></returns>
	public bool TryThumbnailSubstitution(IAsset asset, out ThumbResult thumbResult, ref IAsset substituteAsset, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
	{
		bool unavailable = false;
		try
		{
			thumbResult = GetUnapprovedOrUnreviewedOrBrokenThumbnail(asset, imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, overrideModeration);
			if (thumbResult != null)
			{
				return true;
			}
			if (!overrideModeration && asset.Type.ID == AssetType.DecalID)
			{
				imageParameters = new ImageParameters(imageParameters.Width, imageParameters.Height, ImageFormat.Png);
			}
			if (asset.Type.ID == AssetType.AppID)
			{
				thumbResult = base.DomainFactories.StaticImages.GetUnknownThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
				return true;
			}
			if (asset.Type.ID == AssetType.PluginID || asset.Type.ID == AssetType.ModelID || (asset.Type.ID == AssetType.PlaceID && !ignoreAssetMediaItems && Roblox.AssetMedia.Properties.Settings.Default.UsePlaceMediaItemForThumb))
			{
				long? mediaAssetID = GetMediaAssetID(asset, returnAutoGenerated, out unavailable);
				if (mediaAssetID.HasValue)
				{
					substituteAsset = Roblox.Asset.Get(mediaAssetID.Value);
					if (returnGameIcon)
					{
						thumbResult = GetGameIconThumbnailUrl(substituteAsset, imageParameters);
						return true;
					}
					return TryThumbnailSubstitution(substituteAsset, out thumbResult, ref substituteAsset, imageParameters, overrideModeration: false, ignoreAssetMediaItems: false, returnAutoGenerated: false, returnGameIcon: true);
				}
			}
			if (unavailable)
			{
				thumbResult = base.DomainFactories.StaticImages.GetUnavailableThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
				return true;
			}
			if (asset.Type.ID == AssetType.PlaceID && Roblox.Thumbs.Properties.Settings.Default.IsDefaultCameraGeneratedThumbnailRemovalEnabled && !returnAutoGenerated)
			{
				if (returnGameIcon)
				{
					thumbResult = GetDefaultPlaceGameIcon(asset.CurrentVersion.GetAsset().ID, imageParameters);
					return true;
				}
				thumbResult = GetDefaultPlaceThumbnail(asset.CurrentVersion.GetAsset().ID, imageParameters);
				return true;
			}
		}
		catch (Exception ex)
		{
			base.DomainFactories.Logger.Error(ex);
			thumbResult = base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Get multiple thumbnails at one time.
	/// </summary>
	/// <param name="assets">The assets who's thumbnails to get.</param>
	/// <param name="imageParameters">The image parameters.</param>
	/// <param name="overrideModeration">Whether to override moderation.</param>
	/// <param name="ignoreAssetMediaItems">Whether to ignore place media items. If set to True, use default thumbnail.</param>
	/// <param name="returnAutoGenerated">Whether to return auto generated thumbnail when there is no media items. When set to true, return camera generated thumbanil. Only applied to place.</param>
	/// <param name="returnGameIcon">Whether to return a default game icon when there is no media items and returnAutoGenerated is not set to true.</param>
	/// <returns>An array of <see cref="T:Roblox.Thumbs.ThumbResult" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">imageParameters</exception>
	/// <exception cref="T:System.ArgumentException">assets</exception>
	[Obsolete("Please use the MultigetThumbnailUrl that accepts Platform.Assets.IAssets instead")]
	public ThumbResult[] MultiGetThumbnailUrl(IAsset[] assets, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
	{
		if (assets == null)
		{
			throw new ArgumentException("assets");
		}
		if (imageParameters == null)
		{
			throw new ArgumentException("imageParameters");
		}
		if (assets.Length == 0)
		{
			return new ThumbResult[0];
		}
		ParallelQuery<MultiGetAssetHashModel> populatedSubstutionModels = from model in assets.Select((IAsset asset) => new MultiGetAssetHashModel
			{
				Asset = asset
			}).AsParallel().AsOrdered()
				.WithDegreeOfParallelism(Roblox.Thumbs.Properties.Settings.Default.MultiGetThumbnailsParallelism)
			select GetThumbnailSubstitution(model, imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon);
		return (from model in MultiGetThumbnailFromThumbnailsService(populatedSubstutionModels.ToList(), imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString())
			select model.Result).ToArray();
	}

	public ThumbResult[] MultiGetThumbnailUrl(Roblox.Platform.Assets.IAsset[] assets, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		if (imageParameters == null)
		{
			throw new ArgumentNullException("imageParameters");
		}
		Roblox.Asset[] convertedAssets = assets.Select((Roblox.Platform.Assets.IAsset asset) => Roblox.Asset.Get(asset.Id)).ToArray();
		IAsset[] assets2 = convertedAssets;
		return MultiGetThumbnailUrl(assets2, imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon);
	}

	/// <summary>
	/// Get thumbnail url for the given asset.
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="imageParameters">The image parameters.</param>
	/// <param name="overrideModeration">Whether to override moderation.</param>
	/// <param name="ignoreAssetMediaItems">Whether to ignore place media items. If set to True, use default thumbnail.</param>
	/// <param name="returnAutoGenerated">Whether to return auto generated thumbnail when there is no media items. When set to true, return camera generated thumbnail. Only applied to place.</param>
	/// <param name="returnGameIcon">Whether to return a default game icon when there is no media items and returnAutoGenerated is not set to true.</param>
	/// <returns></returns>
	public ThumbResult GetThumbnailUrl(IAsset asset, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
	{
		try
		{
			IAsset substituteAsset = null;
			if (TryThumbnailSubstitution(asset, out var thumbResult, ref substituteAsset, imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon))
			{
				return thumbResult;
			}
			if (substituteAsset != null)
			{
				asset = substituteAsset;
			}
			long? universeId = null;
			if (asset is Roblox.Asset && asset.Type.ID == AssetType.PlaceID)
			{
				IUniverse universe = base.DomainFactories.UniverseFactory.GetPlaceUniverse(((Roblox.Asset)asset).ID);
				if (universe != null)
				{
					universeId = universe.Id;
				}
			}
			return GetThumbnailFromThumbnailsService(asset, imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString(), universeId);
		}
		catch (Exception ex)
		{
			base.DomainFactories.Logger.Error(ex);
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
		}
	}

	/// <inheritdoc cref="M:Roblox.Thumbs.IAssetThumbnail.GetThumbnailUrl(Roblox.IAsset,Roblox.Thumbs.ImageParameters)" />
	public ThumbResult GetThumbnailUrl(Roblox.Platform.Assets.IAsset asset, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
	{
		return GetThumbnailUrl(Roblox.Asset.Get(asset.Id), imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon);
	}

	private MultiGetAssetHashModel GetThumbnailSubstitution(MultiGetAssetHashModel multiGetModel, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
	{
		IAsset substituteAsset = null;
		if (!IsAssetValidToThumbnail(multiGetModel.Asset, overrideModeration))
		{
			multiGetModel.Result = base.DomainFactories.StaticImages.GetUnknownThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
			return multiGetModel;
		}
		if (TryThumbnailSubstitution(multiGetModel.Asset, out var thumbResult, ref substituteAsset, imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon))
		{
			multiGetModel.Result = thumbResult;
		}
		else
		{
			if (substituteAsset != null)
			{
				multiGetModel.Asset = substituteAsset;
			}
			long assetHashId = GetAssetHashIDForThumbnailsService(multiGetModel.Asset);
			long? universeId = null;
			if (multiGetModel.Asset is Roblox.Asset rAsset && rAsset.Type.ID == AssetType.PlaceID)
			{
				IUniverse universe = base.DomainFactories.UniverseFactory.GetPlaceUniverse(rAsset.ID);
				if (universe != null)
				{
					universeId = universe.Id;
				}
			}
			multiGetModel.ToFetchAssetHashId = assetHashId;
			multiGetModel.UniverseId = universeId;
		}
		return multiGetModel;
	}

	private bool IsAssetValidToThumbnail(IAsset asset, bool moderationOverride)
	{
		if (asset == null)
		{
			return false;
		}
		if (!moderationOverride && Roblox.Thumbs.Properties.Settings.Default.ArchivedAssetThumbnailBlockingEnabled && asset.IsArchived == true)
		{
			return false;
		}
		return true;
	}

	private long GetAssetHashIDForThumbnailsService(IAsset asset)
	{
		int assetTypeId = asset.Type.ID;
		if (assetTypeId == AssetType.BadgeID)
		{
			Roblox.Platform.Badges.Badge badge = _BadgeReader.GetBadge(asset.CurrentVersion.AssetID);
			return _ImageFactory.Get(badge.ImageId).GetAssetHashId();
		}
		if (assetTypeId == AssetType.GamePassID)
		{
			return Roblox.Asset.Get(PlaceGamePass.GetPlaceGamePassesByPassID(asset.CurrentVersion.AssetID, 1, 1).First().ImageID).AssetHashID;
		}
		return asset.AssetHashID;
	}

	private ThumbResult GetThumbnailFromThumbnailsService(IAsset asset, int width, int height, string format, long? universeId)
	{
		long assetHashId = GetAssetHashIDForThumbnailsService(asset);
		return GetThumbnailFromThumbnailsService(assetHashId, asset.Type.Value, width, height, format, universeId);
	}

	private List<MultiGetAssetHashModel> MultiGetThumbnailFromThumbnailsService(List<MultiGetAssetHashModel> requestHashModels, int width, int height, string imageFormat)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		if (requestHashModels == null)
		{
			throw new ArgumentException("requestHashModels");
		}
		if (requestHashModels.Count == 0)
		{
			return new List<MultiGetAssetHashModel>(0);
		}
		try
		{
			List<ThumbnailHashRequest> requestList = new List<ThumbnailHashRequest>();
			Dictionary<long, MultiGetAssetHashModel> requestDupes = new Dictionary<long, MultiGetAssetHashModel>();
			foreach (MultiGetAssetHashModel requestHashModel in requestHashModels)
			{
				if (requestHashModel.Result == null && !requestDupes.ContainsKey(requestHashModel.ToFetchAssetHashId))
				{
					if (!_AssetTypeValueToThumbnailTypeValueMap.TryGetValue(requestHashModel.Asset.Type.Value, out var thumbnailType))
					{
						thumbnailType = requestHashModel.Asset.Type.Value;
					}
					if (thumbnailType == "AvatarAnimation" && imageFormat == "AnimationManifest")
					{
						thumbnailType = "AnimatedAvatarAnimation";
					}
					requestList.Add(new ThumbnailHashRequest
					{
						AssetHashId = requestHashModel.ToFetchAssetHashId,
						FormatType = imageFormat,
						Width = width,
						Height = height,
						ThumbnailTypeName = thumbnailType
					});
					requestDupes.Add(requestHashModel.ToFetchAssetHashId, requestHashModel);
				}
			}
			ThumbnailHashResult[] thumbResult = base.DomainFactories.ThumbnailsClient.MultiGetThumbnailHash(requestList.ToArray());
			return PopulateRequestHashModels(requestHashModels, width, height, imageFormat, thumbResult);
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error(string.Format("ERROR in Thumbnail service MultiGet for AssetHashIds: {0}", string.Join(", ", requestHashModels.Select((MultiGetAssetHashModel m) => m.ToFetchAssetHashId))));
			base.DomainFactories.Logger.Error(e);
			throw;
		}
	}

	private List<MultiGetAssetHashModel> PopulateRequestHashModels(List<MultiGetAssetHashModel> requestHashModels, int width, int height, string imageFormat, ThumbnailHashResult[] thumbResults)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		Dictionary<long, ThumbnailHashResult> resultDict = thumbResults.ToDictionary((ThumbnailHashResult t) => t.AssetHashId, (ThumbnailHashResult t) => t);
		foreach (MultiGetAssetHashModel requestHashModel in requestHashModels)
		{
			if (resultDict.TryGetValue(requestHashModel.ToFetchAssetHashId, out var thumb))
			{
				requestHashModel.Result = ThumbResult.Create(width, height, imageFormat, new ThumbnailHashResult
				{
					Hash = thumb.Hash,
					SubstitutionType = thumb.SubstitutionType,
					Url = thumb.Url
				}, base.DomainFactories);
			}
		}
		return requestHashModels;
	}

	private ThumbResult GetThumbnailFromThumbnailsService(long assetHashId, string assetTypeValue, int width, int height, string imageFormat, long? universeId)
	{
		try
		{
			if (!_AssetTypeValueToThumbnailTypeValueMap.TryGetValue(assetTypeValue, out var thumbnailType))
			{
				thumbnailType = assetTypeValue;
			}
			if (thumbnailType == "AvatarAnimation" && imageFormat == "AnimationManifest")
			{
				thumbnailType = "AnimatedAvatarAnimation";
			}
			else if (thumbnailType == "EmoteAnimation" && imageFormat == "AnimationManifest")
			{
				thumbnailType = "AnimatedEmoteAnimation";
			}
			ThumbnailHashResult thumbnailHashResult = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(assetHashId, thumbnailType, width, height, imageFormat, universeId);
			return ThumbResult.Create(width, height, imageFormat, thumbnailHashResult, base.DomainFactories);
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error($"ERROR in Thumbnail service for AssetHashId: {assetHashId}");
			base.DomainFactories.Logger.Error(e);
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, imageFormat);
		}
	}

	private long? GetMediaAssetID(IAsset asset, bool returnAutoGenerated, out bool unavailable)
	{
		unavailable = false;
		Roblox.Asset currentAsset = asset.CurrentVersion.GetAsset();
		long? mediaAssetID = null;
		if (asset.Type.ID == AssetType.PlaceID)
		{
			PlaceMediaItem mediaItem3 = PlaceMediaManager.GetPlaceMediaItemsByPlaceID(currentAsset.ID).FirstOrDefault((PlaceMediaItem m) => Roblox.Asset.Get(m.MediaAssetID).AssetTypeID == AssetType.ImageID && Roblox.Asset.Get(m.MediaAssetID).IsApproved);
			if (mediaItem3 != null)
			{
				mediaAssetID = mediaItem3.MediaAssetID;
			}
		}
		else if (asset.Type.ID == AssetType.PluginID)
		{
			AssetMediaItem mediaItem2 = AssetMediaManager.GetAssetMediaItemsByAssetID(currentAsset.ID).FirstOrDefault((AssetMediaItem m) => Roblox.Asset.Get(m.MediaAssetID).AssetTypeID == AssetType.ImageID && Roblox.Asset.Get(m.MediaAssetID).IsApproved);
			if (mediaItem2 != null)
			{
				mediaAssetID = mediaItem2.MediaAssetID;
			}
		}
		else if (asset.Type.ID == AssetType.ModelID && Roblox.WebsiteSettings.Properties.Settings.Default.IsDefaultCameraGeneratedModelOnPublishEnabled && !returnAutoGenerated)
		{
			AssetMediaItem mediaItem = AssetMediaManager.GetAssetMediaItemsByAssetID(currentAsset.ID).FirstOrDefault((AssetMediaItem m) => Roblox.Asset.Get(m.MediaAssetID).AssetTypeID == AssetType.ImageID);
			if (mediaItem != null)
			{
				mediaAssetID = mediaItem.MediaAssetID;
			}
			else if (Roblox.WebsiteSettings.Properties.Settings.Default.IsBlockAllModelNonMediaItemsEnabled)
			{
				unavailable = true;
			}
		}
		return mediaAssetID;
	}

	public string GetAssetThumbnailRetryUrl(bool final, long? assetId, int thumbWidth, int thumbHeight, string thumbFormat)
	{
		if (!final)
		{
			return $"/asset-thumbnail/json?assetId={assetId}&width={thumbWidth}&height={thumbHeight}&format={thumbFormat}&ignoreAssetMedia=true";
		}
		return null;
	}

	/// <summary>
	/// Used for displaying Thumbnails that have been explicitly set as part of Curated Games Snapshot
	/// </summary>
	/// <param name="assetHashId"></param>
	/// <param name="imageParameters"></param>
	/// <returns></returns>
	public ThumbResult GetThumbnailUrlByAssetHashIdForSnapshots(long assetHashId, ImageParameters imageParameters)
	{
		int width = imageParameters.Width;
		int height = imageParameters.Height;
		string format = imageParameters.Format.ToString();
		try
		{
			AssetHash assetHash = AssetHash.Get(assetHashId);
			AssetType assetType = AssetType.Get(assetHash.AssetTypeID);
			bool isApproved = assetHash.IsApproved;
			bool isReviewed = assetHash.IsReviewed;
			if (!isApproved && (isReviewed || !assetType.RequiresReview))
			{
				return base.DomainFactories.StaticImages.GetUnapprovedThumbResult(width, height, format);
			}
			if (!isReviewed && assetType.RequiresReview)
			{
				return base.DomainFactories.StaticImages.GetUnreviewedThumbResult(width, height, format);
			}
			string assetTypeValue = assetType.Value;
			if (!_AssetTypeValueToThumbnailTypeValueMap.TryGetValue(assetTypeValue, out var thumbnailType))
			{
				thumbnailType = assetTypeValue;
			}
			ThumbnailHashResult thumbnailHashResult = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(assetHashId, thumbnailType, width, height, format, (long?)null);
			return ThumbResult.Create(width, height, format, thumbnailHashResult, base.DomainFactories);
		}
		catch (Exception e)
		{
			base.DomainFactories.Logger.Error($"ERROR in Thumbnail service for AssetHashId: {assetHashId}");
			base.DomainFactories.Logger.Error(e);
			return base.DomainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
		}
	}

	public ThumbResult GetPlaceThumbIgnoreAssetMedia(IAsset placeAsset, ImageParameters imageParameters, bool overrideModeration)
	{
		return GetThumbnailUrl(placeAsset, imageParameters, overrideModeration, ignoreAssetMediaItems: true);
	}

	public ThumbResult GetDefaultPlaceThumbnail(long placeId, ImageParameters imageParameters)
	{
		if (Roblox.Thumbs.Properties.Settings.Default.ShowFirstGameVersionAsDefaultThumbnailEnabled)
		{
			AssetVersion firstVersion = AssetVersion.Get(placeId, 1);
			long? universeId = base.DomainFactories.UniverseFactory.GetPlaceUniverse(placeId)?.Id;
			return GetThumbnailFromThumbnailsService(firstVersion.AssetHashID, "Place", imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString(), universeId);
		}
		return base.DomainFactories.StaticImages.GetGameMediaItemThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, (int)(placeId % 12 + 1));
	}

	public ThumbResult GetDefaultPlaceGameIcon(long placeId, ImageParameters imageParameters)
	{
		if (Roblox.Thumbs.Properties.Settings.Default.ShowFirstGameVersionAsDefaultThumbnailEnabled)
		{
			AssetVersion firstVersion = AssetVersion.Get(placeId, 1);
			long? universeId = base.DomainFactories.UniverseFactory.GetPlaceUniverse(placeId)?.Id;
			return GetThumbnailFromThumbnailsService(firstVersion.AssetHashID, "Place", imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString(), universeId);
		}
		return base.DomainFactories.StaticImages.GetGameIconThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, (int)(placeId % 12 + 1));
	}
}
