namespace Roblox.Platform.Outfits;

public interface IColor
{
	int ID { get; }

	byte R { get; }

	byte G { get; }

	byte B { get; }

	bool IsValidBrickColor();

	int GetBrickColorID();
}
