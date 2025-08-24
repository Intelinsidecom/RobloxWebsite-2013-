using Roblox.Caching;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

/// <inheritdoc />
public class ScaleFactory : IScaleFactory
{
	private readonly LazyWithRetry<Scale> _Default;

	private OutfitDomainFactories _OutfitDomainFactories { get; }

	/// <summary>
	/// Constructs a ScaleFactory
	/// </summary>
	/// <param name="outfitDomainFactories">The OutfitDomainFactories.</param>
	public ScaleFactory(OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
		_Default = new LazyWithRetry<Scale>(() => Translate(_OutfitDomainFactories.ScaleEntityFactory.GetDefault()));
	}

	/// <inheritdoc />
	public Scale Get(int id)
	{
		IScaleEntity cal = _OutfitDomainFactories.ScaleEntityFactory.Get(id);
		return Translate(cal);
	}

	/// <inheritdoc />
	public Scale GetOrCreate(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		IScaleEntity cal = _OutfitDomainFactories.ScaleEntityFactory.GetOrCreate(height, width, head, proportion, bodyType);
		return Translate(cal);
	}

	/// <inheritdoc />
	public Scale GetDefault()
	{
		return _Default.Value;
	}

	private Scale Translate(IScaleEntity scale)
	{
		if (scale != null)
		{
			return new Scale
			{
				Id = scale.Id,
				Height = scale.Height,
				Width = scale.Width,
				Head = scale.Head,
				Proportion = scale.Proportion,
				BodyType = scale.BodyType
			};
		}
		return null;
	}
}
