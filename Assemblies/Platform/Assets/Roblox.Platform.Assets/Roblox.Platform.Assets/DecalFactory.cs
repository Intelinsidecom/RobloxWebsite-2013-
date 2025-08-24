using System;
using System.Drawing;
using System.IO;
using System.Xml;
using Roblox.Assets.Client;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class DecalFactory : AssetFactoryBase<IDecal>
{
	protected override int AssetTypeId => Roblox.AssetType.DecalID;

	public static int MaxEdgeSize => Settings.Default.DecalMaxEdgeSize;

	internal DecalFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	private IRawContent CreateRawContent(CreatorType creatorType, long creatorTargetId, IImage image)
	{
		string imageUrl = $"{base.AssetUrl}?id={image.Id}";
		XmlDocument item = new XmlDocument();
		using (MemoryStream defaultDecalStream = new MemoryStream(RobloxContentUtilities.DefaultDecal, writable: false))
		{
			item.Load(defaultDecalStream);
		}
		GetTextureNode(item).InnerXml = $"<url>{imageUrl}</url>";
		using MemoryStream itemStream = new MemoryStream();
		item.Save(itemStream);
		itemStream.Seek(0L, SeekOrigin.Begin);
		return base.DomainFactories.RawContentFactory.GetOrCreate(AssetTypeId, creatorType, creatorTargetId, itemStream);
	}

	protected override IDecal BuildChildAsset(IAsset genericAsset)
	{
		return new Decal(base.DomainFactories, genericAsset);
	}

	internal IDecal GetDecal(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	public IDecal CreateDecal(AssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IImage image, IUserIdentifier actorUserIdentity)
	{
		IRawContent rawContent = CreateRawContent(assetCreatorInfo.CreatorType, assetCreatorInfo.CreatorTargetId, image);
		return CreateWithDependency(assetNameAndDescription, assetCreatorInfo, rawContent, actorUserIdentity, image, (AssetType)12);
	}

	private static System.Drawing.Image GetImage(XmlDocument fileXml)
	{
		Roblox.IAsset asset = GetImageAsset(fileXml);
		using MemoryStream memoryStream = FilesManager.Singleton.GetStream(asset.Hash);
		return System.Drawing.Image.FromStream(memoryStream);
	}

	private static System.Drawing.Image GetImage(Roblox.AssetVersion decal)
	{
		Roblox.IAsset asset = GetImageAsset(decal);
		using MemoryStream memoryStream = FilesManager.Singleton.GetStream(asset.Hash);
		return System.Drawing.Image.FromStream(memoryStream);
	}

	private static Roblox.IAsset GetImageAsset(XmlDocument fileXml)
	{
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(GetImageUri(fileXml), throwIfBadUrl: true);
	}

	private static Roblox.IAsset GetImageAsset(Roblox.AssetVersion decal)
	{
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(GetImageUri(decal), throwIfBadUrl: true);
	}

	private static AssetReference GetImageAssetReference(XmlDocument fileXml)
	{
		return QueryStringAssetParameterParser.ParseAssetReferenceFromQuerystring(GetImageUri(fileXml), throwIfBadUrl: true);
	}

	private static AssetReference GetImageAssetReference(Roblox.AssetVersion decal)
	{
		return QueryStringAssetParameterParser.ParseAssetReferenceFromQuerystring(GetImageUri(decal), throwIfBadUrl: true);
	}

	private static Uri GetImageUri(XmlDocument fileXml)
	{
		XmlNode node = GetTextureNode(fileXml);
		if (node != null && node.HasChildNodes)
		{
			node = node.ChildNodes[0];
			if (node.Name == "url")
			{
				return new Uri(node.InnerText);
			}
		}
		return null;
	}

	private static Uri GetImageUri(Roblox.AssetVersion decal)
	{
		return GetImageUri(FilesManager.Singleton.GetFileXml(decal.Hash));
	}

	private static XmlNode GetNode(XmlDocument fileXml)
	{
		foreach (XmlNode node in fileXml.ChildNodes)
		{
			if (!(node.Name == "roblox"))
			{
				continue;
			}
			foreach (XmlNode item in node.ChildNodes)
			{
				if (item.Name == "Item" && item.Attributes["class"].Value == "Decal")
				{
					return item;
				}
			}
		}
		return null;
	}

	private static XmlNode GetTextureNode(XmlDocument fileXml)
	{
		XmlNode node = GetNode(fileXml);
		if (node != null)
		{
			foreach (XmlNode props in node.ChildNodes)
			{
				if (!(props.Name == "Properties"))
				{
					continue;
				}
				foreach (XmlNode prop in props.ChildNodes)
				{
					if (prop.Attributes["name"].Value == "Texture")
					{
						return prop;
					}
				}
			}
		}
		return null;
	}

	private static bool IsDecal(Roblox.AssetVersion assetVersion)
	{
		return assetVersion.AssetTypeID == Roblox.AssetType.DecalID;
	}

	public static Stream ResampleTexture(Stream texture, Func<Stream, int, Stream> resample)
	{
		return resample(texture, Settings.Default.DecalMaxEdgeSize);
	}
}
