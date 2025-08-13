using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationMediaType : IRobloxEntity<byte, TwoStepVerificationMediaTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private TwoStepVerificationMediaTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TwoStepVerificationMediaType).ToString(), isNullCacheable: true);

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

	public TwoStepVerificationMediaType()
	{
		_EntityDAL = new TwoStepVerificationMediaTypeDAL();
	}

	public TwoStepVerificationMediaType(TwoStepVerificationMediaTypeDAL entityDAL)
	{
		_EntityDAL = new TwoStepVerificationMediaTypeDAL();
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

	internal static TwoStepVerificationMediaType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, TwoStepVerificationMediaTypeDAL, TwoStepVerificationMediaType>(EntityCacheInfo, id, () => TwoStepVerificationMediaTypeDAL.Get(id));
	}

	private static ICollection<TwoStepVerificationMediaType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, TwoStepVerificationMediaTypeDAL, TwoStepVerificationMediaType>(ids, EntityCacheInfo, TwoStepVerificationMediaTypeDAL.MultiGet);
	}

	public static TwoStepVerificationMediaType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, TwoStepVerificationMediaTypeDAL, TwoStepVerificationMediaType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => TwoStepVerificationMediaTypeDAL.GetTwoStepVerificationMediaTypeByValue(value));
	}

	public void Construct(TwoStepVerificationMediaTypeDAL dal)
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

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
