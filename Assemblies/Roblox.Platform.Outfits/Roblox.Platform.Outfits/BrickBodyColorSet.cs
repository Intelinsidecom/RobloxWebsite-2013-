using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

/// <summary>
///  BodyColors are currently stored as XML documents in S3. We are transitioning to storing them in the BodyColorSets database.
///
///  Note that BrickColorIds and ColorIds are totally different. ColorIds are from the Colors table that holds RGB values.
///  BrickColor Ids are from the Roblox game client http://wiki.roblox.com/index.php?title=BrickColor_codes.
///
///  This class represents a set of Body Colors. It has methods for manipulating the IDs, without persisting.
///  </summary>
///  <example>
///  var bodyColors = avatar.GetBodyColors();
///  bodyColors.SetBodyPart(BodyPartEnum.Head, BrickColor.Get(1))
///  avatar.SetBodyColors(bodyColors);
///  </example>
public class BrickBodyColorSet : IBrickBodyColorSet
{
	private OutfitDomainFactories _OutfitDomainFactories;

	public int HeadBrickColorId { get; set; }

	public int LeftArmBrickColorId { get; set; }

	public int LeftLegBrickColorId { get; set; }

	public int RightArmBrickColorId { get; set; }

	public int RightLegBrickColorId { get; set; }

	public int TorsoBrickColorId { get; set; }

	/// <summary>
	/// Constructs a BodyColorSet consisting of BrickColors
	/// </summary>
	/// <param name="headBrickColorId"></param>
	/// <param name="leftArmBrickColorId"></param>
	/// <param name="leftLegBrickColorId"></param>
	/// <param name="rightArmBrickColorId"></param>
	/// <param name="rightLegBrickColorId"></param>
	/// <param name="torsoBrickColorId"></param>
	internal BrickBodyColorSet(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId, OutfitDomainFactories outfitDomainFactories)
	{
		HeadBrickColorId = headBrickColorId;
		LeftArmBrickColorId = leftArmBrickColorId;
		LeftLegBrickColorId = leftLegBrickColorId;
		RightArmBrickColorId = rightArmBrickColorId;
		RightLegBrickColorId = rightLegBrickColorId;
		TorsoBrickColorId = torsoBrickColorId;
		_OutfitDomainFactories = outfitDomainFactories;
	}

	public void SetBodyPart(BodyPart bodyPart, int brickColorId)
	{
		if (BrickColor.Get(brickColorId) == null)
		{
			throw new PlatformArgumentException($"Invalid BrickColor ID {brickColorId} does not exist");
		}
		if (!_OutfitDomainFactories.OutfitRulesManager.IsValidBodyColor(brickColorId))
		{
			throw new PlatformArgumentException($"BrickColor ID {brickColorId} is not a valid color for avatars");
		}
		switch (bodyPart)
		{
		case BodyPart.Head:
			HeadBrickColorId = brickColorId;
			break;
		case BodyPart.Torso:
			TorsoBrickColorId = brickColorId;
			break;
		case BodyPart.LeftArm:
			LeftArmBrickColorId = brickColorId;
			break;
		case BodyPart.RightArm:
			RightArmBrickColorId = brickColorId;
			break;
		case BodyPart.LeftLeg:
			LeftLegBrickColorId = brickColorId;
			break;
		case BodyPart.RightLeg:
			RightLegBrickColorId = brickColorId;
			break;
		default:
			throw new PlatformInvalidEnumArgumentException(string.Format("{0} is not a valid {1}", bodyPart, "BodyPart"));
		}
	}
}
