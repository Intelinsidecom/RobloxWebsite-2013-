using System.Collections.Generic;

namespace Roblox.Platform.Outfits;

public class KeyGeneratorInput
{
	public string AvatarHash { get; set; }

	public long? BodyColorSetID { get; set; }

	public List<long> AssetIDs { get; set; }

	public long? EquippedGearID { get; set; }

	public string ResolvedAvatarType { get; set; }

	public decimal? Height { get; set; }

	public decimal? Width { get; set; }

	public decimal? Head { get; set; }

	public decimal? Depth { get; set; }

	public decimal? Proportion { get; set; }

	public decimal? BodyType { get; set; }
}
