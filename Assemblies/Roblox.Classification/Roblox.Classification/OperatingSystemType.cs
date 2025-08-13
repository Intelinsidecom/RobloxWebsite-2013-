using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Classification;

public class OperatingSystemType : IRobloxEntity<byte, OperatingSystemTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private OperatingSystemTypeDAL _EntityDAL;

	public static readonly byte iOSID;

	public static string iOSValue;

	public static readonly byte AndroidID;

	public static string AndroidValue;

	public static readonly byte OSXID;

	public static string OSXValue;

	public static readonly byte WindowsID;

	public static string WindowsValue;

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

	static OperatingSystemType()
	{
		iOSValue = "iOS";
		AndroidValue = "Android";
		OSXValue = "OSX";
		WindowsValue = "Windows";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(OperatingSystemType).ToString(), isNullCacheable: true);
		iOSID = GetByValue(iOSValue).ID;
		OSXID = GetByValue(OSXValue).ID;
		AndroidID = GetByValue(AndroidValue).ID;
		WindowsID = GetByValue(WindowsValue).ID;
	}

	public OperatingSystemType()
	{
		_EntityDAL = new OperatingSystemTypeDAL();
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

	private static OperatingSystemType CreateNew(string value)
	{
		OperatingSystemType operatingSystemType = new OperatingSystemType();
		operatingSystemType.Value = value;
		operatingSystemType.Save();
		return operatingSystemType;
	}

	public static OperatingSystemType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, OperatingSystemTypeDAL, OperatingSystemType>(EntityCacheInfo, id, () => OperatingSystemTypeDAL.Get(id));
	}

	public static OperatingSystemType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, OperatingSystemTypeDAL, OperatingSystemType>(EntityCacheInfo, $"Value:{value}", () => OperatingSystemTypeDAL.GetOperatingSystemTypeByValue(value));
	}

	public void Construct(OperatingSystemTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
