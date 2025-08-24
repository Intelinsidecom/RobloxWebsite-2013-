using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Publicly exposed representation of avatar scale
/// </summary>
internal class AvatarScale : IAvatarScale
{
	public decimal Height { get; set; }

	public decimal Width { get; set; }

	public decimal Head { get; set; }

	public decimal Depth { get; set; }

	public decimal Proportion { get; set; }

	public decimal BodyType { get; set; }

	public bool IsDefault
	{
		get
		{
			if (Height == ScaleRules.Height.Default && Width == ScaleRules.Width.Default && Head == ScaleRules.Head.Default && Proportion == ScaleRules.Proportion.Default)
			{
				return BodyType == ScaleRules.BodyType.Default;
			}
			return false;
		}
	}

	internal AvatarScale(decimal height, decimal width, decimal head, decimal depth, decimal proportion, decimal bodyType)
	{
		Height = height;
		Width = width;
		Head = head;
		Depth = depth;
		Proportion = proportion;
		BodyType = bodyType;
	}
}
