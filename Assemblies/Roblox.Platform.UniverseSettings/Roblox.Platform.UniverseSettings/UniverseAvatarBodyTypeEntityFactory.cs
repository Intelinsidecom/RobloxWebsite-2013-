using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarBodyTypeEntityFactory : IUniverseAvatarBodyTypeEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseAvatarBodyTypeEntityFactory(UniverseSettingsDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUniverseAvatarBodyTypeEntity Get(byte id)
	{
		return CalToCachedMssql(UniverseAvatarBodyTypeEntity.Get(id));
	}

	public IUniverseAvatarBodyTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(UniverseAvatarBodyTypeEntity.GetByValue(value));
	}

	private static IUniverseAvatarBodyTypeEntity CalToCachedMssql(UniverseAvatarBodyTypeEntity cal)
	{
		if (cal != null)
		{
			return new UniverseAvatarBodyTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
