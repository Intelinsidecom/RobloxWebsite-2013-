namespace Roblox.Platform.Outfits;

public interface IBrickBodyColorSetFactory
{
	/// <summary>
	/// Creates a new BrickBodyColorSet from brickColorIds
	/// </summary>
	/// <param name="headBrickColorId"></param>
	/// <param name="leftArmBrickColorId"></param>
	/// <param name="leftLegBrickColorId"></param>
	/// <param name="rightArmBrickColorId"></param>
	/// <param name="rightLegBrickColorId"></param>
	/// <param name="torsoBrickColorId"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Throw when an invalid bodyColorId is passed in</exception>
	IBrickBodyColorSet Create(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId);

	/// <summary>
	/// Creates a BrickBodyColorSet without validating whether the brickColorIds are valid
	/// </summary>
	/// <param name="headBrickColorId"></param>
	/// <param name="leftArmBrickColorId"></param>
	/// <param name="leftLegBrickColorId"></param>
	/// <param name="rightArmBrickColorId"></param>
	/// <param name="rightLegBrickColorId"></param>
	/// <param name="torsoBrickColorId"></param>
	/// <returns></returns>
	IBrickBodyColorSet CreateNoValidation(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId);

	/// <summary>
	/// Translates from a BodyColorSet (ColorIds) to a BrickBodyColorSet (BrickColorIds)
	/// </summary>
	/// <param name="bodyColorSet"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown when a ColorId doesn't have a corresponding BrickColor</exception>
	IBrickBodyColorSet FromBodyColorSet(IBodyColorSet bodyColorSet);

	/// <summary>
	/// Downloads the XML document based on a Body Colors XML document hash
	/// </summary>
	/// <param name="hash"></param>
	/// <returns></returns>
	IBrickBodyColorSet FromBodyColorsHash(string hash);
}
