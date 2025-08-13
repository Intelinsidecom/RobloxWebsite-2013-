using System;
using Roblox.Outfits;

namespace Roblox.Platform.Outfits;

public class Color : IColor
{
	public int ID { get; private set; }

	public byte R { get; private set; }

	public byte G { get; private set; }

	public byte B { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	public static IColor GetOrCreate(byte r, byte g, byte b)
	{
		return Roblox.Outfits.Color.GetOrCreate(r, g, b).Translate();
	}

	public static IColor GetOrCreate(int brickColorId)
	{
		BrickColor brickColorEntity = BrickColor.Get(brickColorId);
		if (brickColorEntity == null)
		{
			return null;
		}
		return GetOrCreate(brickColorEntity.Color.R, brickColorEntity.Color.G, brickColorEntity.Color.B);
	}

	public bool IsValidBrickColor()
	{
		if (BrickColor.GetByRGB(R, G, B) == null)
		{
			return false;
		}
		return true;
	}

	public int GetBrickColorID()
	{
		return BrickColor.GetByRGB(R, G, B)?.ID ?? BrickColor.DefaultBrickColor.ID;
	}

	internal Color(int id, byte r, byte g, byte b)
	{
		ID = id;
		R = r;
		G = g;
		B = b;
	}
}
