using System.Collections.Generic;
using Roblox.Platform.Assets;

namespace Roblox.Platform.Outfits;

/// <summary>
/// When an user creates an outfit out of their combination of assets, we generate a string that represents that unique appearance
/// We upload that string as a file to S3, and get an AssetHash back
/// We then use that AssetHash's ID as a unique ID for that particular outfit
/// When the thumbnailer wants to render an outfit, it downloads that AssetHash and parses the string to extract the data
/// The thumbnailer also treats this as a unique key for the thumbnail
/// </summary>
public class OutfitKeyGenerator : KeyGenerator
{
	public OutfitKeyGenerator(OutfitDomainFactories outfitDomainFactories, string thumbnailKeyBaseUrl)
		: base(outfitDomainFactories, thumbnailKeyBaseUrl)
	{
	}

	/// <summary>
	/// Computes the string used to uniquely identify an outfit
	/// </summary>
	/// <param name="assetIds"></param>
	/// <param name="bodyColorSetId"></param>
	/// <param name="scaleId"></param>
	/// <param name="playerAvatarTypeId"></param>
	/// <returns></returns>
	internal string ComputeKey(List<long> assetIds, long bodyColorSetId, int scaleId, byte playerAvatarTypeId)
	{
		KeyGeneratorInput input = new KeyGeneratorInput();
		assetIds.Sort();
		foreach (long assetId in assetIds)
		{
			if (_OutfitDomainFactories.AssetFactory.GetAsset(assetId).TypeId == Roblox.Platform.Assets.AssetType.Gear.ToId(_OutfitDomainFactories.AssetTypeFactory))
			{
				input.EquippedGearID = assetId;
			}
		}
		input.AssetIDs = assetIds;
		string bodyColorSetHash = _OutfitDomainFactories.BodyColorSetFactory.GetById(bodyColorSetId).BodyColorSetHash;
		if (string.IsNullOrEmpty(bodyColorSetHash))
		{
			input.BodyColorSetID = bodyColorSetId;
		}
		else
		{
			input.AvatarHash = bodyColorSetHash;
		}
		PlayerAvatarType playerAvatarType = (PlayerAvatarType)playerAvatarTypeId;
		if (playerAvatarType != PlayerAvatarType.R6)
		{
			IScaleEntity scale = _OutfitDomainFactories.ScaleEntityFactory.Get(scaleId);
			input.ResolvedAvatarType = playerAvatarType.ToString();
			if (scale != null && !ScaleRules.IsDefault(scale.Height, scale.Width, scale.Head, scale.Proportion, scale.BodyType))
			{
				input.Height = scale.Height;
				input.Width = scale.Width;
				input.Head = scale.Head;
				input.Depth = ScaleRules.Depth.CalculateDepth(scale.Width);
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

	public virtual IRawContent GenerateAssetHash(List<long> assetIds, long bodyColorSetId, int scaleId, byte playerAvatarTypeId, long userId)
	{
		string key = ComputeKey(assetIds, bodyColorSetId, scaleId, playerAvatarTypeId);
		return GenerateAssetHash(key, userId);
	}
}
