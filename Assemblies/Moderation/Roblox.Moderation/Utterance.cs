using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class Utterance : IRobloxEntity<long, UtteranceDAL>, ICacheableObject<long>, ICacheableObject
{
	private UtteranceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Utterance", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	private Guid GUID
	{
		get
		{
			return _EntityDAL.GUID;
		}
		set
		{
			_EntityDAL.GUID = value;
		}
	}

	public long ExpressionID
	{
		get
		{
			return _EntityDAL.ExpressionID;
		}
		set
		{
			_EntityDAL.ExpressionID = value;
		}
	}

	public Expression Expression
	{
		get
		{
			return Expression.Get(ExpressionID);
		}
		set
		{
			if (value == null)
			{
				ExpressionID = 0L;
			}
			else
			{
				ExpressionID = value.ID;
			}
		}
	}

	public long UttererID
	{
		get
		{
			return _EntityDAL.UttererID;
		}
		set
		{
			_EntityDAL.UttererID = value;
		}
	}

	public byte UtteranceSourceTypeID
	{
		get
		{
			return _EntityDAL.UtteranceSourceTypeID;
		}
		set
		{
			_EntityDAL.UtteranceSourceTypeID = value;
		}
	}

	public UtteranceSourceType SourceType
	{
		get
		{
			return UtteranceSourceType.Get(UtteranceSourceTypeID);
		}
		set
		{
			if (value == null)
			{
				UtteranceSourceTypeID = 0;
			}
			else
			{
				UtteranceSourceTypeID = value.ID;
			}
		}
	}

	public long? UtteranceSourceObjectID
	{
		get
		{
			return _EntityDAL.UtteranceSourceObjectID;
		}
		set
		{
			_EntityDAL.UtteranceSourceObjectID = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Utterance()
	{
		_EntityDAL = new UtteranceDAL();
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static string BuildEntityIDLookup(long expressionId, long uttererId, byte utteranceSourceTypeId, long? utteranceSourceObjectId)
	{
		return $"ExpressionID:{expressionId}_UttererID:{uttererId}_UtteranceSourceTypeID:{utteranceSourceTypeId}_UtteranceSourceObjectID:{utteranceSourceObjectId}";
	}

	private static Utterance DoGet(long id)
	{
		return EntityHelper.DoGet<long, UtteranceDAL, Utterance>(() => UtteranceDAL.Get(id), id);
	}

	private static Utterance DoGet(Guid guid)
	{
		return EntityHelper.DoGetByLookup<long, UtteranceDAL, Utterance>(() => UtteranceDAL.Get(guid), guid.ToString());
	}

	private static Utterance DoGet(long expressionId, long uttererId, byte utteranceSourceTypeId, long? utteranceSourceObjectId)
	{
		return EntityHelper.DoGetByLookup<long, UtteranceDAL, Utterance>(() => UtteranceDAL.Get(expressionId, uttererId, utteranceSourceTypeId, utteranceSourceObjectId), BuildEntityIDLookup(expressionId, uttererId, utteranceSourceTypeId, utteranceSourceObjectId));
	}

	private static Utterance DoGetOrCreate(long expressionId, long uttererId, byte utteranceSourceTypeId, long? utteranceSourceObjectId)
	{
		return EntityHelper.DoGetOrCreate<long, UtteranceDAL, Utterance>(() => UtteranceDAL.GetOrCreate(expressionId, uttererId, utteranceSourceTypeId, utteranceSourceObjectId));
	}

	internal static Utterance CreateNew(Expression expression, long uttererId, IUtteranceSource utteranceSource)
	{
		Utterance utterance = new Utterance();
		utterance.GUID = Guid.NewGuid();
		utterance.Expression = expression;
		utterance.UttererID = uttererId;
		utterance.SourceType = utteranceSource.Type;
		utterance.UtteranceSourceObjectID = utteranceSource.SourceID;
		utterance.Save();
		return utterance;
	}

	internal static Utterance CreateNew(IUtterable utterableItem)
	{
		return CreateNew(Expression.GetOrCreate(utterableItem.ExpressionText), utterableItem.UttererID, utterableItem.Source);
	}

	private static Utterance Get(Guid guid)
	{
		return EntityHelper.GetEntityByLookupOld<long, Utterance>(EntityCacheInfo, guid.ToString(), () => DoGet(guid));
	}

	internal static Utterance Get(long expressionId, long uttererId, byte utteranceSourceTypeId, long? utteranceSourceObjectId)
	{
		return EntityHelper.GetEntityByLookupOld<long, Utterance>(EntityCacheInfo, BuildEntityIDLookup(expressionId, uttererId, utteranceSourceTypeId, utteranceSourceObjectId), () => DoGet(expressionId, uttererId, utteranceSourceTypeId, utteranceSourceObjectId));
	}

	public static Utterance GetOrCreate(long expressionId, long uttererId, byte utteranceSourceTypeId, long? utteranceSourceObjectId)
	{
		return EntityHelper.GetOrCreateEntity<long, Utterance>(EntityCacheInfo, BuildEntityIDLookup(expressionId, uttererId, utteranceSourceTypeId, utteranceSourceObjectId), () => DoGetOrCreate(expressionId, uttererId, utteranceSourceTypeId, utteranceSourceObjectId));
	}

	public static Utterance Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static Utterance Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<Utterance> GetUtterancesBySourceObjectIDAndSourceTypeID(long sourceObjectID, byte sourceTypeID)
	{
		if (sourceObjectID == 0L)
		{
			return new List<Utterance>();
		}
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SourceObjectID:{sourceObjectID}_SourceTypeID:{sourceTypeID}"), $"GetUtterancesBySourceObjectIDAndSourceTypeID_SourceObjectID:{sourceObjectID}_SourceTypeID:{sourceTypeID}", () => UtteranceDAL.GetUtteranceIDsBySourceObjectIDAndSourceTypeID(sourceObjectID, sourceTypeID), Get);
	}

	public void Construct(UtteranceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GUID.ToString();
		yield return BuildEntityIDLookup(ExpressionID, UttererID, UtteranceSourceTypeID, UtteranceSourceObjectID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken($"SourceObjectID:{UtteranceSourceObjectID}_SourceTypeID:{UtteranceSourceTypeID}")
		};
	}
}
