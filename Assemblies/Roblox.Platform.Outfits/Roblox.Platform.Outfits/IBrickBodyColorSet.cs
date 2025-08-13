namespace Roblox.Platform.Outfits;

/// <summary>
/// Represents a BodyColorSet that contains BrickColors
/// </summary>
public interface IBrickBodyColorSet
{
	int HeadBrickColorId { get; set; }

	int LeftArmBrickColorId { get; set; }

	int LeftLegBrickColorId { get; set; }

	int RightArmBrickColorId { get; set; }

	int RightLegBrickColorId { get; set; }

	int TorsoBrickColorId { get; set; }

	void SetBodyPart(BodyPart bodyPart, int brickColorId);
}
