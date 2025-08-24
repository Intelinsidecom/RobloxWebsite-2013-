using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Represents an <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> that randomly selects an <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /> based on its <see cref="P:Roblox.Platform.AbTesting.Core.IVariation.PercentEnrollments" /> property.
/// </summary>
public class PercentageVariationSelector : IVariationSelector
{
	private readonly IVariationFactory _VariationFactory;

	private static readonly PercentageVariationSelector _Instance = new PercentageVariationSelector(new VariationFactory());

	/// <summary>
	/// Gets a static instance of the <see cref="T:Roblox.Platform.AbTesting.Core.PercentageVariationSelector" /> class.
	/// </summary>
	public static PercentageVariationSelector Instance => _Instance;

	internal PercentageVariationSelector(IVariationFactory variationFactory)
	{
		_VariationFactory = variationFactory;
	}

	/// <summary>
	/// Gets a random percentage value between 0 (inclusive) and 100 (exclusive).
	/// </summary>
	/// <returns>A random number between 0 (inclusive) and 100 (exclusive).</returns>
	protected virtual int GetRandomPercentage()
	{
		return new Random(new object().GetHashCode()).Next(100);
	}

	public IVariation Select(IVersion experimentVersion)
	{
		if (experimentVersion == null)
		{
			throw new PlatformArgumentNullException("experimentVersion");
		}
		List<IVariation> list = _VariationFactory.GetByExperimentIdAndVersionNumber(experimentVersion.ExperimentId, experimentVersion.VersionNumber).ToList();
		if (!list.Any())
		{
			throw new PlatformArgumentException($"No variations created for given version with experiment ID '{experimentVersion.Id}' and version number '{experimentVersion.VersionNumber}'");
		}
		int percentage = GetRandomPercentage();
		int percentageRangeMaximum = 0;
		foreach (IVariation variation in list)
		{
			percentageRangeMaximum += variation.PercentEnrollments;
			if (percentage < percentageRangeMaximum)
			{
				return variation;
			}
		}
		throw new PlatformDataIntegrityException("Exception should never be thrown. Variations exist that don't add up to 100%.");
	}
}
