using System;
using Roblox.Outfits;

namespace Roblox.Platform.Outfits;

public static class Extensions
{
	internal static IBodyColorSet Translate(this Roblox.Outfits.BodyColorSet bodyColorSetEntity)
	{
		if (bodyColorSetEntity == null)
		{
			return null;
		}
		long iD = bodyColorSetEntity.ID;
		int head = bodyColorSetEntity.HeadColorID;
		int leftArm = bodyColorSetEntity.LeftArmColorID;
		int leftLeg = bodyColorSetEntity.LeftLegColorID;
		int rightArm = bodyColorSetEntity.RightArmColorID;
		int rightLeg = bodyColorSetEntity.RightLegColorID;
		int torso = bodyColorSetEntity.TorsoColorID;
		string bodyColorsHash = bodyColorSetEntity.BodyColorSetHash;
		return new BodyColorSet(iD, head, leftArm, leftLeg, rightArm, rightLeg, torso, bodyColorsHash);
	}

	internal static IColor Translate(this Roblox.Outfits.Color entity)
	{
		if (entity == null)
		{
			return null;
		}
		int iD = entity.ID;
		byte r = entity.R;
		byte g = entity.G;
		byte b = entity.B;
		return new Color(iD, r, g, b);
	}

	internal static IOutfitAccoutrementEntity Translate(this OutfitAccoutrement entity)
	{
		if (entity == null)
		{
			return null;
		}
		long iD = entity.ID;
		long assetId = entity.AssetID;
		long outfitId = entity.OutfitID;
		DateTime created = entity.Created;
		DateTime updated = entity.Updated;
		return new OutfitAccoutrementEntity(iD, assetId, outfitId, created, updated);
	}
}
