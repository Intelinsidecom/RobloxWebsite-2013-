namespace Roblox.Platform.Outfits;

/// <summary>
/// Factory to manipulate Scales
/// </summary>
public interface IScaleFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Outfits.Scale" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns> The <see cref="!:IScale" /> with the given ID, or null if none existed. </returns>
	Scale Get(int id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Outfits.Scale" /> with the given height, width, and head, proportion, and bodyType
	/// </summary>
	/// <param name="height">The height scale</param>
	/// <param name="width">The width scale</param>
	/// <param name="head">The head scale</param>
	/// <param name="proportion">The proportion scale</param>
	/// <param name="bodyType">The bodyType scale</param>
	/// <returns> The <see cref="!:IScale" /> with the given ID, or null if none existed. </returns>
	Scale GetOrCreate(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Outfits.Scale" /> with the default height, width, head, proportion, and bodyType
	/// </summary>
	/// <returns> The <see cref="!:IScale" /> with the given ID, or default scale values.</returns>
	Scale GetDefault();
}
