using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.XboxLive;

public class CrossPlaySetting : DomainObjectBase<XboxDomainFactories, long>, ICrossPlaySetting
{
	public long UserId { get; }

	public bool IsEnabled { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public CrossPlaySetting(XboxDomainFactories domainFactories, long userId, bool isEnabled, DateTime created, DateTime updated)
		: base(domainFactories)
	{
		UserId = userId;
		IsEnabled = isEnabled;
		Created = created;
		Updated = updated;
	}

	internal CrossPlaySetting(XboxDomainFactories domainFactories, ICrossPlaySettingEntity crossPlaySettingEntity)
		: base(domainFactories)
	{
		UserId = crossPlaySettingEntity.UserId;
		IsEnabled = crossPlaySettingEntity.IsEnabled;
		Created = crossPlaySettingEntity.Created;
		Updated = crossPlaySettingEntity.Updated;
	}

	public void SetEnabled(bool enabled)
	{
		ICrossPlaySettingEntity byUserId = base.DomainFactories.CrossPlaySettingEntityFactory.GetByUserId(UserId);
		byUserId.IsEnabled = enabled;
		byUserId.Update();
	}
}
