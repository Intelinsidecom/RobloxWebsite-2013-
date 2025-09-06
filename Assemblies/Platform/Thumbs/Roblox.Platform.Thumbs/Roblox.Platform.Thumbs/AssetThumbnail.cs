using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using Roblox.Configuration;
using Roblox.Platform.Assets;
using Roblox.Platform.Badges;
using Roblox.Platform.Core;
using Roblox.Platform.Universes;
using Roblox.Platform.Thumbnails.Client;
using Roblox.Platform.Thumbs.Properties;
using Roblox.WebsiteSettings.Properties;
namespace Roblox.Platform.Thumbs
{
    class AssetThumbnail : DomainObjectBase<ThumbnailDomainFactories>, IAssetThumbnail

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
		Roblox.Platform.Thumbs.Properties.Settings.Default.ReadValueAndMonitorChanges((Roblox.Platform.Thumbs.Properties.Settings s) => s.ThreeDeeThumbsSupportedAssetTypeValuesCSV, delegate(string value)
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
		Roblox.Platform.Thumbs.Properties.Settings.Default.ReadValueAndMonitorChanges((Roblox.Platform.Thumbs.Properties.Settings s) => s.AnimatedAvatarAnimationSupportedAssetTypeValuesCSV, delegate(string value)
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
		Roblox.Platform.Thumbs.Properties.Settings.Default.ReadValueAndMonitorChanges((Roblox.Platform.Thumbs.Properties.Settings s) => s.IsFaceAssetThumbnailedAsFaceInsteadOfDecal, delegate(bool value)
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

        public bool IsSupportedAnimatedAssetType(int assetTypeId)
        {
            return _SupportedAnimatedAssetTypeIds.Contains(assetTypeId);
        }

        public bool IsSupported3DAssetType(int assetTypeId)
        {
            return _Supported3DAssetTypeIds != null && _Supported3DAssetTypeIds.Contains(assetTypeId);
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

        public ThumbResult GetModerationAgnostic3DThumbnailUrlForAssetHash(long assetHashId)
        {
            try
            {
                return GetThumbnailFromThumbnailsService(assetHashId, ThumbnailConstants.ObjFormat, ThumbnailConstants.ObjImageParameters.Width, ThumbnailConstants.ObjImageParameters.Height, ThumbnailConstants.ObjFormat, null);
            }
            catch
            {
                return base.DomainFactories.StaticImages.GetUnavailableThumbResult(ThumbnailConstants.ObjImageParameters.Width, ThumbnailConstants.ObjImageParameters.Height, ThumbnailConstants.ObjFormat);
            }
        }

        public ThumbResult GetModerationAgnosticThumbnailUrlForAssetHash(long assetHashId, ImageParameters imageParameters)
        {
            try
            {
                var result = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(assetHashId, "Image", imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString(), null);
                return ThumbResult.Create(imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString(), result, base.DomainFactories);
            }
            catch
            {
                return base.DomainFactories.StaticImages.GetUnavailableThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension);
            }
        }

        public ThumbResult GetAsset3DThumbnailUrl(long assetId, string imageFormat = "Obj")
        {
            try
            {
                var asset = Roblox.Asset.Get(assetId);
                if (asset == null)
                {
                    return GetInvalid3DThumbResult(false);
                }
                return GetThumbnailFromThumbnailsService(asset.AssetHashID, asset.Type.Value, 1, 1, imageFormat, null);
            }
            catch
            {
                return GetInvalid3DThumbResult(false);
            }
        }

        public ThumbResult GetAssetAnimatedThumbnailUrl(long assetId)
        {
            return GetInvalidAnimatedThumbResult(false);
        }

        public ThumbResult GetThumbnailUrl(IAsset asset, ImageParameters imageParameters)
        {
            return GetThumbnailUrl(asset, imageParameters, overrideModeration: false);
        }

        public ThumbResult GetGameIconThumbnailUrl(IAsset asset, ImageParameters imageParameters)
        {
            return base.DomainFactories.StaticImages.GetGameIconThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, 1);
        }

        public bool TryThumbnailSubstitution(IAsset asset, out ThumbResult thumbResult, ref IAsset substituteAsset, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
        {
            thumbResult = null;
            return false;
        }

        /// <inheritdoc cref="M:Roblox.Platform.Thumbs.IAssetThumbnail.GetThumbnailUrl(Roblox.Platform.Assets.IAsset,Roblox.Platform.Thumbs.ImageParameters)" />
        public ThumbResult GetThumbnailUrl(Roblox.Platform.Assets.IAsset asset, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
        {
            return GetThumbnailUrl(Roblox.Asset.Get(asset.Id), imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon);
        }

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
                if (asset is Roblox.Asset rAsset && asset.Type.ID == AssetType.PlaceID)
                {
                    IUniverse universe = base.DomainFactories.UniverseFactory.GetPlaceUniverse(rAsset.ID);
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

        public ThumbResult[] MultiGetThumbnailUrl(IAsset[] assets, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems = false, bool returnAutoGenerated = false, bool returnGameIcon = false)
        {
            if (assets == null) throw new ArgumentNullException("assets");
            var results = new List<ThumbResult>(assets.Length);
            foreach (var a in assets)
            {
                results.Add(GetThumbnailUrl(a, imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon));
            }
            return results.ToArray();
        }

        // Explicit implementation to satisfy any fully-qualified interface overload
        ThumbResult[] Roblox.Platform.Thumbs.IAssetThumbnail.MultiGetThumbnailUrl(Roblox.Platform.Assets.IAsset[] assets, ImageParameters imageParameters, bool overrideModeration, bool ignoreAssetMediaItems, bool returnAutoGenerated, bool returnGameIcon)
        {
            if (assets == null) throw new ArgumentNullException("assets");
            var results = new List<ThumbResult>(assets.Length);
            foreach (var a in assets)
            {
                results.Add(GetThumbnailUrl(a, imageParameters, overrideModeration, ignoreAssetMediaItems, returnAutoGenerated, returnGameIcon));
            }
            return results.ToArray();
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
            if (!moderationOverride && Roblox.Platform.Thumbs.Properties.Settings.Default.ArchivedAssetThumbnailBlockingEnabled && asset.IsArchived == true)
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
            // AssetMedia dependency was removed to avoid a circular project reference. For now,
            // conservatively indicate no media asset so callers fall back to defaults when needed.
            // If needed later, this can be re-wired via an injected abstraction.
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
            if (Roblox.Platform.Thumbs.Properties.Settings.Default.ShowFirstGameVersionAsDefaultThumbnailEnabled)
            {
                AssetVersion firstVersion = AssetVersion.Get(placeId, 1);
                long? universeId = base.DomainFactories.UniverseFactory.GetPlaceUniverse(placeId)?.Id;
                return GetThumbnailFromThumbnailsService(firstVersion.AssetHashID, "Place", imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString(), universeId);
            }
            return base.DomainFactories.StaticImages.GetGameMediaItemThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, (int)(placeId % 12 + 1));
        }

        public ThumbResult GetDefaultPlaceGameIcon(long placeId, ImageParameters imageParameters)
        {
            if (Roblox.Platform.Thumbs.Properties.Settings.Default.ShowFirstGameVersionAsDefaultThumbnailEnabled)
            {
                AssetVersion firstVersion = AssetVersion.Get(placeId, 1);
                long? universeId = base.DomainFactories.UniverseFactory.GetPlaceUniverse(placeId)?.Id;
                return GetThumbnailFromThumbnailsService(firstVersion.AssetHashID, "Place", imageParameters.Width, imageParameters.Height, imageParameters.Format.ToString(), universeId);
            }
            return base.DomainFactories.StaticImages.GetGameIconThumbResult(imageParameters.Width, imageParameters.Height, imageParameters.FileExtension, (int)(placeId % 12 + 1));
        }
    }
}
