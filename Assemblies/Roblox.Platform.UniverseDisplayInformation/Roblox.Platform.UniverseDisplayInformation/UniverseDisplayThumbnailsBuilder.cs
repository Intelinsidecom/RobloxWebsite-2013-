using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Assets.Interface;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.TranslationStorage;
using Roblox.Platform.Universes;
using Roblox.Thumbs;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <inheritdoc />
public class UniverseDisplayThumbnailsBuilder : IUniverseDisplayThumbnailsBuilder
{
	private const string _DeleteNonExistingTranslationStatusDescription = "Deleting universe display information for source language is not allowed";

	private static readonly ImageParameters _ThumbnailParameters = new ImageParameters(768, 432, ImageFormat.Png);

	private readonly IImageFactory _ImageFactory;

	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	private readonly IUploadFloodcheckerFactory _UploadFloodcheckerFactory;

	private readonly IGameLocalizationSettingsAuthority _GameLocalizationSettingsAuthority;

	private readonly ITranslationStorageBuilder _TranslationStorageBuilder;

	private readonly IChangeAgentFactory _ChangeAgentFactory;

	private readonly IImageUtilWrapper _ImageUtilWrapper;

	private readonly ITranslationStorageAccessor _TranslationStorageAccessor;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly IUniverseDisplayThumbnailsUtil _UniverseDisplayThumbnailsUtil;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="imageFactory">The <see cref="T:Roblox.Platform.Assets.IImageFactory" /> Use to create the image asset</param>
	/// <param name="uploadFloodcheckerFactory">The <see cref="T:Roblox.Platform.Assets.Interface.IUploadFloodcheckerFactory" /> Factory to create flood checker</param>
	/// <param name="translationStorageBuilder">The <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageBuilder" /> Tss builder to store localized thumbnail ids</param>
	/// <param name="gameLocalizationSettingsAuthority">The <see cref="T:Roblox.Platform.GameLocalization.IGameLocalizationSettingsAuthority" /> Use to find source language of universe</param>
	/// <param name="assetOwnershipAuthority">The <see cref="T:Roblox.Platform.AssetOwnership.IAssetOwnershipAuthority" /> Use to assign ownership of image asset</param>
	/// <param name="changeAgentFactory">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgentFactory" />.</param>
	/// <param name="coreLocalizationAccessor">The <see cref="T:Roblox.Platform.Localization.Core.ICoreLocalizationAccessor" />.</param>
	/// <param name="translationStorageAccessor"> The <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" /> Use to read stored thumbnail ids for a universe </param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null argument.</exception>
	public UniverseDisplayThumbnailsBuilder(IImageFactory imageFactory, IUploadFloodcheckerFactory uploadFloodcheckerFactory, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, ITranslationStorageBuilder translationStorageBuilder, IAssetOwnershipAuthority assetOwnershipAuthority, IChangeAgentFactory changeAgentFactory, ICoreLocalizationAccessor coreLocalizationAccessor, ITranslationStorageAccessor translationStorageAccessor)
		: this(imageFactory, uploadFloodcheckerFactory, gameLocalizationSettingsAuthority, translationStorageBuilder, assetOwnershipAuthority, changeAgentFactory, coreLocalizationAccessor, translationStorageAccessor, new ImageUtilWrapper(), new UniverseDisplayThumbnailsUtil())
	{
	}

