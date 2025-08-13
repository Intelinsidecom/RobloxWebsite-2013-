using System;
using System.Drawing;
using System.IO;
using System.Xml;

namespace Roblox;

public class Shirt
{
	internal static Uri GetImageUri(XmlDocument fileXml)
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

	internal static Uri GetImageUri(AssetVersion shirt)
	{
		return GetImageUri(FilesManager.Singleton.GetFileXml(shirt.Hash));
	}

	internal static XmlNode GetNode(XmlDocument fileXml)
	{
		foreach (XmlNode node in fileXml.ChildNodes)
		{
			if (!(node.Name == "roblox"))
			{
				continue;
			}
			foreach (XmlNode item in node.ChildNodes)
			{
				if (item.Name == "Item" && item.Attributes["class"].Value == "Shirt")
				{
					return item;
				}
			}
		}
		return null;
	}

	internal static XmlNode GetTextureNode(XmlDocument fileXml)
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
					if (prop.Attributes["name"].Value == "ShirtTemplate")
					{
						return prop;
					}
				}
			}
		}
		return null;
	}

	public static Image GetImage(XmlDocument fileXml)
	{
		IAsset asset = GetImageAsset(fileXml);
		using MemoryStream memoryStream = FilesManager.Singleton.GetStream(asset.Hash);
		return Image.FromStream(memoryStream);
	}

	public static Image GetImage(AssetVersion shirt)
	{
		IAsset asset = GetImageAsset(shirt);
		using MemoryStream memoryStream = FilesManager.Singleton.GetStream(asset.Hash);
		return Image.FromStream(memoryStream);
	}

	public static IAsset GetImageAsset(XmlDocument fileXml)
	{
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(GetImageUri(fileXml), throwIfBadUrl: true);
	}

	public static IAsset GetImageAsset(AssetVersion shirt)
	{
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(GetImageUri(shirt), throwIfBadUrl: true);
	}

	public static AssetReference GetImageAssetReference(XmlDocument fileXml)
	{
		return QueryStringAssetParameterParser.ParseAssetReferenceFromQuerystring(GetImageUri(fileXml), throwIfBadUrl: true);
	}

	public static AssetReference GetImageAssetReference(AssetVersion shirt)
	{
		return QueryStringAssetParameterParser.ParseAssetReferenceFromQuerystring(GetImageUri(shirt), throwIfBadUrl: true);
	}

	public static bool IsShirt(AssetVersion accoutrementAssetVersion)
	{
		return accoutrementAssetVersion.AssetTypeID == AssetType.ShirtID;
	}

	public static bool TemplateIsValid(Stream texture)
	{
		using Image sourceImage = Image.FromStream(texture);
		if (sourceImage.Height == 559 && sourceImage.Width == 585)
		{
			return true;
		}
		return false;
	}
}
