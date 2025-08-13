using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class ReportContextType : IRobloxEntity<byte, ReportContextTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ReportContextTypeDAL _EntityDAL;

	public static ReportContextType WebsiteContext;

	public static ReportContextType InGameContext;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
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

	public DateTime Created
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

	public DateTime Updated
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

	static ReportContextType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReportContextType).ToString(), isNullCacheable: true);
		WebsiteContext = Get("Website");
		InGameContext = Get("Game");
	}

	public ReportContextType()
	{
		_EntityDAL = new ReportContextTypeDAL();
	}

	public void Delete()
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

	internal static ReportContextType CreateNew(string value)
	{
		ReportContextType reportContextType = new ReportContextType();
		reportContextType.Value = value;
		reportContextType.Save();
		return reportContextType;
	}

	public static ReportContextType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ReportContextTypeDAL, ReportContextType>(EntityCacheInfo, id, () => ReportContextTypeDAL.Get(id));
	}

	public static ReportContextType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ReportContextTypeDAL, ReportContextType>(EntityCacheInfo, "Value:" + value, () => ReportContextTypeDAL.GetByValue(value));
	}

	public void Construct(ReportContextTypeDAL dal)
	{
		_EntityDAL = dal;
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
}
