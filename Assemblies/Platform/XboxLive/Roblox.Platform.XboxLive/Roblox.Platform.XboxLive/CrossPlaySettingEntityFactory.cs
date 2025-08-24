using Roblox.Platform.Core;
using Roblox.Platform.XboxLive.Entities;

namespace Roblox.Platform.XboxLive;

internal class CrossPlaySettingEntityFactory : ICrossPlaySettingEntityFactory, IDomainFactory<XboxDomainFactories>, IDomainObject<XboxDomainFactories>
{
	public XboxDomainFactories DomainFactories { get; }

	public CrossPlaySettingEntityFactory(XboxDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public ICrossPlaySettingEntity Get(long id)
	{
		return CalToCachedMssql(CrossPlaySettingCAL.Get(id));
	}

	public ICrossPlaySettingEntity GetByUserId(long userId)
	{
		return CalToCachedMssql(CrossPlaySettingCAL.GetByUserId(userId));
	}

	public ICrossPlaySettingEntity CreateNew(long userId, bool isEnabled)
	{
		CrossPlaySettingCAL crossPlaySettingCAL = new CrossPlaySettingCAL();
		crossPlaySettingCAL.UserId = userId;
		crossPlaySettingCAL.IsEnabled = isEnabled;
		crossPlaySettingCAL.Save();
		return CalToCachedMssql(crossPlaySettingCAL);
	}

	private static ICrossPlaySettingEntity CalToCachedMssql(CrossPlaySettingCAL cal)
	{
		if (cal != null)
		{
			return new CrossPlaySettingCachedMssqlEntity
			{
				Id = cal.ID,
				UserId = cal.UserId,
				IsEnabled = cal.IsEnabled,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
