using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Outfits;

public class BodyColorSet : IRobloxEntity<long, BodyColorSetDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private BodyColorSetDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(BodyColorSet).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int HeadColorID
	{
		get
		{
			return _EntityDAL.HeadColorID;
		}
		set
		{
			_EntityDAL.HeadColorID = value;
		}
	}

	public int LeftArmColorID
	{
		get
		{
			return _EntityDAL.LeftArmColorID;
		}
		set
		{
			_EntityDAL.LeftArmColorID = value;
		}
	}

	public int LeftLegColorID
	{
		get
		{
			return _EntityDAL.LeftLegColorID;
		}
		set
		{
			_EntityDAL.LeftLegColorID = value;
		}
	}

	public int RightArmColorID
	{
		get
		{
			return _EntityDAL.RightArmColorID;
		}
		set
		{
			_EntityDAL.RightArmColorID = value;
		}
	}

	public int RightLegColorID
	{
		get
		{
			return _EntityDAL.RightLegColorID;
		}
		set
		{
			_EntityDAL.RightLegColorID = value;
		}
	}

	public int TorsoColorID
	{
		get
		{
			return _EntityDAL.TorsoColorID;
		}
		set
		{
			_EntityDAL.TorsoColorID = value;
		}
	}

	public string BodyColorSetHash
	{
		get
		{
			return _EntityDAL.BodyColorSetHash;
		}
		set
		{
			_EntityDAL.BodyColorSetHash = value;
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

	public BodyColorSet()
	{
		_EntityDAL = new BodyColorSetDAL();
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

	public static BodyColorSet CreateNew(int headColorId, int leftArmColorId, int leftLegColorId, int rightArmColorId, int rightLegColorId, int torsoColorId, string bodyColorSetHash)
	{
		BodyColorSet bodyColorSet = new BodyColorSet();
		bodyColorSet.HeadColorID = headColorId;
		bodyColorSet.LeftArmColorID = leftArmColorId;
		bodyColorSet.LeftLegColorID = leftLegColorId;
		bodyColorSet.RightArmColorID = rightArmColorId;
		bodyColorSet.RightLegColorID = rightLegColorId;
		bodyColorSet.TorsoColorID = torsoColorId;
		bodyColorSet.BodyColorSetHash = bodyColorSetHash;
		bodyColorSet.Save();
		return bodyColorSet;
	}

	public static BodyColorSet Get(long id)
	{
		return EntityHelper.GetEntity<long, BodyColorSetDAL, BodyColorSet>(EntityCacheInfo, id, () => BodyColorSetDAL.Get(id));
	}

	public static BodyColorSet GetByHash(string hash)
	{
		return EntityHelper.GetEntityByLookup<long, BodyColorSetDAL, BodyColorSet>(EntityCacheInfo, $"BodyColorSetHash:{hash}", () => BodyColorSetDAL.GetByHash(hash));
	}

	public static BodyColorSet GetOrCreate(int headColorId, int leftArmColorId, int leftLegColorId, int rightArmColorId, int rightLegColorId, int torsoColorId, string bodyColorSetHash)
	{
		return EntityHelper.GetOrCreateEntity<long, BodyColorSet>(EntityCacheInfo, $"HeadColorID:{headColorId}LeftArmColorID:{leftArmColorId}LeftLegColorID:{leftLegColorId}RightArmColorID:{rightArmColorId}RightLegColorID:{rightLegColorId}TorsoColorID:{torsoColorId}".Trim(), () => DoGetOrCreate(headColorId, leftArmColorId, leftLegColorId, rightArmColorId, rightLegColorId, torsoColorId, bodyColorSetHash));
	}

	private static BodyColorSet DoGetOrCreate(int headColorId, int leftArmColorId, int leftLegColorId, int rightArmColorId, int rightLegColorId, int torsoColorId, string bodyColorSetHash)
	{
		return EntityHelper.DoGetOrCreate<long, BodyColorSetDAL, BodyColorSet>(() => BodyColorSetDAL.GetOrCreate(headColorId, leftArmColorId, leftLegColorId, rightArmColorId, rightLegColorId, torsoColorId, bodyColorSetHash));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(BodyColorSetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"HeadColorID:{HeadColorID}LeftArmColorID:{LeftArmColorID}LeftLegColorID:{LeftLegColorID}RightArmColorID:{RightArmColorID}RightLegColorID:{RightLegColorID}TorsoColorID:{TorsoColorID}";
		yield return $"BodyColorSetHash:{BodyColorSetHash}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
