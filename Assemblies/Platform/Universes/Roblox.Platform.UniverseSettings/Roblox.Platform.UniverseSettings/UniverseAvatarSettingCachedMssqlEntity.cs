using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarSettingCachedMssqlEntity : IUniverseAvatarSettingEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long UniverseId { get; set; }

	public byte UniverseAvatarTypeId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte? UniverseScaleTypeId { get; set; }

	public byte? UniverseAvatarAnimationTypeId { get; set; }

	public byte? UniverseAvatarCollisionTypeId { get; set; }

	public byte? UniverseAvatarJointPositioningTypeId { get; set; }

	public byte? UniverseAvatarBodyTypeId { get; set; }

	public int? UniverseAvatarMinScaleId { get; set; }

	public int? UniverseAvatarMaxScaleId { get; set; }

	public void Update()
	{
		UniverseAvatarSetting cal = UniverseAvatarSetting.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.UniverseID = UniverseId;
		cal.UniverseAvatarTypeID = UniverseAvatarTypeId;
		cal.UniverseScaleTypeID = UniverseScaleTypeId;
		cal.UniverseAvatarAnimationTypeID = UniverseAvatarAnimationTypeId;
		cal.UniverseAvatarCollisionTypeID = UniverseAvatarCollisionTypeId;
		cal.UniverseAvatarJointPositioningTypeID = UniverseAvatarJointPositioningTypeId;
		cal.UniverseAvatarBodyTypeID = UniverseAvatarBodyTypeId;
		cal.UniverseAvatarMinScaleID = UniverseAvatarMinScaleId;
		cal.UniverseAvatarMaxScaleID = UniverseAvatarMaxScaleId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(UniverseAvatarSetting.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
