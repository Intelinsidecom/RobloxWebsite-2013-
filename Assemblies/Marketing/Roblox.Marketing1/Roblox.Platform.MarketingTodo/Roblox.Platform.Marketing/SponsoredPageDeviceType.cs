using System;
using Roblox.Marketing;

namespace Roblox.Platform.Marketing;

internal class SponsoredPageDeviceType : ISponsoredPageDeviceType
{
	public int Id { get; private set; }

	public long DeviceTypesBitMask { get; set; }

	public int SponsoredPageId { get; set; }

	internal SponsoredPageDeviceType(int sponsoredPageId, long deviceTypesBitMask)
	{
		Id = 0;
		SponsoredPageId = sponsoredPageId;
		DeviceTypesBitMask = deviceTypesBitMask;
	}

	internal SponsoredPageDeviceType(Roblox.Marketing.SponsoredPageDeviceType entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		Id = entity.ID;
		DeviceTypesBitMask = entity.DeviceTypesBitMask;
		SponsoredPageId = entity.SponsoredPageID;
	}

	public void Save()
	{
		Roblox.Marketing.SponsoredPageDeviceType entity = Roblox.Marketing.SponsoredPageDeviceType.Get(Id) ?? new Roblox.Marketing.SponsoredPageDeviceType();
		entity.SponsoredPageID = SponsoredPageId;
		entity.DeviceTypesBitMask = DeviceTypesBitMask;
		entity.Save();
		Id = entity.ID;
	}

	public void Delete()
	{
		Roblox.Marketing.SponsoredPageDeviceType.Get(Id)?.Delete();
	}
}
