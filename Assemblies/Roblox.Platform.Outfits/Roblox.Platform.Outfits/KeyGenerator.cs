using System.IO;
using System.Net;
using System.Text;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

public class KeyGenerator
{
	protected readonly OutfitDomainFactories _OutfitDomainFactories;

	protected readonly string _ThumbnailKeyBaseUrl;

	public KeyGenerator(OutfitDomainFactories outfitDomainFactories, string thumbnailKeyBaseUrl)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
		_ThumbnailKeyBaseUrl = thumbnailKeyBaseUrl;
	}

	/// <summary>
	/// Used for avatar key generation
	/// </summary>
	/// <param name="generatorInput"></param>
	/// <returns></returns>
	public string GenerateKeyUrl(KeyGeneratorInput generatorInput)
	{
		StringBuilder stringBuilder = new StringBuilder($"{_ThumbnailKeyBaseUrl}/Asset/AvatarAccoutrements.ashx?");
		if (!string.IsNullOrEmpty(generatorInput.AvatarHash))
		{
			stringBuilder.Append($"AvatarHash={generatorInput.AvatarHash}");
		}
		else
		{
			stringBuilder.Append($"BodyColorSetID={generatorInput.BodyColorSetID}");
		}
		generatorInput.AssetIDs.Sort();
		string assetIdsCommaSeparated = string.Join(",", generatorInput.AssetIDs);
		stringBuilder.Append($"&AssetIDs={assetIdsCommaSeparated}");
		if (generatorInput.EquippedGearID.HasValue && generatorInput.EquippedGearID.Value != 0L)
		{
			stringBuilder.Append($"&EquippedGearID={generatorInput.EquippedGearID.Value}");
		}
		if (!string.IsNullOrEmpty(generatorInput.ResolvedAvatarType))
		{
			stringBuilder.Append($"&ResolvedAvatarType={generatorInput.ResolvedAvatarType}");
		}
		if (generatorInput.Height.HasValue)
		{
			stringBuilder.Append($"&Height={generatorInput.Height.Value:0.##}");
		}
		if (generatorInput.Width.HasValue)
		{
			stringBuilder.Append($"&Width={generatorInput.Width.Value:0.##}");
		}
		if (generatorInput.Head.HasValue)
		{
			stringBuilder.Append($"&Head={generatorInput.Head.Value:0.##}");
		}
		if (generatorInput.Depth.HasValue)
		{
			stringBuilder.Append($"&Depth={generatorInput.Depth.Value:0.##}");
		}
		if (_OutfitDomainFactories.Settings.UseThumbnailKeyV2Format)
		{
			if (generatorInput.BodyType.HasValue)
			{
				stringBuilder.Append($"&BodyType={generatorInput.BodyType.Value:0.##}");
			}
			if (generatorInput.Proportion.HasValue)
			{
				stringBuilder.Append($"&Proportion={generatorInput.Proportion.Value:0.##}");
			}
		}
		else
		{
			if (generatorInput.Proportion.HasValue)
			{
				stringBuilder.Append($"&Proportion={generatorInput.Proportion.Value:0.##}");
			}
			if (generatorInput.BodyType.HasValue)
			{
				stringBuilder.Append($"&BodyType={generatorInput.BodyType.Value:0.##}");
			}
		}
		return stringBuilder.ToString();
	}

	/// <summary>
	/// Given the unique key for an outfit or avatar
	/// Tries to upload it to S3, and GetOrCreates an AssetHash with that hash.
	/// </summary>
	/// <param name="keyUrl"></param>
	/// <param name="userId">UserID used to create a new AssetHash if none exists</param>
	/// <returns></returns>
	public IRawContent GenerateAssetHash(string keyUrl, long userId)
	{
		using MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(keyUrl));
		string hash = FilesManager.Singleton.AddFile(ms, DecompressionMethods.None);
		return _OutfitDomainFactories.RawContentFactory.GetOrCreate(AssetType.AvatarID, Roblox.Platform.Assets.CreatorType.User, userId, hash);
	}
}