	internal UniverseDisplayThumbnailsBuilder(IImageFactory imageFactory, IUploadFloodcheckerFactory uploadFloodcheckerFactory, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, ITranslationStorageBuilder translationStorageBuilder, IAssetOwnershipAuthority assetOwnershipAuthority, IChangeAgentFactory changeAgentFactory, ICoreLocalizationAccessor coreLocalizationAccessor, ITranslationStorageAccessor translationStorageAccessor, IImageUtilWrapper imageUtilWrapper, IUniverseDisplayThumbnailsUtil universeDisplayThumbnailsUtil)
	{
		_ImageFactory = imageFactory ?? throw new PlatformArgumentNullException("imageFactory");
		_UploadFloodcheckerFactory = uploadFloodcheckerFactory ?? throw new PlatformArgumentNullException("uploadFloodcheckerFactory");
		_GameLocalizationSettingsAuthority = gameLocalizationSettingsAuthority ?? throw new PlatformArgumentNullException("gameLocalizationSettingsAuthority");
		_TranslationStorageBuilder = translationStorageBuilder ?? throw new PlatformArgumentNullException("translationStorageBuilder");
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new PlatformArgumentNullException("assetOwnershipAuthority");
		_ChangeAgentFactory = changeAgentFactory ?? throw new PlatformArgumentNullException("changeAgentFactory");
		_TranslationStorageAccessor = translationStorageAccessor ?? throw new PlatformArgumentNullException("translationStorageAccessor");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_ImageUtilWrapper = imageUtilWrapper ?? throw new PlatformArgumentNullException("imageUtilWrapper");
		_UniverseDisplayThumbnailsUtil = universeDisplayThumbnailsUtil ?? throw new PlatformArgumentNullException("universeDisplayThumbnailsUtil");
	}

