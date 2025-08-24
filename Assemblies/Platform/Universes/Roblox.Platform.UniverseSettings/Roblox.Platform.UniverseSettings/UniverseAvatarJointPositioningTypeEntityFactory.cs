using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarJointPositioningTypeEntityFactory : IUniverseAvatarJointPositioningTypeEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseAvatarJointPositioningTypeEntityFactory(UniverseSettingsDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUniverseAvatarJointPositioningTypeEntity Get(byte id)
	{
		return CalToCachedMssql(UniverseAvatarJointPositioningTypeEntity.Get(id));
	}

	public IUniverseAvatarJointPositioningTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(UniverseAvatarJointPositioningTypeEntity.GetByValue(value));
	}

	private static IUniverseAvatarJointPositioningTypeEntity CalToCachedMssql(UniverseAvatarJointPositioningTypeEntity cal)
	{
		if (cal != null)
		{
			return new UniverseAvatarJointPositioningTypeCachedMssqlEntity
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
