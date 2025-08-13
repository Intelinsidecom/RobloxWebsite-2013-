using Roblox.Outfits;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

/// <summary>
/// BodyColorSets is a table in the database
/// Each row has columns that point to Color rows, which are RGB values
/// </summary>
public class BodyColorSetFactory : IBodyColorSetFactory
{
	private OutfitDomainFactories _OutfitDomainFactories;

	public BodyColorSetFactory(OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
	}

	public IBodyColorSet GetById(long bodyColorSetId)
	{
		return Roblox.Outfits.BodyColorSet.Get(bodyColorSetId).Translate();
	}

	public IBodyColorSet GetOrCreate(IBrickBodyColorSet brickBodyColorSet)
	{
		int iD = ColorFactory.GetFromBrickColor(brickBodyColorSet.HeadBrickColorId).ID;
		int leftArmColorId = ColorFactory.GetFromBrickColor(brickBodyColorSet.LeftArmBrickColorId).ID;
		int leftLegColorId = ColorFactory.GetFromBrickColor(brickBodyColorSet.LeftLegBrickColorId).ID;
		int rightArmColorId = ColorFactory.GetFromBrickColor(brickBodyColorSet.RightArmBrickColorId).ID;
		int rightLegColorId = ColorFactory.GetFromBrickColor(brickBodyColorSet.RightLegBrickColorId).ID;
		int torsoColorId = ColorFactory.GetFromBrickColor(brickBodyColorSet.TorsoBrickColorId).ID;
		return BodyColorSet.GetOrCreate(iD, leftArmColorId, leftLegColorId, rightArmColorId, rightLegColorId, torsoColorId);
	}

	public IBodyColorSet GetByHash(string hash)
	{
		if (string.IsNullOrWhiteSpace(hash))
		{
			return null;
		}
		return BodyColorSet.GetByHash(hash);
	}
}
