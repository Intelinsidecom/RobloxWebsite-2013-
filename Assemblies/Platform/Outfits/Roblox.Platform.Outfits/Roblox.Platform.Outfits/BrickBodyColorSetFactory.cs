using System;
using System.Xml;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits.Properties;

namespace Roblox.Platform.Outfits;

/// <summary>
/// BrickColors are a specified palette of colors that the Roblox client uses
/// For now, avatars are restricted to this palette
/// In the future we may expand the limits
/// http://wiki.roblox.com/index.php?title=BrickColor
/// </summary>
[Obsolete("Do not use this class. It is in the process of being removed.")]
public class BrickBodyColorSetFactory : IBrickBodyColorSetFactory
{
	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public BrickBodyColorSetFactory(OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
	}

	/// <summary>
	/// Creates a new BodyColorSet from brickColorIds
	/// </summary>
	/// <param name="headBrickColorId"></param>
	/// <param name="leftArmBrickColorId"></param>
	/// <param name="leftLegBrickColorId"></param>
	/// <param name="rightArmBrickColorId"></param>
	/// <param name="rightLegBrickColorId"></param>
	/// <param name="torsoBrickColorId"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Outfits.PlatformIllegalBodyColorsException">Throw when an invalid bodyColorId is passed in</exception>
	public IBrickBodyColorSet Create(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId)
	{
		if (_OutfitDomainFactories.OutfitRulesManager.AreValidBodyColors(headBrickColorId, leftArmBrickColorId, leftLegBrickColorId, rightArmBrickColorId, rightLegBrickColorId, torsoBrickColorId))
		{
			return new BrickBodyColorSet(headBrickColorId, leftArmBrickColorId, leftLegBrickColorId, rightArmBrickColorId, rightLegBrickColorId, torsoBrickColorId, _OutfitDomainFactories);
		}
		throw new PlatformIllegalBodyColorsException("Invalid bodyColor ID");
	}

	/// <summary>
	/// Used to create a BrickBodyColorSetId when loading brickColors from an XML document and we don't want to do any validation
	/// Some old avatars have brickColors that are not in the new palette, e.g. 1005 Deep orange
	/// </summary>
	/// <param name="headBrickColorId"></param>
	/// <param name="leftArmBrickColorId"></param>
	/// <param name="leftLegBrickColorId"></param>
	/// <param name="rightArmBrickColorId"></param>
	/// <param name="rightLegBrickColorId"></param>
	/// <param name="torsoBrickColorId"></param>
	/// <returns></returns>
	public IBrickBodyColorSet CreateNoValidation(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId)
	{
		return new BrickBodyColorSet(headBrickColorId, leftArmBrickColorId, leftLegBrickColorId, rightArmBrickColorId, rightLegBrickColorId, torsoBrickColorId, _OutfitDomainFactories);
	}

	/// <summary>
	/// Translates from a BodyColorSet (ColorIds) to a BrickBodyColorSet (BrickColorIds)
	/// </summary>
	/// <param name="bodyColorSet"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown when a ColorId doesn't have a corresponding BrickColor</exception>
	public IBrickBodyColorSet FromBodyColorSet(IBodyColorSet bodyColorSet)
	{
		int brickColorIdFromColorId = GetBrickColorIdFromColorId(bodyColorSet.HeadColorID);
		int leftArmBrickColorId = GetBrickColorIdFromColorId(bodyColorSet.LeftArmColorID);
		int leftLegBrickColorId = GetBrickColorIdFromColorId(bodyColorSet.LeftLegColorID);
		int rightArmBrickColorId = GetBrickColorIdFromColorId(bodyColorSet.RightArmColorID);
		int rightLegBrickColorId = GetBrickColorIdFromColorId(bodyColorSet.RightLegColorID);
		int torsoBrickColorId = GetBrickColorIdFromColorId(bodyColorSet.TorsoColorID);
		return new BrickBodyColorSet(brickColorIdFromColorId, leftArmBrickColorId, leftLegBrickColorId, rightArmBrickColorId, rightLegBrickColorId, torsoBrickColorId, _OutfitDomainFactories);
	}

	/// <summary>
	/// Retrieves the colors from the XML document downloaded from BodyColorSet.BodyColorSetHash
	/// </summary>
	/// <param name="hash"></param>
	/// <returns></returns>
	public IBrickBodyColorSet FromBodyColorsHash(string hash)
	{
		if (Settings.Default.ReadBodyColorsByHashFromDb)
		{
			IBodyColorSet bodyColorSet = _OutfitDomainFactories.BodyColorSetFactory.GetByHash(hash);
			return FromBodyColorSet(bodyColorSet);
		}
		XmlDocument xmlDocument = _OutfitDomainFactories.BodyColorsXmlSerializer.DownloadXmlDocumentFromBodyColorsHash(hash);
		return _OutfitDomainFactories.BodyColorsXmlSerializer.ParseBodyColorsFromXmlDocument(xmlDocument);
	}

	private int GetBrickColorIdFromColorId(int colorId)
	{
		IColor color = ColorFactory.GetColor(colorId);
		if (!color.IsValidBrickColor())
		{
			throw new PlatformArgumentException($"No corresponding brickColor for colorId {colorId}");
		}
		return color.GetBrickColorID();
	}
}
