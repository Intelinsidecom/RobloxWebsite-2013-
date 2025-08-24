using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class ReportContext : IRobloxEntity<long, ReportContextDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReportContextDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReportContext).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public byte ReportContextTypeID
	{
		get
		{
			return _EntityDAL.ReportContextTypeID;
		}
		set
		{
			_EntityDAL.ReportContextTypeID = value;
		}
	}

	public long ReportContextID
	{
		get
		{
			return _EntityDAL.ReportContextID;
		}
		set
		{
			_EntityDAL.ReportContextID = value;
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

	public ReportContext()
	{
		_EntityDAL = new ReportContextDAL();
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

	internal static ReportContext CreateNew(long reportContextID, byte reportContextTypeID)
	{
		ReportContext reportContext = new ReportContext();
		reportContext.ReportContextTypeID = reportContextTypeID;
		reportContext.ReportContextID = reportContextID;
		reportContext.Save();
		return reportContext;
	}

	public static ReportContext Get(long id)
	{
		return EntityHelper.GetEntity<long, ReportContextDAL, ReportContext>(EntityCacheInfo, id, () => ReportContextDAL.Get(id));
	}

	public static ReportContext GetOrCreate(long reportContextID, byte reportContextTypeID)
	{
		return EntityHelper.GetOrCreateEntity<long, ReportContext>(EntityCacheInfo, $"ReportContextID:{reportContextID}_ReportContextTypeID:{reportContextTypeID}", () => DoGetOrCreate(reportContextID, reportContextTypeID));
	}

	private static ReportContext DoGetOrCreate(long reportContextID, byte reportContextTypeID)
	{
		return EntityHelper.DoGetOrCreate<long, ReportContextDAL, ReportContext>(() => ReportContextDAL.GetOrCreate(reportContextID, reportContextTypeID));
	}

	public void Construct(ReportContextDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "ReportContextID:" + ReportContextID + "_ReportContextTypeID:" + ReportContextTypeID;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
