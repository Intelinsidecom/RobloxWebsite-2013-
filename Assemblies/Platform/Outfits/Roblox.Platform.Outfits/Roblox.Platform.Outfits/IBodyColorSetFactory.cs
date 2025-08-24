namespace Roblox.Platform.Outfits;

public interface IBodyColorSetFactory
{
	IBodyColorSet GetById(long bodyColorSetId);

	IBodyColorSet GetOrCreate(IBrickBodyColorSet brickBodyColorSet);

	IBodyColorSet GetByHash(string hash);
}
