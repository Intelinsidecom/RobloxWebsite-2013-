using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits.Properties;
using Roblox.Users.Properties;

namespace Roblox.Platform.Outfits;

/// <inheritdoc />
public class BodyColorsXmlSerializer : IBodyColorsXmlSerializer
{
	/// <summary>
	/// Very important that this matches the existing XML format, do not make any formatting changes
	/// We now have a unit test to ensure the format is not changed
	/// </summary>
	private static readonly byte[] _DefaultAvatar = Roblox.Platform.Outfits.Properties.Resources.CharacterAppearance;

	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public BodyColorsXmlSerializer(OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories;
	}

	/// <inheritdoc />
	public XmlDocument GenerateBodyColorsXmlDocument(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId)
	{
		XmlDocument avatarDocument = new XmlDocument();
		using (MemoryStream readStream = new MemoryStream(_DefaultAvatar, writable: false))
		{
			avatarDocument.Load(readStream);
		}
		SetBodyColor("HeadColor", BrickColor.Get(headBrickColorId), avatarDocument);
		SetBodyColor("LeftArmColor", BrickColor.Get(leftArmBrickColorId), avatarDocument);
		SetBodyColor("LeftLegColor", BrickColor.Get(leftLegBrickColorId), avatarDocument);
		SetBodyColor("RightArmColor", BrickColor.Get(rightArmBrickColorId), avatarDocument);
		SetBodyColor("RightLegColor", BrickColor.Get(rightLegBrickColorId), avatarDocument);
		SetBodyColor("TorsoColor", BrickColor.Get(torsoBrickColorId), avatarDocument);
		return avatarDocument;
	}

	/// <inheritdoc />
	private void StripTeeShirtFromAvatar(IUserAvatar userAvatar, XmlDocument bodyColorsXmlDocument)
	{
		XmlNode teeShirt = TeeShirt.GetNode(bodyColorsXmlDocument);
		if (teeShirt != null)
		{
			while (teeShirt != null)
			{
				_OutfitDomainFactories.BodyColorsPerformanceCounter?.StripTeeShirtFromAvatarHash.Increment();
				teeShirt.ParentNode.RemoveChild(teeShirt);
				teeShirt = TeeShirt.GetNode(bodyColorsXmlDocument);
			}
			PersistAvatar(userAvatar, bodyColorsXmlDocument);
		}
	}

	/// <inheritdoc />
	public void AddDefaultColorsIfMissing(IUserAvatar userAvatar)
	{
		if (string.IsNullOrEmpty(userAvatar.AvatarHash))
		{
			ResetToDefaultColors(userAvatar);
		}
	}

	/// <summary>
	/// Moved from UserAvatar in Server Class Library
	/// Resets the UserAvatar's Body Colors
	/// </summary>
	/// <param name="userAvatar"></param>
	private void ResetToDefaultColors(IUserAvatar userAvatar)
	{
		XmlDocument avatarDocument = new XmlDocument();
		using (MemoryStream memoryStream = new MemoryStream(_DefaultAvatar, writable: false))
		{
			avatarDocument.Load(memoryStream);
		}
		BrickColor headAndArmsColor = BrickColor.GetRandomHeadColor();
		SetBodyColor("HeadColor", headAndArmsColor, avatarDocument);
		SetBodyColor("LeftArmColor", headAndArmsColor, avatarDocument);
		SetBodyColor("RightArmColor", headAndArmsColor, avatarDocument);
		SetBodyColor("TorsoColor", BrickColor.GetRandom(), avatarDocument);
		PersistAvatar(userAvatar, avatarDocument);
		_OutfitDomainFactories.BodyColorsPerformanceCounter?.SetupDefaultAvatarHash.Increment();
	}

	/// <inheritdoc />
	public void PersistAvatar(IUserAvatar userAvatar, XmlDocument bodyColorsXmlDocument)
	{
		string avatarHash = UploadXmlDocument(bodyColorsXmlDocument);
		if (userAvatar.AvatarHash != avatarHash)
		{
			userAvatar.AvatarHash = avatarHash;
			userAvatar.Save();
		}
	}

	/// <inheritdoc />
	public void SetBodyColor(string property, BrickColor brickColor, XmlDocument avatarDocument)
	{
		foreach (XmlNode item in avatarDocument.ChildNodes[avatarDocument.ChildNodes.Count - 1].ChildNodes)
		{
			if (!(item.Name == "Item") || !(item.Attributes["class"].Value == "BodyColors"))
			{
				continue;
			}
			foreach (XmlNode props in item.ChildNodes)
			{
				if (!(props.Name == "Properties"))
				{
					continue;
				}
				foreach (XmlNode prop in props.ChildNodes)
				{
					if (prop.Attributes["name"].Value == property)
					{
						prop.InnerText = brickColor.ID.ToString();
						return;
					}
				}
			}
		}
		throw new ApplicationException($"SetBodyColor: Unable to find {property}");
	}

