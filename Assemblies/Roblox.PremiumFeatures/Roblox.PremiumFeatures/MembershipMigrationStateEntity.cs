using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationStateEntity : IRobloxEntity<int, MembershipMigrationStateDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private MembershipMigrationStateDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(MembershipMigrationStateEntity).ToString(), isNullCacheable: true);

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

	public MembershipMigrationStateEntity()
	{
		_EntityDAL = new MembershipMigrationStateDAL();
	}

	public MembershipMigrationStateEntity(MembershipMigrationStateDAL entityDAL)
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
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	internal static MembershipMigrationStateEntity Get(int id)
	{
		return EntityHelper.GetEntity<int, MembershipMigrationStateDAL, MembershipMigrationStateEntity>(EntityCacheInfo, id, () => MembershipMigrationStateDAL.Get(id));
	}

	private static ICollection<MembershipMigrationStateEntity> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, MembershipMigrationStateDAL, MembershipMigrationStateEntity>(ids, EntityCacheInfo, MembershipMigrationStateDAL.MultiGet);
	}

	internal static MembershipMigrationStateEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, MembershipMigrationStateDAL, MembershipMigrationStateEntity>(EntityCacheInfo, $"Value:{value}", () => MembershipMigrationStateDAL.GetByValue(value));
	}

	public void Construct(MembershipMigrationStateDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetCacheQualifierByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierByValue(string value)
	{
		return $"MembershipMigrationStateValue:{value}";
	}
}
