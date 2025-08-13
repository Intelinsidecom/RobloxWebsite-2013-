using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerStatusChangeReasonType : IRobloxEntity<byte, PrivateServerStatusChangeReasonTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PrivateServerStatusChangeReasonTypeDAL _EntityDAL;

	public static readonly PrivateServerStatusChangeReasonType UserInitiated;

	public static readonly PrivateServerStatusChangeReasonType InsufficientFunds;

	public static readonly PrivateServerStatusChangeReasonType DisallowedByGameDeveloper;

	public static readonly PrivateServerStatusChangeReasonType RenewalSuccess;

	public static readonly PrivateServerStatusChangeReasonType RenewalRollback;

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

	public PrivateServerStatusChangeReasonType()
	{
		_EntityDAL = new PrivateServerStatusChangeReasonTypeDAL();
	}

	static PrivateServerStatusChangeReasonType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerStatusChangeReasonType).ToString(), isNullCacheable: true);
		UserInitiated = GetByValue("UserInitiated");
		InsufficientFunds = GetByValue("InsufficientFunds");
		DisallowedByGameDeveloper = GetByValue("DisallowedByGameDeveloper");
		RenewalSuccess = GetByValue("RenewalSuccess");
		RenewalRollback = GetByValue("RenewalRollback");
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

	internal static PrivateServerStatusChangeReasonType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PrivateServerStatusChangeReasonTypeDAL, PrivateServerStatusChangeReasonType>(EntityCacheInfo, id, () => PrivateServerStatusChangeReasonTypeDAL.Get(id));
	}

	internal static ICollection<PrivateServerStatusChangeReasonType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, PrivateServerStatusChangeReasonTypeDAL, PrivateServerStatusChangeReasonType>(ids, EntityCacheInfo, PrivateServerStatusChangeReasonTypeDAL.MultiGet);
	}

	public static PrivateServerStatusChangeReasonType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PrivateServerStatusChangeReasonTypeDAL, PrivateServerStatusChangeReasonType>(EntityCacheInfo, $"Value:{value}", () => PrivateServerStatusChangeReasonTypeDAL.GetPrivateServerStatusChangeReasonTypeByValue(value));
	}

	public void Construct(PrivateServerStatusChangeReasonTypeDAL dal)
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