	/// <inheritdoc />
	public string GetOrCreateAssetHashFromBrickColorIds(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId)
	{
		XmlDocument bodyColorsXmlDocument = GenerateBodyColorsXmlDocument(headBrickColorId, leftArmBrickColorId, leftLegBrickColorId, rightArmBrickColorId, rightLegBrickColorId, torsoBrickColorId);
		return UploadXmlDocument(bodyColorsXmlDocument);
	}

	/// <inheritdoc />
	public XmlDocument DownloadXmlDocumentFromBodyColorsHash(string bodyColorsHash)
	{
		if (string.IsNullOrEmpty(bodyColorsHash))
		{
			throw new PlatformArgumentException(string.Format("BodyColorsHash was null or empty in {0}", "DownloadXmlDocumentFromBodyColorsHash"));
		}
		XmlDocument bodyColorsXmlDocument = new XmlDocument();
		try
		{
			using (MemoryStream avatarStream = FilesManager.Singleton.GetStream(bodyColorsHash))
			{
				bodyColorsXmlDocument.Load(avatarStream);
			}
			return bodyColorsXmlDocument;
		}
		catch (Exception ex)
		{
			throw new PlatformFailedToRetrieveBodyColorsException($"Failed to retrieve BodyColors with hash {bodyColorsHash}", ex);
		}
	}

	/// <inheritdoc />
	public string UploadXmlDocument(XmlDocument bodyColorsXmlDocument)
	{
		ICreator creator = CreatorRef.CreateNewUserRef(Roblox.Users.Properties.Settings.Default.RobloxUserId).GetCreator();
		using MemoryStream memoryStream = new MemoryStream();
		using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream))
		{
			bodyColorsXmlDocument.WriteTo(xmlWriter);
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		string hash = FilesManager.Singleton.AddFile(memoryStream, DecompressionMethods.None);
		_OutfitDomainFactories.RawContentFactory.GetOrCreate(AssetType.AvatarID, creator.CreatorType.Translate(), creator.ID, hash);
		return hash;
	}

	/// <inheritdoc />
	public XmlDocument GetBodyColorsXmlDocumentFromUserAvatar(IUserAvatar userAvatar, out string avatarHash)
	{
		AddDefaultColorsIfMissing(userAvatar);
		XmlDocument bodyColorsXmlDocument;
		try
		{
			avatarHash = userAvatar.AvatarHash;
			bodyColorsXmlDocument = DownloadXmlDocumentFromBodyColorsHash(avatarHash);
		}
		catch (Exception)
		{
			if (Roblox.Platform.Outfits.Properties.Settings.Default.ResetBodyColorsWhenFetchFromS3Fails)
			{
				ResetToDefaultColors(userAvatar);
			}
			avatarHash = userAvatar.AvatarHash;
			bodyColorsXmlDocument = DownloadXmlDocumentFromBodyColorsHash(avatarHash);
		}
		StripTeeShirtFromAvatar(userAvatar, bodyColorsXmlDocument);
		return bodyColorsXmlDocument;
	}

	/// <inheritdoc />
	public IBrickBodyColorSet ParseBodyColorsFromXmlDocument(XmlDocument avatarXmlDocument)
	{
		IDictionary<string, int> bodyColorDictionary = new Dictionary<string, int>();
		foreach (XmlNode item in avatarXmlDocument.ChildNodes[avatarXmlDocument.ChildNodes.Count - 1].ChildNodes)
		{
			if (!(item.Name == "Item") || !(item.Attributes["class"].Value == "BodyColors"))
			{
				continue;
			}
			foreach (XmlNode props in item.ChildNodes)
			{
				if (!(props.Name == "Properties"))
				{
					continue;
				}
				foreach (XmlNode prop in props.ChildNodes)
				{
					string attributeName = prop.Attributes["name"].Value;
					switch (attributeName)
					{
					case "HeadColor":
					case "LeftArmColor":
					case "LeftLegColor":
					case "RightArmColor":
					case "RightLegColor":
					case "TorsoColor":
					{
						BrickColor brickColor = BrickColor.Get(Convert.ToInt32(prop.InnerText));
						bodyColorDictionary.Add(attributeName, brickColor.ID);
						break;
					}
					}
				}
			}
		}
		return _OutfitDomainFactories.BrickBodyColorSetFactory.CreateNoValidation(bodyColorDictionary["HeadColor"], bodyColorDictionary["LeftArmColor"], bodyColorDictionary["LeftLegColor"], bodyColorDictionary["RightArmColor"], bodyColorDictionary["RightLegColor"], bodyColorDictionary["TorsoColor"]);
	}

	/// <inheritdoc />
	public IBrickBodyColorSet GetBrickColorSetFromAvatarHash(IUserAvatar userAvatar)
	{
		_OutfitDomainFactories.BodyColorsPerformanceCounter?.ReadAvatarHash.Increment();
		string avatarHash;
		XmlDocument avatarXmlDocument = GetBodyColorsXmlDocumentFromUserAvatar(userAvatar, out avatarHash);
		return ParseBodyColorsFromXmlDocument(avatarXmlDocument);
	}
}
