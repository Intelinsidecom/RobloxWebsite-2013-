namespace Roblox.Platform.Outfits;

/// <summary>
/// A model that contains scaling information
/// </summary>
public class Scale
{
	public int Id { get; set; }

	/// <summary>
	/// The height scale 
	/// </summary>
	public decimal Height { get; set; }

	/// <summary>
	/// The width scale
	/// </summary>
	public decimal Width { get; set; }

	/// <summary>
	/// The head scale 
	/// </summary>
	public decimal? Head { get; set; }

	/// <summary>
	/// The depth scale of the avatar
	/// </summary>
	public decimal Depth { get; set; }

	/// <summary>
	/// The proportion scale 
	/// </summary>
	public decimal? Proportion { get; set; }

	/// <summary>
	/// The body type scale
	/// </summary>
	public decimal? BodyType { get; set; }
}
