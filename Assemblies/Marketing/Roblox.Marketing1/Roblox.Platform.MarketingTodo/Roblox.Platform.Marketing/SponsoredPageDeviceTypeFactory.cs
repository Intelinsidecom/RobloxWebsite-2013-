using Roblox.Marketing;

namespace Roblox.Platform.Marketing;

public class SponsoredPageDeviceTypeFactory : ISponsoredPageDeviceTypeFactory
{
	public ISponsoredPageDeviceType GetBySponsoredPageId(int sponsoredPageId)
	{
		Roblox.Marketing.SponsoredPageDeviceType entity = Roblox.Marketing.SponsoredPageDeviceType.GetBySponsoredPageId(sponsoredPageId);
		if (entity == null)
		{
			return null;
		}
		return new SponsoredPageDeviceType(entity);
	}

	public ISponsoredPageDeviceType CreateSponsoredPageDeviceType(int sponsoredPageId, long deviceTypesBitMask)
	{
		SponsoredPageDeviceType sponsoredPageDeviceType = new SponsoredPageDeviceType(sponsoredPageId, deviceTypesBitMask);
		sponsoredPageDeviceType.Save();
		return sponsoredPageDeviceType;
	}
}
