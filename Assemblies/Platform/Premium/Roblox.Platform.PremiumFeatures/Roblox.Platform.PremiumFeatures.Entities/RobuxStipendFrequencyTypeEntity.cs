using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures.Entities;

/// <summary>
/// The various frequencies that a <see cref="T:Roblox.PremiumFeatures.RobuxStipend" /> may be awarded.
/// </summary>
internal class RobuxStipendFrequencyTypeEntity : IRobloxEntity<byte, RobuxStipendFrequencyTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private RobuxStipendFrequencyTypeDAL _EntityDAL;

	private static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(RobuxStipendFrequencyTypeEntity).ToString(), isNullCacheable: true);

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

	internal DateTime? CreatedUtc => _EntityDAL.CreatedUtc;

	internal DateTime? UpdatedUtc => _EntityDAL.UpdatedUtc;

	public CacheInfo CacheInfo => EntityCacheInfo;

	/// <summary>
	/// The rate at which a Robux stipend is distributed/awarded.
	/// </summary>
	public RobuxStipendFrequencyTypeEntity()
	{
		_EntityDAL = new RobuxStipendFrequencyTypeDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.CreatedUtc = DateTime.Now;
			_EntityDAL.UpdatedUtc = _EntityDAL.CreatedUtc;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.UpdatedUtc = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static RobuxStipendFrequencyTypeEntity Get(byte id)
	{
		return EntityHelper.GetEntity<byte, RobuxStipendFrequencyTypeDAL, RobuxStipendFrequencyTypeEntity>(EntityCacheInfo, id, () => RobuxStipendFrequencyTypeDAL.Get(id));
	}

	internal static RobuxStipendFrequencyTypeEntity Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static RobuxStipendFrequencyTypeEntity GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, RobuxStipendFrequencyTypeDAL, RobuxStipendFrequencyTypeEntity>(EntityCacheInfo, $"Value:{value}", () => RobuxStipendFrequencyTypeDAL.GetByValue(value));
	}

	public void Construct(RobuxStipendFrequencyTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
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
