using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Chat.Entities;

internal class ParticipantType : IRobloxEntity<int, ParticipantTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private ParticipantTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ParticipantType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public ParticipantType()
	{
		_EntityDAL = new ParticipantTypeDAL();
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

	internal static ParticipantType Get(int id)
	{
		return EntityHelper.GetEntity<int, ParticipantTypeDAL, ParticipantType>(EntityCacheInfo, id, () => ParticipantTypeDAL.Get(id));
	}

	private static ICollection<ParticipantType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ParticipantTypeDAL, ParticipantType>(ids, EntityCacheInfo, ParticipantTypeDAL.MultiGet);
	}

	public static ParticipantType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, ParticipantType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static ParticipantType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, ParticipantTypeDAL, ParticipantType>(() => ParticipantTypeDAL.GetOrCreateParticipantType(value));
	}

	public void Construct(ParticipantTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
