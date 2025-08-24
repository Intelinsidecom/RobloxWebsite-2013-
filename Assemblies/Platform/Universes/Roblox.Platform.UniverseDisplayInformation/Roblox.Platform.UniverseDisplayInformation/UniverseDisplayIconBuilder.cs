using System;
using System.Drawing.Imaging;
using System.IO;
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
public class UniverseDisplayIconBuilder : IUniverseDisplayIconBuilder
{
	private const string _DeleteNonExistingTranslationStatusDescription = "Deleting universe display information for source language is not allowed";

	private static readonly ImageParameters _IconParameters = new ImageParameters(512, 512, ImageFormat.Png);

	private readonly IImageFactory _ImageFactory;

	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	private readonly IUploadFloodcheckerFactory _UploadFloodcheckerFactory;

	private readonly IGameLocalizationSettingsAuthority _GameLocalizationSettingsAuthority;

	private readonly ITranslationStorageBuilder _TranslationStorageBuilder;

	private readonly IChangeAgentFactory _ChangeAgentFactory;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly IImageUtilWrapper _ImageUtilWrapper;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="imageFactory">The <see cref="T:Roblox.Platform.Assets.IImageFactory" /> Use to create the image asset</param>
	/// <param name="uploadFloodcheckerFactory">The <see cref="T:Roblox.Platform.Assets.Interface.IUploadFloodcheckerFactory" /> Factory to create flood checker</param>
	/// <param name="translationStorageBuilder">The <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageBuilder" /> Tss builder to store localized icon id</param>
	/// <param name="gameLocalizationSettingsAuthority">The <see cref="T:Roblox.Platform.GameLocalization.IGameLocalizationSettingsAuthority" /> Use to find source language of universe</param>
	/// <param name="assetOwnershipAuthority">The <see cref="T:Roblox.Platform.AssetOwnership.IAssetOwnershipAuthority" /> Use to assign ownership of image asset</param>
	/// <param name="coreLocalizationAccessor">The <see cref="T:Roblox.Platform.Localization.Core.ICoreLocalizationAccessor" />.</param>
	/// <param name="changeAgentFactory">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgentFactory" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null argument.</exception>
	public UniverseDisplayIconBuilder(IImageFactory imageFactory, IUploadFloodcheckerFactory uploadFloodcheckerFactory, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, ITranslationStorageBuilder translationStorageBuilder, IAssetOwnershipAuthority assetOwnershipAuthority, ICoreLocalizationAccessor coreLocalizationAccessor, IChangeAgentFactory changeAgentFactory)
		: this(imageFactory, uploadFloodcheckerFactory, gameLocalizationSettingsAuthority, translationStorageBuilder, assetOwnershipAuthority, coreLocalizationAccessor, changeAgentFactory, new ImageUtilWrapper())
	{
	}

	internal UniverseDisplayIconBuilder(IImageFactory imageFactory, IUploadFloodcheckerFactory uploadFloodcheckerFactory, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, ITranslationStorageBuilder translationStorageBuilder, IAssetOwnershipAuthority assetOwnershipAuthority, ICoreLocalizationAccessor coreLocalizationAccessor, IChangeAgentFactory changeAgentFactory, IImageUtilWrapper imageUtilWrapper)
	{
		_ImageFactory = imageFactory ?? throw new PlatformArgumentNullException("imageFactory");
		_UploadFloodcheckerFactory = uploadFloodcheckerFactory ?? throw new PlatformArgumentNullException("uploadFloodcheckerFactory");
		_GameLocalizationSettingsAuthority = gameLocalizationSettingsAuthority ?? throw new PlatformArgumentNullException("gameLocalizationSettingsAuthority");
		_TranslationStorageBuilder = translationStorageBuilder ?? throw new PlatformArgumentNullException("translationStorageBuilder");
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new PlatformArgumentNullException("assetOwnershipAuthority");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_ChangeAgentFactory = changeAgentFactory ?? throw new PlatformArgumentNullException("changeAgentFactory");
		_ImageUtilWrapper = imageUtilWrapper ?? throw new PlatformArgumentNullException("imageUtilWrapper");
	}

	/// <inheritdoc />
	public void SetDisplayIcon(IUniverse universe, ILanguageFamily languageFamily, Stream imageData, IUser actor)
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
			throw new PlatformInvalidOperationException("Setting universe display icon for source language is not allowed");
		}
		long imageId = SaveImageStreamAsAsset(universe, languageFamily, imageData, actor);
		_TranslationStorageBuilder.CreateOrUpdateTranslation(languageFamily, ContentSourceType.UniverseDisplayIconMapping, ContentVariantType.Production, universe.Id.ToString(), imageId.ToString(), isSourceContentVariantAndLocale: false, SafeGetChangeAgentFromUser(actor));
	}

	/// <inheritdoc />
	public void DeleteDisplayIcon(IUniverse universe, ILanguageFamily languageFamily, IUser actor)
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
			throw new PlatformInvalidOperationException("Deleting universe display icon for source language is not allowed");
		}
		try
		{
			_TranslationStorageBuilder.DeleteTranslation(languageFamily, ContentSourceType.UniverseDisplayIconMapping, ContentVariantType.Production, universe.Id.ToString(), SafeGetChangeAgentFromUser(actor));
		}
		catch (PlatformOperationUnavailableException ex) when (ex.InnerException is ApiClientException)
		{
			if (((ApiClientException)ex.InnerException).StatusDescription != "Deleting universe display information for source language is not allowed")
			{
				throw;
			}
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
			throw new PlatformFloodedException("Too many place icon upload requests");
		}
		imageUploadFloodchecker.UpdateCount();
		AssetCreatorInfo assetCreatorInfo = new AssetCreatorInfo(Roblox.Platform.Assets.CreatorType.User, actor.Id);
		TrustedAssetTextInfo assetNameAndDescription = new TrustedAssetTextInfo($"{universe.Name}_Icon", languageFamily.LanguageCode);
		Stream resampledTexture;
		try
		{
			resampledTexture = _ImageUtilWrapper.ResampleTextureEnforceDesiredSizeWithPadding(imageData, _IconParameters.Width, _IconParameters.Height);
		}
		catch (ArgumentException)
		{
			throw new InvalidDataException("The provided image data stream is in an invalid format");
		}
		IImage image;
		using (resampledTexture)
		{
			ISupportedLocale supportedLocale = _CoreLocalizationAccessor.GetDefaultSupportedLocaleFromLanguage(languageFamily);
			StreamCreatorInfo streamCreatorInfo = new StreamCreatorInfo(resampledTexture);
			image = _ImageFactory.CreateWithTrustedAssetText(assetNameAndDescription, assetCreatorInfo, streamCreatorInfo, actor, supportedLocale?.LocaleCode);
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
