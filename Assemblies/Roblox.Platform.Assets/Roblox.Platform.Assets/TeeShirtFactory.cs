using System;
using System.Drawing;
using System.IO;
using System.Xml;
using Roblox.Assets.Client;
using Roblox.Drawing;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class TeeShirtFactory : AssetFactoryBase<ITeeShirt>
{
	protected override int AssetTypeId => Roblox.AssetType.TeeShirtID;

	internal TeeShirtFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	private IRawContent CreateRawContent(CreatorType creatorType, long creatorTargetId, IImage image)
	{
		string imageUrl = $"{base.AssetUrl}?id={image.Id}";
		XmlDocument garment = new XmlDocument();
		using (MemoryStream defaultGarmentStream = new MemoryStream(UserAvatar.DefaultTeeShirt, writable: false))
		{
			garment.Load(defaultGarmentStream);
		}
		GetTextureNode(garment).InnerXml = $"<url>{imageUrl}</url>";
		using MemoryStream garmentStream = new MemoryStream();
		garment.Save(garmentStream);
		garmentStream.Seek(0L, SeekOrigin.Begin);
		return base.DomainFactories.RawContentFactory.GetOrCreate(AssetTypeId, creatorType, creatorTargetId, garmentStream);
	}

	protected override ITeeShirt BuildChildAsset(IAsset genericAsset)
	{
		return new TeeShirt(base.DomainFactories, genericAsset);
	}

	internal ITeeShirt GetTeeShirt(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	public ITeeShirt CreateTeeShirt(AssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IImage image, IUserIdentifier actorUserIdentity)
	{
		IRawContent rawContent = CreateRawContent(assetCreatorInfo.CreatorType, assetCreatorInfo.CreatorTargetId, image);
		return CreateWithDependency(assetNameAndDescription, assetCreatorInfo, rawContent, actorUserIdentity, image, (AssetType)1);
	}

	private static System.Drawing.Image GetImage(XmlDocument fileXml)
	{
		Roblox.IAsset asset = GetImageAsset(fileXml);
		using MemoryStream memoryStream = FilesManager.Singleton.GetStream(asset.Hash);
		return System.Drawing.Image.FromStream(memoryStream);
	}

	private static System.Drawing.Image GetImage(Roblox.AssetVersion teeShirt)
	{
		Roblox.IAsset asset = GetImageAsset(teeShirt);
		using MemoryStream memoryStream = FilesManager.Singleton.GetStream(asset.Hash);
		return System.Drawing.Image.FromStream(memoryStream);
	}

	private static Roblox.IAsset GetImageAsset(XmlDocument fileXml)
	{
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(GetImageUri(fileXml), throwIfBadUrl: true);
	}

	private static Roblox.IAsset GetImageAsset(Roblox.AssetVersion teeShirt)
	{
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(GetImageUri(teeShirt), throwIfBadUrl: true);
	}

	private static AssetReference GetImageAssetReference(XmlDocument fileXml)
	{
		return QueryStringAssetParameterParser.ParseAssetReferenceFromQuerystring(GetImageUri(fileXml), throwIfBadUrl: true);
	}

	private static AssetReference GetImageAssetReference(Roblox.AssetVersion teeShirt)
	{
		return QueryStringAssetParameterParser.ParseAssetReferenceFromQuerystring(GetImageUri(teeShirt), throwIfBadUrl: true);
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

	private static Uri GetImageUri(Roblox.AssetVersion teeShirt)
	{
		return GetImageUri(FilesManager.Singleton.GetFileXml(teeShirt.Hash));
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
				if (item.Name == "Item" && item.Attributes["class"].Value == "ShirtGraphic")
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
					if (prop.Attributes["name"].Value == "Graphic")
					{
						return prop;
					}
				}
			}
		}
		return null;
	}

	private static bool IsTeeShirt(Roblox.AssetVersion accoutrementAssetVersion)
	{
		return accoutrementAssetVersion.AssetTypeID == Roblox.AssetType.TeeShirtID;
	}

	public static Stream ResampleTexture(Stream texture)
	{
		return ImageUtil.ResampleTextureEnforceDesiredSizeWithPadding(texture, 128, 128);
	}
}
