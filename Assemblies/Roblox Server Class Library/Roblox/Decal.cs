using System;
using System.Xml;

namespace Roblox;

public class Decal
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

	internal static Uri GetImageUri(AssetVersion decal)
	{
		return GetImageUri(FilesManager.Singleton.GetFileXml(decal.Hash));
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
				if (item.Name == "Item" && item.Attributes["class"].Value == "Decal")
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
					if (prop.Attributes["name"].Value == "Texture")
					{
						return prop;
					}
				}
			}
		}
		return null;
	}

	public static IAsset GetImageAsset(AssetVersion decal)
	{
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(GetImageUri(decal), throwIfBadUrl: true);
	}
}
