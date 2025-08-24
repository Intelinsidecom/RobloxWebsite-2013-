using Roblox.Outfits;

namespace Roblox.Platform.Outfits;

public class ColorFactory
{
	public static IColor GetColor(int id)
	{
		return Roblox.Outfits.Color.Get(id).Translate();
	}

	public static IColor GetFromBrickColor(int brickColorId)
	{
		return Color.GetOrCreate(brickColorId);
	}
}
