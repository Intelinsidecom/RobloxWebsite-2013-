using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

/// <summary>
/// When we want to thumbnail a UserAvatar, we generate a string that represents that unique appearance
/// We upload that string as a file to S3, and get an AssetHash back
/// We then update the UserAvatar.NewAvatarAssetHashID to the ID of that AssetHash
/// When the thumbnailer wants to render that avatar, it downloads that AssetHash and parses the string to extract the data
/// The thumbnailer also treats this as a unique key for the avatar thumbnail
/// Outfits have a similar key system, see <see cref="T:Roblox.Platform.Outfits.OutfitKeyGenerator" />
/// </summary>
public class AvatarKeyGenerator : KeyGenerator
{
	private AvatarPlaceSettingsResolver _AvatarPlaceSettingsResolver { get; }

	private new OutfitDomainFactories _OutfitDomainFactories { get; }

	public AvatarKeyGenerator(OutfitDomainFactories outfitDomainFactories, string thumbnailKeyBaseUrl, ILogger logger)
		: base(outfitDomainFactories, thumbnailKeyBaseUrl)
	{
		_AvatarPlaceSettingsResolver = new AvatarPlaceSettingsResolver(logger);
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
	}

	/// <summary>
	/// Generate the input that is turned into a URL which will be stored as the assetHash of the userAvatar
	/// userAvatarAvatarHash is actually the bodycolors CDN hash
	/// </summary>
	/// <remarks>
	/// Why does this URL have all the assetIds inline, and doesn't just send the userId and placeID
	/// the way avatar-fetch does?  Because caching of (hash of all worn items as URL) =&gt; thumb happens early;
	/// if we instead just cached userId, there might be a mismatch and the user would not be wearing what they ought to.
	/// With game join, this is much more tolerable (gaps between what you're wearing when you click play
	/// and when you get in the game due to fast clicking are okay).
	///
	/// This URL is put into the CDN and saved; then later thumbnail coordination service reads it and sends it to the 
	/// RCC thumbnailer. That service rewrites it to an apiproxy request to /avatar-fetch-thumbnail
	/// </remarks>
	internal string ComputeKey(IAvatar avatar, bool checkIfDefaultClothingNeeded = true)
	{
		KeyGeneratorInput input = new KeyGeneratorInput();
		IReadOnlyCollection<IWornAsset> wornAssets = avatar.GetWornAssets(checkIfDefaultClothingNeeded);
		foreach (IWornAsset wornAsset in wornAssets)
		{
			if (wornAsset.IsEquippedGear)
			{
				input.EquippedGearID = wornAsset.AssetId;
			}
		}
		input.AssetIDs = wornAssets.Select((IWornAsset a) => a.AssetId).ToList();
		long? bodyColorSetId = avatar.GetBodyColorSetId();
		if (bodyColorSetId.HasValue)
		{
			string bodyColorsHash = _OutfitDomainFactories.BodyColorSetFactory.GetById(bodyColorSetId.Value)?.BodyColorSetHash;
			if (string.IsNullOrEmpty(bodyColorsHash))
			{
				input.BodyColorSetID = bodyColorSetId;
			}
			else
			{
				input.AvatarHash = bodyColorsHash;
			}
			ResolvedAvatarTypeEnum resolvedAvatarType = AvatarPlaceSettingsResolver.ConvertToResolvedAvatarType(avatar.GetPlayerAvatarType());
			if (resolvedAvatarType != ResolvedAvatarTypeEnum.R6)
			{
				input.ResolvedAvatarType = resolvedAvatarType.ToString();
				IAvatarScale scale = avatar.GetScale();
				if (!scale.IsDefault)
				{
					input.Height = scale.Height;
					input.Width = scale.Width;
					input.Head = scale.Head;
					input.Depth = scale.Depth;
					if (scale.Proportion != ScaleRules.Proportion.Default)
					{
						input.Proportion = scale.Proportion;
					}
					if (scale.BodyType != ScaleRules.BodyType.Default)
					{
						input.BodyType = scale.BodyType;
					}
				}
			}
			return GenerateKeyUrl(input);
		}
		throw new PlatformDataIntegrityException($"UserAvatar for User ID {avatar.UserId} has a null BodyColorSetID and empty AvatarHash even after getting body colors.");
	}

	public IRawContent GenerateAssetHash(IAvatar avatar, bool checkIfDefaultClothing = true)
	{
		string key = ComputeKey(avatar, checkIfDefaultClothing);
		return GenerateAssetHash(key, avatar.UserId);
	}
}
