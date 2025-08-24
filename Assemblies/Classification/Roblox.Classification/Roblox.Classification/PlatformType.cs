using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Classification;

public class PlatformType : IRobloxEntity<byte, PlatformTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PlatformTypeDAL _EntityDAL;

	public static readonly byte MacID;

	public static readonly byte PCID;

	public static readonly byte iPad1ID;

	public static readonly byte iPad2ID;

	public static readonly byte iPad3ID;

	public static readonly byte iPad4ID;

	public static readonly byte iPad6ID;

	public static readonly byte iPadMini1GID;

	public static readonly byte iPadMini2GID;

	public static readonly byte iPadMini3GID;

	public static readonly byte iPadMini4GID;

	public static readonly byte iPadAirID;

	public static readonly byte iPadAir2ID;

	public static readonly byte iPadPro9_7ID;

	public static readonly byte iPadPro10_5ID;

	public static readonly byte iPadPro12_9ID;

	public static readonly byte iPhone3GID;

	public static readonly byte iPhone3GSID;

	public static readonly byte iPhone4ID;

	public static readonly byte iPhone4SID;

	public static readonly byte iPhone5ID;

	public static readonly byte iPhone5cID;

	public static readonly byte iPhone5sID;

	public static readonly byte iPhone6ID;

	public static readonly byte iPhone6PlusID;

	public static readonly byte iPhone6sID;

	public static readonly byte iPhone6sPlusID;

	public static readonly byte iPhoneSEID;

	public static readonly byte iPhone7ID;

	public static readonly byte iPhone7PlusID;

	public static readonly byte iPhone8ID;

	public static readonly byte iPhone8PlusID;

	public static readonly byte iPhoneXID;

	public static readonly byte iPhoneXRID;

	public static readonly byte iPhoneXSID;

	public static readonly byte iPhoneXSMaxID;

	public static readonly byte iPodTouch3GID;

	public static readonly byte iPodTouch4GID;

	public static readonly byte iPodTouch5GID;

	public static readonly byte iPodTouch6GID;

	public static readonly byte iOSUnknownID;

	public static readonly byte iOSUnknownPhoneID;

	public static readonly byte iOSUnknownTabletID;

	public static readonly byte UnknownID;

	public static readonly byte AndroidLowEndPhoneID;

	public static readonly byte AndroidHighEndPhoneID;

	public static readonly byte AndroidLowEndTabletID;

	public static readonly byte AndroidHighEndTabletID;

	public static readonly byte AndroidUnknownID;

	public static readonly byte AndroidUnknownPhoneID;

	public static readonly byte AndroidUnknownTabletID;

	public static readonly byte WindowsLowEndPhoneID;

	public static readonly byte WindowsHighEndPhoneID;

	public static readonly byte WindowsUnknownPhoneID;

	public static readonly byte WindowsLowEndTabletID;

	public static readonly byte WindowsHighEndTabletID;

	public static readonly byte WindowsUnknownTabletID;

	public static readonly byte XboxOneID;

	public static readonly byte DesktopWindowsUwpID;

	public static readonly byte StudioWindowsID;

	public static readonly byte StudioMacID;

	public static readonly byte ChromebookID;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public byte? DeviceTypeID
	{
		get
		{
			return _EntityDAL.DeviceTypeID;
		}
		set
		{
			_EntityDAL.DeviceTypeID = value;
		}
	}

	public byte? OperatingSystemTypeID
	{
		get
		{
			return _EntityDAL.OperatingSystemTypeID;
		}
		set
		{
			_EntityDAL.OperatingSystemTypeID = value;
		}
	}

	public byte? ApplicationTypeID
	{
		get
		{
			return _EntityDAL.ApplicationTypeID;
		}
		set
		{
			_EntityDAL.ApplicationTypeID = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PlatformType()
	{
		_EntityDAL = new PlatformTypeDAL();
	}

	static PlatformType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Segmentation.PlatformType", isNullCacheable: true);
		MacID = GetByValue("Mac").ID;
		PCID = GetByValue("PC").ID;
		iPad1ID = GetByValue("iPad 1").ID;
		iPad2ID = GetByValue("iPad 2").ID;
		iPad3ID = GetByValue("iPad 3").ID;
		iPad4ID = GetByValue("iPad 4").ID;
		iPad4ID = GetByValue("iPad 6").ID;
		iPadMini1GID = GetByValue("iPad mini 1G").ID;
		iPadMini2GID = GetByValue("iPad mini 2G").ID;
		iPadMini3GID = GetByValue("iPad mini 3G").ID;
		iPadMini4GID = GetByValue("iPad mini 4G").ID;
		iPadAirID = GetByValue("iPad Air").ID;
		iPadAir2ID = GetByValue("iPad Air 2").ID;
		iPadPro9_7ID = GetByValue("iPad Pro 9.7").ID;
		iPadPro10_5ID = GetByValue("iPad Pro 10.5").ID;
		iPadPro12_9ID = GetByValue("iPad Pro 12.9").ID;
		iPhone3GID = GetByValue("iPhone 3G").ID;
		iPhone3GSID = GetByValue("iPhone 3GS").ID;
		iPhone4ID = GetByValue("iPhone 4").ID;
		iPhone4SID = GetByValue("iPhone 4S").ID;
		iPhone5ID = GetByValue("iPhone 5").ID;
		iPhone5cID = GetByValue("iPhone 5c").ID;
		iPhone5sID = GetByValue("iPhone 5s").ID;
		iPhone6ID = GetByValue("iPhone 6").ID;
		iPhone6PlusID = GetByValue("iPhone 6+").ID;
		iPhone6sID = GetByValue("iPhone 6s").ID;
		iPhone6sPlusID = GetByValue("iPhone 6s+").ID;
		iPhoneSEID = GetByValue("iPhone SE").ID;
		iPhone7ID = GetByValue("iPhone 7").ID;
		iPhone7PlusID = GetByValue("iPhone 7+").ID;
		iPhone8ID = GetByValue("iPhone 8").ID;
		iPhone8PlusID = GetByValue("iPhone 8+").ID;
		iPhoneXID = GetByValue("iPhone X").ID;
		iPhoneXRID = GetByValue("iPhone XR").ID;
		iPhoneXSID = GetByValue("iPhone XS").ID;
		iPhoneXSMaxID = GetByValue("iPhone XS Max").ID;
		iPodTouch3GID = GetByValue("iPod touch 3G").ID;
		iPodTouch4GID = GetByValue("iPod touch 4G").ID;
		iPodTouch5GID = GetByValue("iPod touch 5G").ID;
		iPodTouch6GID = GetByValue("iPod touch 6G").ID;
		iOSUnknownID = GetByValue("iOS: unknown").ID;
		iOSUnknownPhoneID = GetByValue("iOS: unknown phone").ID;
		iOSUnknownTabletID = GetByValue("iOS: unknown tablet").ID;
		UnknownID = GetByValue("Unknown").ID;
		AndroidUnknownID = GetByValue("Android: unknown").ID;
		AndroidUnknownPhoneID = GetByValue("Android: unknown phone").ID;
		AndroidLowEndPhoneID = GetByValue("Android: low-end phone").ID;
		AndroidHighEndPhoneID = GetByValue("Android: high-end phone").ID;
		AndroidUnknownTabletID = GetByValue("Android: unknown tablet").ID;
		AndroidLowEndTabletID = GetByValue("Android: low-end tablet").ID;
		AndroidHighEndTabletID = GetByValue("Android: high-end tablet").ID;
		WindowsUnknownPhoneID = GetByValue("Windows: unknown phone").ID;
		WindowsLowEndPhoneID = GetByValue("Windows: low-end phone").ID;
		WindowsHighEndPhoneID = GetByValue("Windows: high-end phone").ID;
		WindowsUnknownTabletID = GetByValue("Windows: unknown tablet").ID;
		WindowsLowEndTabletID = GetByValue("Windows: low-end tablet").ID;
		WindowsHighEndTabletID = GetByValue("Windows: high-end tablet").ID;
		XboxOneID = GetByValue("Xbox: Xbox One").ID;
		DesktopWindowsUwpID = GetByValue("Desktop Windows UWP").ID;
		StudioWindowsID = GetByValue("Roblox Studio for Windows").ID;
		StudioMacID = GetByValue("Roblox Studio for Mac").ID;
		ChromebookID = GetByValue("Chromebook").ID;
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static PlatformType CreateNew(string name, byte deviceTypeId, byte operatingSystemTypeId)
	{
		PlatformType platformType = new PlatformType();
		platformType.Value = name;
		platformType.DeviceTypeID = deviceTypeId;
		platformType.OperatingSystemTypeID = operatingSystemTypeId;
		platformType.Save();
		return platformType;
	}

	public static PlatformType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PlatformTypeDAL, PlatformType>(EntityCacheInfo, id, () => PlatformTypeDAL.Get(id));
	}

	public static PlatformType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PlatformTypeDAL, PlatformType>(EntityCacheInfo, $"Value:{value}", () => PlatformTypeDAL.Get(value));
	}

	public static ICollection<PlatformType> GetPlatformTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPlatformTypes:StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => PlatformTypeDAL.GetPlatformTypesPaged(startRowIndex + 1, maximumRows), MultiGet);
	}

	public static ICollection<PlatformType> GetPlatformTypesByDeviceTypeId_Paged(byte deviceTypeId, int startRowIndex, int maximumRows)
	{
		string cachedStateQualifier = $"DeviceTypeID:{deviceTypeId}";
		string collectionId = $"GetPlatformTypes:DeviceTypeID:{deviceTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => PlatformTypeDAL.GetPlatformTypeIdsByDeviceTypeId_Paged(deviceTypeId, startRowIndex + 1, maximumRows), MultiGet);
	}

	public static ICollection<PlatformType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, PlatformTypeDAL, PlatformType>(ids, EntityCacheInfo, PlatformTypeDAL.MultiGet);
	}

	public void Construct(PlatformTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"DeviceTypeID:{DeviceTypeID}");
	}
}
