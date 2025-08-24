using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class Partner : IRobloxEntity<int, PartnerDAL>, ICacheableObject<int>, ICacheableObject
{
	private PartnerDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(Partner).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
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

	public bool IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_EntityDAL.IsActive = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Partner()
	{
		_EntityDAL = new PartnerDAL();
	}

	internal void Delete()
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

	public static Partner CreateNew(string name, byte activepercentage, bool isActive)
	{
		Partner partner = new Partner();
		partner.Name = name;
		partner.IsActive = isActive;
		partner.Save();
		return partner;
	}

	public static Partner Get(int id)
	{
		return EntityHelper.GetEntity<int, PartnerDAL, Partner>(EntityCacheInfo, id, () => PartnerDAL.Get(id));
	}

	public static ICollection<Partner> GetPartnerIDs_Paged(int startIndex, int maxRows)
	{
		string collectionId = $"GetPartnerIDs_Paged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => PartnerDAL.GetPartnerIDs_Paged(startIndex + 1, maxRows), Get);
	}

	public static Partner GetPartnerByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, PartnerDAL, Partner>(EntityCacheInfo, $"Name:{name}", () => PartnerDAL.GetByName(name));
	}

	public void Construct(PartnerDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
