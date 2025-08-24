using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

internal class ScaleEntityFactory : IScaleEntityFactory, IDomainFactory<OutfitDomainFactories>, IDomainObject<OutfitDomainFactories>
{
	private readonly IScaleEntity _Default;

	public OutfitDomainFactories DomainFactories { get; }

	public ScaleEntityFactory(OutfitDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
		_Default = GetOrCreate(ScaleRules.Height.Default, ScaleRules.Width.Default, ScaleRules.Head.Default, ScaleRules.Proportion.Default, ScaleRules.BodyType.Default);
	}

	public IScaleEntity Get(int id)
	{
		return CalToCachedMssql(ScaleEntity.Get(id));
	}

	public IScaleEntity GetOrCreate(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		if (height == 0m || width == 0m || head == 0m)
		{
			return null;
		}
		return CalToCachedMssql(ScaleEntity.GetOrCreate(height, width, head, proportion, bodyType));
	}

	public IScaleEntity GetDefault()
	{
		return _Default;
	}

	private static IScaleEntity CalToCachedMssql(ScaleEntity cal)
	{
		if (cal != null)
		{
			return new ScaleCachedMssqlEntity
			{
				Id = cal.ID,
				Height = cal.Height,
				Width = cal.Width,
				Head = cal.Head,
				Proportion = cal.Proportion,
				BodyType = cal.BodyType,
				Created = cal.Created
			};
		}
		return null;
	}
}
