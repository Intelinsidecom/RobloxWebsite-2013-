using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Classification;

public class DeviceType : IRobloxEntity<byte, DeviceTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private DeviceTypeDAL _EntityDAL;

	public static readonly byte ComputerId;

	public static string ComputerValue;

	public static readonly byte PhoneId;

	public static string PhoneValue;

	public static readonly byte TabletId;

	public static string TabletValue;

	public static readonly byte ConsoleId;

	public static string ConsoleValue;

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

	public byte BitOrdinal
	{
		get
		{
			return _EntityDAL.BitOrdinal;
		}
		set
		{
			_EntityDAL.BitOrdinal = value;
		}
	}

	public long BitMask
	{
		get
		{
			return _EntityDAL.BitMask;
		}
		set
		{
			_EntityDAL.BitMask = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	static DeviceType()
	{
		ComputerValue = "Computer";
		PhoneValue = "Phone";
		TabletValue = "Tablet";
		ConsoleValue = "Console";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(DeviceType).ToString(), isNullCacheable: true);
		ComputerId = GetByValue(ComputerValue).ID;
		PhoneId = GetByValue(PhoneValue).ID;
		TabletId = GetByValue(TabletValue).ID;
		ConsoleId = GetByValue(ConsoleValue).ID;
	}

	public DeviceType()
	{
		_EntityDAL = new DeviceTypeDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static DeviceType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, DeviceTypeDAL, DeviceType>(EntityCacheInfo, id, () => DeviceTypeDAL.Get(id));
	}

	public static DeviceType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, DeviceTypeDAL, DeviceType>(EntityCacheInfo, $"Value:{value}", () => DeviceTypeDAL.GetDeviceTypeByValue(value));
	}

	public static DeviceType GetByBitOrdinal(byte bitOrdinal)
	{
		return EntityHelper.GetEntityByLookup<byte, DeviceTypeDAL, DeviceType>(EntityCacheInfo, $"BitOrdinal:{bitOrdinal}", () => DeviceTypeDAL.GetDeviceTypeByBitOrdinal(bitOrdinal));
	}

	public void Construct(DeviceTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
		yield return $"BitOrdinal:{BitOrdinal}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
