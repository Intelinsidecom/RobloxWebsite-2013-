using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Notifications.Core.Properties;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class Receiver : IRobloxEntity<long, ReceiverDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private ReceiverDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Receiver).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal int ReceiverTypeID
	{
		get
		{
			return _EntityDAL.ReceiverTypeID;
		}
		set
		{
			_EntityDAL.ReceiverTypeID = value;
		}
	}

	internal long ReceiverTargetID
	{
		get
		{
			return _EntityDAL.ReceiverTargetID;
		}
		set
		{
			_EntityDAL.ReceiverTargetID = value;
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

	public Receiver()
	{
		_EntityDAL = new ReceiverDAL();
	}

	public Receiver(ReceiverDAL receiverDAL)
	{
		_EntityDAL = receiverDAL;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	internal void Delete()
	{
		if (Settings.Default.IsRemoteCacheForReceiverEnabled)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (Settings.Default.IsRemoteCacheForReceiverEnabled)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
			{
				_EntityDAL.Created = DateTime.Now;
				_EntityDAL.Insert();
			}, _EntityDAL.Update);
		}
		else
		{
			EntityHelper.SaveEntity(this, delegate
			{
				_EntityDAL.Created = DateTime.Now;
				_EntityDAL.Insert();
			}, _EntityDAL.Update);
		}
	}

	internal static Receiver Get(long id)
	{
		return EntityHelper.GetEntity<long, ReceiverDAL, Receiver>(EntityCacheInfo, id, () => ReceiverDAL.Get(id));
	}

	private static ICollection<Receiver> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ReceiverDAL, Receiver>(ids, EntityCacheInfo, ReceiverDAL.MultiGet);
	}

	public static Receiver GetOrCreate(int receiverTypeID, long receiverTargetID)
	{
		if (Settings.Default.IsRemoteCacheForReceiverEnabled)
		{
			return EntityHelper.GetOrCreateEntityWithRemoteCache<long, Receiver>(EntityCacheInfo, GetLookupCacheKeysByReceiverTypeIDReceiverTargetID(receiverTypeID, receiverTargetID), () => DoGetOrCreate(receiverTypeID, receiverTargetID), Get);
		}
		return EntityHelper.GetOrCreateEntity<long, Receiver>(EntityCacheInfo, GetLookupCacheKeysByReceiverTypeIDReceiverTargetID(receiverTypeID, receiverTargetID), () => DoGetOrCreate(receiverTypeID, receiverTargetID));
	}

	private static Receiver DoGetOrCreate(int receiverTypeID, long receiverTargetID)
	{
		return EntityHelper.DoGetOrCreate<long, ReceiverDAL, Receiver>(() => ReceiverDAL.GetOrCreateReceiver(receiverTypeID, receiverTargetID));
	}

	public void Construct(ReceiverDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByReceiverTypeIDReceiverTargetID(ReceiverTypeID, ReceiverTargetID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByReceiverTypeIDReceiverTargetID(int receiverTypeID, long receiverTargetID)
	{
		return $"ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}";
	}
}
