using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditEntryCAL : IRobloxEntity<long, AssetsAuditEntryDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AssetsAuditEntryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AssetsAuditEntryCAL).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid PublicID
	{
		get
		{
			return _EntityDAL.PublicID;
		}
		set
		{
			_EntityDAL.PublicID = value;
		}
	}

	internal long Audit_ID
	{
		get
		{
			return _EntityDAL.Audit_ID;
		}
		set
		{
			_EntityDAL.Audit_ID = value;
		}
	}

	internal int Audit_AssetTypeID
	{
		get
		{
			return _EntityDAL.Audit_AssetTypeID;
		}
		set
		{
			_EntityDAL.Audit_AssetTypeID = value;
		}
	}

	internal string Audit_Hash
	{
		get
		{
			return _EntityDAL.Audit_Hash;
		}
		set
		{
			_EntityDAL.Audit_Hash = value;
		}
	}

	internal string Audit_Name
	{
		get
		{
			return _EntityDAL.Audit_Name;
		}
		set
		{
			_EntityDAL.Audit_Name = value;
		}
	}

	internal string Audit_Description
	{
		get
		{
			return _EntityDAL.Audit_Description;
		}
		set
		{
			_EntityDAL.Audit_Description = value;
		}
	}

	internal DateTime Audit_Created
	{
		get
		{
			return _EntityDAL.Audit_Created;
		}
		set
		{
			_EntityDAL.Audit_Created = value;
		}
	}

	internal DateTime Audit_Updated
	{
		get
		{
			return _EntityDAL.Audit_Updated;
		}
		set
		{
			_EntityDAL.Audit_Updated = value;
		}
	}

	internal long Audit_CreatorID
	{
		get
		{
			return _EntityDAL.Audit_CreatorID;
		}
		set
		{
			_EntityDAL.Audit_CreatorID = value;
		}
	}

	internal long Audit_CurrentVersionID
	{
		get
		{
			return _EntityDAL.Audit_CurrentVersionID;
		}
		set
		{
			_EntityDAL.Audit_CurrentVersionID = value;
		}
	}

	internal long? Audit_AssetHashID
	{
		get
		{
			return _EntityDAL.Audit_AssetHashID;
		}
		set
		{
			_EntityDAL.Audit_AssetHashID = value;
		}
	}

	internal long Audit_AssetGenres
	{
		get
		{
			return _EntityDAL.Audit_AssetGenres;
		}
		set
		{
			_EntityDAL.Audit_AssetGenres = value;
		}
	}

	internal long Audit_AssetCategories
	{
		get
		{
			return _EntityDAL.Audit_AssetCategories;
		}
		set
		{
			_EntityDAL.Audit_AssetCategories = value;
		}
	}

	internal bool? Audit_IsArchived
	{
		get
		{
			return _EntityDAL.Audit_IsArchived;
		}
		set
		{
			_EntityDAL.Audit_IsArchived = value;
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

	public AssetsAuditEntryCAL()
	{
		_EntityDAL = new AssetsAuditEntryDAL();
	}

	public AssetsAuditEntryCAL(AssetsAuditEntryDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.PublicID = Guid.NewGuid();
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static AssetsAuditEntryCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetsAuditEntryDAL, AssetsAuditEntryCAL>(EntityCacheInfo, id, () => AssetsAuditEntryDAL.Get(id));
	}

	internal static ICollection<AssetsAuditEntryCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AssetsAuditEntryDAL, AssetsAuditEntryCAL>(ids, EntityCacheInfo, AssetsAuditEntryDAL.MultiGet);
	}

	public static AssetsAuditEntryCAL GetByPublicID(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<long, AssetsAuditEntryDAL, AssetsAuditEntryCAL>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => AssetsAuditEntryDAL.GetAssetsAuditEntryByPublicID(publicId));
	}

	public void Construct(AssetsAuditEntryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPublicID(PublicID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByPublicID(Guid publicId)
	{
		return $"PublicID:{publicId}";
	}
}
