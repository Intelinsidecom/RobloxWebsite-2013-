using System.Collections.Generic;

namespace Roblox.Platform.Outfits;

/// <summary>
/// Contains common functions to validate scales
/// </summary>
public interface IScaleAuthority
{
	/// <summary>
	/// Gets scale values clamped on acceptable height, width, head, proportion, and bodyType ranges
	/// <param name="valid">A boolean that states whether or not the scales were valid before clamped</param>
	/// <param name="scalesModelToClamp">The scales to be clamped</param>
	/// <param name="existingScale">The existing scales to default to if a scale in the scalesModelToClamp does not have a value. Can be null.</param>
	/// </summary>
	Scale GetClampedScale(out bool valid, Scale scalesModelToClamp, Scale existingScale);

	/// <summary>
	/// Gets scale values clamped on acceptable height, width, head, proportion, and bodyType ranges
	/// <param name="valid">A boolean that states whether or not the scales were valid before clamped</param>
	/// <param name="height">The height scale</param>
	/// <param name="width">The width scale</param>
	/// <param name="head">The head scale</param>
	/// <param name="proportion">The proportion scale</param>
	/// <param name="bodyType">The bodyType scale</param>
	/// <param name="existingScale">The existing scales to default to if a scale in the scalesModelToClamp does not have a value. Can be null.</param>
	/// </summary>
	Scale GetClampedScale(out bool valid, decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType, Scale existingScale);

	/// <summary>
	/// Gets a list of violated ScaleRules when scales are not in acceptable range 
	/// <param name="height">The height scale</param>
	/// <param name="width">The width scale</param>
	/// <param name="head">The head scale</param>
	/// <param name="proportion">The proportion scale</param>
	/// <param name="bodyType">The bodyType scale</param>
	/// </summary>
	IEnumerable<ScaleRules> CheckScale(decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType);

	/// <summary>
	/// Gets a list of violated ScaleRules when min scale values are less than the max scale values
	/// </summary>
	IEnumerable<ScaleRules> CompareMinAndMaxScales(Scale minScalesModel, Scale maxScalesModel);
}