	/// <inheritdoc />
	public long AddDisplayThumbnail(IUniverse universe, ILanguageFamily languageFamily, Stream imageData, IUser actor)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		if (imageData == null)
		{
			throw new PlatformArgumentNullException("imageData");
		}
		if (actor == null)
		{
			throw new PlatformArgumentNullException("actor");
		}
		if (SameAsSourceLanguage(universe, languageFamily))
		{
			throw new PlatformInvalidOperationException("Setting universe display thumbnail for source language is not allowed");
		}
		string thumbnailIds = _TranslationStorageAccessor.GetTranslation(languageFamily, ContentSourceType.UniverseDisplayThumbnailsMapping, ContentVariantType.Production, universe.Id.ToString());
		long imageId = SaveImageStreamAsAsset(universe, languageFamily, imageData, actor);
		thumbnailIds = _UniverseDisplayThumbnailsUtil.AppendImageId(thumbnailIds, imageId);
		_TranslationStorageBuilder.CreateOrUpdateTranslation(languageFamily, ContentSourceType.UniverseDisplayThumbnailsMapping, ContentVariantType.Production, universe.Id.ToString(), thumbnailIds, isSourceContentVariantAndLocale: false, SafeGetChangeAgentFromUser(actor));
		return imageId;
	}

	/// <inheritdoc />
	public void DeleteDisplayThumbnail(IUniverse universe, long imageId, ILanguageFamily languageFamily, IUser actor)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		if (actor == null)
		{
			throw new PlatformArgumentNullException("actor");
		}
		if (SameAsSourceLanguage(universe, languageFamily))
		{
			throw new PlatformInvalidOperationException("Deleting universe display thumbnail for source language is not allowed");
		}
		string thumbnailIds = _TranslationStorageAccessor.GetTranslation(languageFamily, ContentSourceType.UniverseDisplayThumbnailsMapping, ContentVariantType.Production, universe.Id.ToString());
		string updatedThumbnailIds = _UniverseDisplayThumbnailsUtil.DeleteImageId(thumbnailIds, imageId);
		if (string.Equals(thumbnailIds, updatedThumbnailIds))
		{
			return;
		}
		try
		{
			if (string.IsNullOrEmpty(updatedThumbnailIds))
			{
				_TranslationStorageBuilder.DeleteTranslation(languageFamily, ContentSourceType.UniverseDisplayThumbnailsMapping, ContentVariantType.Production, universe.Id.ToString(), SafeGetChangeAgentFromUser(actor));
			}
			else
			{
				_TranslationStorageBuilder.UpdateTranslation(languageFamily, ContentSourceType.UniverseDisplayThumbnailsMapping, ContentVariantType.Production, universe.Id.ToString(), updatedThumbnailIds, SafeGetChangeAgentFromUser(actor));
			}
		}
		catch (PlatformOperationUnavailableException ex) when (ex.InnerException is ApiClientException)
		{
			if (((ApiClientException)ex.InnerException).StatusDescription != "Deleting universe display information for source language is not allowed")
			{
				throw;
			}
		}
	}

	/// <inheritdoc />
	public void OrderDisplayThumbnails(IUniverse universe, IList<long> imageIds, ILanguageFamily languageFamily, IUser actor)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (imageIds == null)
		{
			throw new PlatformArgumentNullException("imageIds");
		}
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		if (actor == null)
		{
			throw new PlatformArgumentNullException("actor");
		}
		if (SameAsSourceLanguage(universe, languageFamily))
		{
			throw new PlatformInvalidOperationException("Reorder universe display thumbnail for source language is not allowed");
		}
		string originalSerializedImageIds = _TranslationStorageAccessor.GetTranslation(languageFamily, ContentSourceType.UniverseDisplayThumbnailsMapping, ContentVariantType.Production, universe.Id.ToString());
		IReadOnlyList<long> originalImageIds = _UniverseDisplayThumbnailsUtil.Deserialize(originalSerializedImageIds);
		HashSet<long> originalImageIdsDictionary = new HashSet<long>(originalImageIds);
		HashSet<long> finalImageIdsSet = new HashSet<long>();
		List<long> finalImageIds = new List<long>();
		imageIds.Distinct().ToList().ForEach(delegate(long id)
		{
			if (originalImageIdsDictionary.Contains(id))
			{
				finalImageIds.Add(id);
				finalImageIdsSet.Add(id);
			}
		});
		originalImageIds.ToList().ForEach(delegate(long id)
		{
			if (!finalImageIdsSet.Contains(id))
			{
				finalImageIds.Add(id);
				finalImageIdsSet.Add(id);
			}
		});
		if (!string.Equals(_UniverseDisplayThumbnailsUtil.Serialize(finalImageIds), originalSerializedImageIds))
		{
			_TranslationStorageBuilder.UpdateTranslation(languageFamily, ContentSourceType.UniverseDisplayThumbnailsMapping, ContentVariantType.Production, universe.Id.ToString(), _UniverseDisplayThumbnailsUtil.Serialize(finalImageIds), SafeGetChangeAgentFromUser(actor));
		}
	}

	private bool SameAsSourceLanguage(IUniverse universe, ILanguageFamily languageFamily)
	{
		ILanguageFamily sourceLanguage = _GameLocalizationSettingsAuthority.GetSourceLanguageFamily(universe);
		if (languageFamily != null && sourceLanguage != null)
		{
			return sourceLanguage.Id == languageFamily.Id;
		}
		return false;
	}

	private long SaveImageStreamAsAsset(IUniverse universe, ILanguageFamily languageFamily, Stream imageData, IUser actor)
	{
		IRetryAfterFloodChecker imageUploadFloodchecker = _UploadFloodcheckerFactory.GetImageUploadFloodchecker(actor);
		if (imageUploadFloodchecker.IsFlooded())
		{
			throw new PlatformFloodedException("Too many place thumbnail upload requests");
		}
		imageUploadFloodchecker.UpdateCount();
		AssetCreatorInfo assetCreatorInfo = new AssetCreatorInfo(Roblox.Platform.Assets.CreatorType.User, actor.Id);
		TrustedAssetTextInfo assetNameAndDescription = new TrustedAssetTextInfo($"{universe.Name}_Thumbnail", languageFamily.LanguageCode);
		Stream resampledTexture;
		try
		{
			resampledTexture = _ImageUtilWrapper.ResampleTextureEnforceDesiredSizeWithPadding(imageData, _ThumbnailParameters.Width, _ThumbnailParameters.Height);
		}
		catch (ArgumentException)
		{
			throw new InvalidDataException("The provided image data stream is in an invalid format");
		}
		IImage image;
		using (resampledTexture)
		{
			StreamCreatorInfo streamCreatorInfo = new StreamCreatorInfo(resampledTexture);
			ISupportedLocale locale = _CoreLocalizationAccessor.GetDefaultSupportedLocaleFromLanguage(languageFamily);
			image = _ImageFactory.CreateWithTrustedAssetText(assetNameAndDescription, assetCreatorInfo, streamCreatorInfo, actor, locale?.LocaleCode);
		}
		_AssetOwnershipAuthority.AwardAsset(image.Id, actor.Id);
		return image.Id;
	}

	private IChangeAgent SafeGetChangeAgentFromUser(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		return _ChangeAgentFactory.GetChangeAgentForUser(user);
	}
}
