using System;
using Roblox.Outfits;

namespace Roblox.Platform.Outfits;

internal class BodyColorSet : IBodyColorSet
{
	public long ID { get; private set; }

	public int HeadColorID { get; private set; }

	public int LeftArmColorID { get; private set; }

	public int LeftLegColorID { get; private set; }

	public int RightArmColorID { get; private set; }

	public int RightLegColorID { get; private set; }

	public int TorsoColorID { get; private set; }

	/// <summary>
	/// BodyColorSetHash is a hash that points to a file in S3
	/// That file is the Body Colors XML document which contains all the body colors
	/// </summary>
	public string BodyColorSetHash { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	internal static IBodyColorSet Get(long bodyColorSetId)
	{
		return Roblox.Outfits.BodyColorSet.Get(bodyColorSetId).Translate();
	}

	/// <summary>
	/// GetOrCreates a BodyColorSet when bodyColorSetHash is known
	/// e.g. when creating an outfit from an existing user's appearance
	/// </summary> 
	internal static IBodyColorSet GetOrCreate(int headColorId, int leftArmColorId, int leftLegColorId, int rightArmColorId, int rightLegColorId, int torsoColorId)
	{
		return Roblox.Outfits.BodyColorSet.GetOrCreate(headColorId, leftArmColorId, leftLegColorId, rightArmColorId, rightLegColorId, torsoColorId, null).Translate();
	}

	internal BodyColorSet(long id, int headColorId, int leftArmColorId, int leftLegColorId, int rightArmColorId, int rightLegColorId, int torsoColorId, string bodyColorsHash)
	{
		ID = id;
		HeadColorID = headColorId;
		LeftArmColorID = leftArmColorId;
		LeftLegColorID = leftLegColorId;
		RightArmColorID = rightArmColorId;
		RightLegColorID = rightLegColorId;
		TorsoColorID = torsoColorId;
		BodyColorSetHash = bodyColorsHash;
	}

	internal static IBodyColorSet GetByHash(string hash)
	{
		return Roblox.Outfits.BodyColorSet.GetByHash(hash).Translate();
	}
}
