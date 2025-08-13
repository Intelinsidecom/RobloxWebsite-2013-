using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class SubjectType : IRobloxEntity<int, SubjectTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private SubjectTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SubjectType).ToString(), isNullCacheable: true);

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

	public SubjectType()
	{
		_EntityDAL = new SubjectTypeDAL();
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

	internal static SubjectType Get(int id)
	{
		return EntityHelper.GetEntity<int, SubjectTypeDAL, SubjectType>(EntityCacheInfo, id, () => SubjectTypeDAL.Get(id));
	}

	internal static ICollection<SubjectType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, SubjectTypeDAL, SubjectType>(ids, EntityCacheInfo, SubjectTypeDAL.MultiGet);
	}

	private static SubjectType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, SubjectTypeDAL, SubjectType>(() => SubjectTypeDAL.GetOrCreateSubjectType(value));
	}

	public static SubjectType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, SubjectType>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	public static SubjectType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, SubjectTypeDAL, SubjectType>(EntityCacheInfo, $"Value:{value}", () => SubjectTypeDAL.GetSubjectTypeByValue(value));
	}

	public void Construct(SubjectTypeDAL dal)
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
