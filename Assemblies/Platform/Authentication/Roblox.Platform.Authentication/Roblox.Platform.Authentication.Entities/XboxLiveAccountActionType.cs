using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Authentication.Entities;

internal class XboxLiveAccountActionType : IRobloxEntity<byte, XboxLiveAccountActionTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private XboxLiveAccountActionTypeDAL _EntityDAL;

	public static XboxLiveAccountActionType LinkAccount;

	public static XboxLiveAccountActionType UnlinkAccount;

	public static XboxLiveAccountActionType SetUsernamePassword;

	public static XboxLiveAccountActionType GamerTagHashChanged;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	internal string Value
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	static XboxLiveAccountActionType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(XboxLiveAccountActionType).ToString(), isNullCacheable: true);
		LinkAccount = GetByValue("Link Account");
		UnlinkAccount = GetByValue("Unlink Account");
		SetUsernamePassword = GetByValue("Set Username Password");
		GamerTagHashChanged = GetByValue("GamerTagHash Changed");
	}

	public XboxLiveAccountActionType()
	{
		_EntityDAL = new XboxLiveAccountActionTypeDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal static XboxLiveAccountActionType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, XboxLiveAccountActionTypeDAL, XboxLiveAccountActionType>(EntityCacheInfo, id, () => XboxLiveAccountActionTypeDAL.Get(id));
	}

	internal static ICollection<XboxLiveAccountActionType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, XboxLiveAccountActionTypeDAL, XboxLiveAccountActionType>(ids, EntityCacheInfo, XboxLiveAccountActionTypeDAL.MultiGet);
	}

	public static XboxLiveAccountActionType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, XboxLiveAccountActionTypeDAL, XboxLiveAccountActionType>(EntityCacheInfo, $"Value:{value}", () => XboxLiveAccountActionTypeDAL.GetXboxLiveAccountActionTypeByValue(value));
	}

	public void Construct(XboxLiveAccountActionTypeDAL dal)
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
