using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerStatusType : IRobloxEntity<byte, PrivateServerStatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PrivateServerStatusTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerStatusType).ToString(), isNullCacheable: true);

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

	public PrivateServerStatusType()
	{
		_EntityDAL = new PrivateServerStatusTypeDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
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

	internal static PrivateServerStatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PrivateServerStatusTypeDAL, PrivateServerStatusType>(EntityCacheInfo, id, () => PrivateServerStatusTypeDAL.Get(id));
	}

	internal static ICollection<PrivateServerStatusType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, PrivateServerStatusTypeDAL, PrivateServerStatusType>(ids, EntityCacheInfo, PrivateServerStatusTypeDAL.MultiGet);
	}

	public static PrivateServerStatusType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PrivateServerStatusTypeDAL, PrivateServerStatusType>(EntityCacheInfo, $"Value:{value}", () => PrivateServerStatusTypeDAL.GetPrivateServerStatusTypeByValue(value));
	}

	public void Construct(PrivateServerStatusTypeDAL dal)
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
