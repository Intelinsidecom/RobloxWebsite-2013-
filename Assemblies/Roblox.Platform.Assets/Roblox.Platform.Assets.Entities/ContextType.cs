using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class ContextType : IRobloxEntity<byte, ContextTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ContextTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ContextType).ToString(), isNullCacheable: true, Settings.Default.AssetCreationsCacheInvalidationPort);

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

	internal DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ContextType()
	{
		_EntityDAL = new ContextTypeDAL();
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
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static ContextType CreateNew(string value)
	{
		ContextType contextType = new ContextType();
		contextType.Value = value;
		contextType.Save();
		return contextType;
	}

	internal static ContextType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ContextTypeDAL, ContextType>(EntityCacheInfo, id, () => ContextTypeDAL.Get(id));
	}

	internal static ContextType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ContextTypeDAL, ContextType>(EntityCacheInfo, "Value:" + value, () => ContextTypeDAL.GetByValue(value));
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "Value:" + Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public void Construct(ContextTypeDAL dal)
	{
		_EntityDAL = dal;
	}
}
