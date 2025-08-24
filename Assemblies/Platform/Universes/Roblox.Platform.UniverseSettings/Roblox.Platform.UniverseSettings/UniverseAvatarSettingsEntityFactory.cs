using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseAvatarSettingsEntityFactory : IUniverseAvatarSettingsEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	private readonly UniverseAvatarSettingsDefaults _UniverseAvatarSettingsDefaults;

	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseAvatarSettingsEntityFactory(UniverseSettingsDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
		_UniverseAvatarSettingsDefaults = new UniverseAvatarSettingsDefaults(domainFactories.ScaleFactory);
	}

	public IUniverseAvatarSettingEntity Get(long id)
	{
		return CalToCachedMssql(UniverseAvatarSetting.Get(id));
	}

	public IReadOnlyCollection<IUniverseAvatarSettingEntity> GetUniverseAvatarSettings(ICollection<long> ids)
	{
		return (IReadOnlyCollection<IUniverseAvatarSettingEntity>)(object)(from x in UniverseAvatarSetting.MultiGet(ids)
			where x != null
			select CalToCachedMssql(x)).ToArray();
	}

	public IUniverseAvatarSettingEntity GetByUniverseId(long universeId)
	{
		if (universeId == 0L)
		{
			return null;
		}
		return CalToCachedMssql(UniverseAvatarSetting.GetByUniverseID(universeId));
	}

	public IUniverseAvatarSettingEntity GetOrCreate(long universeId)
	{
		return GetOrCreate(universeId, _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarType(), _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseScaleType(), _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarAnimationType(), _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarCollisionType(), _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarBodyType(), _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarJointPositioningType(), _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarMinScaleId(), _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarMaxScaleId());
	}

	public IUniverseAvatarSettingEntity GetOrCreate(long universeId, UniverseAvatarType universeAvatarType, UniverseScaleType universeScaleType, UniverseAvatarAnimationType universeAvatarAnimationType, UniverseAvatarCollisionType universeAvatarCollisionType, UniverseAvatarBodyType universeAvatarBodyType, UniverseAvatarJointPositioningType universeAvatarJointPositioningType, int? universeAvatarMinScaleId = null, int? universeAvatarMaxScaleId = null)
	{
		if (universeId == 0L)
		{
			return null;
		}
		return CalToCachedMssql(UniverseAvatarSetting.GetOrCreate(universeId, (byte)universeAvatarType, (byte)universeScaleType, (byte)universeAvatarAnimationType, (byte)universeAvatarCollisionType, (byte)universeAvatarBodyType, (byte)universeAvatarJointPositioningType, universeAvatarMinScaleId, universeAvatarMaxScaleId));
	}

	private static IUniverseAvatarSettingEntity CalToCachedMssql(UniverseAvatarSetting cal)
	{
		if (cal != null)
		{
			return new UniverseAvatarSettingCachedMssqlEntity
			{
				Id = cal.ID,
				UniverseId = cal.UniverseID,
				UniverseAvatarTypeId = cal.UniverseAvatarTypeID,
				Created = cal.Created,
				Updated = cal.Updated,
				UniverseScaleTypeId = cal.UniverseScaleTypeID,
				UniverseAvatarAnimationTypeId = cal.UniverseAvatarAnimationTypeID,
				UniverseAvatarCollisionTypeId = cal.UniverseAvatarCollisionTypeID,
				UniverseAvatarJointPositioningTypeId = cal.UniverseAvatarJointPositioningTypeID,
				UniverseAvatarBodyTypeId = cal.UniverseAvatarBodyTypeID,
				UniverseAvatarMinScaleId = cal.UniverseAvatarMinScaleID,
				UniverseAvatarMaxScaleId = cal.UniverseAvatarMaxScaleID
			};
		}
		return null;
	}
}
