using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Represents an <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> that selects a specific variation by its value.
/// </summary>
public class ValueVariationSelector : IVariationSelector
{
	private readonly int _VariationValue;

	private readonly IVariationFactory _VariationFactory;

	/// <summary>
	/// Intitializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.ValueVariationSelector" /> class.
	/// </summary>
	/// <param name="variationValue">The value of variation to select.</param>
	/// <param name="variationFactory">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationFactory" /> to use to select the variation.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="variationFactory" /> is null.</exception>
	public ValueVariationSelector(int variationValue, IVariationFactory variationFactory)
	{
		if (variationFactory == null)
		{
			throw new PlatformArgumentNullException("variationFactory");
		}
		_VariationValue = variationValue;
		_VariationFactory = variationFactory;
	}

	public IVariation Select(IVersion experimentVersion)
	{
		if (experimentVersion == null)
		{
			throw new PlatformArgumentNullException("experimentVersion");
		}
		return _VariationFactory.GetByExperimentIdAndVersionNumber(experimentVersion.ExperimentId, experimentVersion.VersionNumber).FirstOrDefault((IVariation v) => v.Value == _VariationValue) ?? throw new PlatformArgumentException("Desired variation does not exist");
	}
}
