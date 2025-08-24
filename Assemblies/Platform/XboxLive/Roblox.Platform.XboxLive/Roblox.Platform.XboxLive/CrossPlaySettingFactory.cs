using Roblox.Platform.Membership;

namespace Roblox.Platform.XboxLive;

public class CrossPlaySettingFactory : ICrossPlaySettingFactory
{
	private readonly XboxDomainFactories _DomainFactories;

	public CrossPlaySettingFactory(XboxDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories;
	}

	public ICrossPlaySetting GetByUserId(IUser user)
	{
		ICrossPlaySettingEntity crossPlaySetting = _DomainFactories.CrossPlaySettingEntityFactory.GetByUserId(user.Id);
		if (crossPlaySetting != null)
		{
			return new CrossPlaySetting(_DomainFactories, crossPlaySetting);
		}
		return null;
	}

	public ICrossPlaySetting CreateNew(IUser user, bool isEnabled)
	{
		ICrossPlaySettingEntity crossPlaySettingEntity = _DomainFactories.CrossPlaySettingEntityFactory.CreateNew(user.Id, isEnabled);
		return new CrossPlaySetting(_DomainFactories, crossPlaySettingEntity);
	}
}
