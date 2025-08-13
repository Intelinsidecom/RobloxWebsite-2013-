using System.Diagnostics.CodeAnalysis;
using Roblox.Data;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetChangeTypeEntityFactory : IAssetChangeTypesEntityFactory, IDomainFactory<AssetDomainFactories>, IDomainObject<AssetDomainFactories>
{
	public AssetDomainFactories DomainFactories { get; }

	public byte GetIdByEnum(AssetChangeType changeType)
	{
		string changeTypeName = changeType.ToString();
		return (DomainFactories.AssetChangeTypesEntityFactory.GetByValue(changeTypeName) ?? throw new DataIntegrityException($"Unable to lookup AssetChangeType {changeTypeName}")).Id;
	}

	public AssetChangeTypeEntityFactory(AssetDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAssetChangeTypeEntity Get(byte id)
	{
		return CalToCachedMssql(AssetChangeTypeCAL.Get(id));
	}

	public IAssetChangeTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AssetChangeTypeCAL.GetByValue(value));
	}

	private static IAssetChangeTypeEntity CalToCachedMssql(AssetChangeTypeCAL cal)
	{
		if (cal != null)
		{
			return new AssetChangeTypeEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Description = cal.Description,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
